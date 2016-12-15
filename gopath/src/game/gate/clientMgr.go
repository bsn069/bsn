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
}

func (this *SClientMgr) init()  {
	this.M_chanWaitStopListen = make(chan bool, 1)
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
	this.M_Listener = nil
	<-this.M_chanWaitStopListen 
	fmt.Println("stopListen end")
}

func (this *SClientMgr) listenWorker()  {
	listener := this.listener()
	for listener != nil {
		vConn, err := listener.Accept()
		if err != nil {
			fmt.Println(err)
			break
		}
		vConn.Close()
	}
	this.M_chanWaitStopListen <- true
	fmt.Println("listenWorker end")
}
