package gate

import (
	"net"
	"fmt"
)

type SClientMgr struct {
	M_u8InitStep uint8
	M_Listener      net.Listener
	M_strListenAddr string
	M_chanWaitStopListen chan bool
	M_clients []SClient
	m_u16ClientCountMax uint16
}

func (this *SClientMgr) addr() string {
	return this.M_strListenAddr
}

func (this *SClientMgr) listener() net.Listener {
	return this.M_Listener
}

func (this *SClientMgr) setAddr(strAddr string) error {
	this.M_strListenAddr = strAddr
	return nil
}

func (this *SClientMgr) start()  {
	this.m_u16ClientCountMax = 100
	this.M_chanWaitStopListen = make(chan bool, 1)
	this.M_clients = make([]SClient, 0, this.m_u16ClientCountMax)

	for i := 0; i < len(this.M_clients); i++ {
		var vClient = &this.M_clients[i]
		vClient.setId(uint16(i) + 1)
	}

	this.setAddr(":50000")
	this.startListen()
}

func (this *SClientMgr) stop()  {
	fmt.Println("stop")	
	this.stopListen()
	this.stopAllClient()
}

func (this *SClientMgr) stopAllClient()  {
	fmt.Println("stopAllClient")
	for i := 0; i < len(this.M_clients); i++ {
		var vClient = &this.M_clients[i]
		if vClient.conn() != nil {
			vClient.stop()
		}
	}
}

func (this *SClientMgr) startListen() error {
	fmt.Println("startListen")
	if this.listener() != nil {
		fmt.Println("had listen")
		return nil
	}
	var err error
	this.M_Listener, err = net.Listen("tcp", this.addr())
	if err != nil {
		return err
	}

	go this.listenWorker()
	return nil
}

func (this *SClientMgr) stopListen()  {
	fmt.Println("stopListen")
	if this.listener() == nil {
		fmt.Println("not listen")
		return
	}
	this.listener().Close()
	<-this.M_chanWaitStopListen 
	this.M_Listener = nil
	fmt.Println("stopListen end")
}

func (this *SClientMgr) listenWorker()  {
	listener := this.listener()
	for {
		vConn, err := listener.Accept()
		if err != nil {
			fmt.Println(err)
			break
		}
		this.onAccept(vConn)
	}
	this.M_chanWaitStopListen <- true
	fmt.Println("listenWorker end")
}

func (this *SClientMgr) onAccept(iConn net.Conn) {
	fmt.Println("onAccept", iConn)
	for i := 0; i < len(this.M_clients); i++ {
		var vClient = &this.M_clients[i]
		if vClient.conn() == nil {
			vClient.start(iConn)
			return
		}
	}

	// todo: gate 满了 重定向
	iConn.Close()
}