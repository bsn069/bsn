package gate

import (
	"net"
	"fmt"
)

type SClientMgr struct {
	M_u8InitStep uint8
	M_Listener      net.Listener
	M_strListenAddr string
}

func (this *SClientMgr) addr() string {
	return this.M_strListenAddr
}

func (this *SClientMgr) listener() net.Listener {
	return this.M_Listener
}

func (this *SClientMgr) SetAddr(strAddr string) error {
	this.M_strListenAddr = strAddr
	return nil
}

func (this *SClientMgr) Listen() error {
	var err error
	this.M_Listener, err = net.Listen("tcp", this.addr())
	if err != nil {
		return err
	}

	go this.listenWorker()
	return nil
}

func (this *SClientMgr) StopListen()  {
	if this.listener() == nil {
		fmt.Println("not listen")
		return
	}
	this.listener().Close()
	this.M_Listener = nil
}

func (this *SClientMgr) listenWorker()  {
	for {
		vConn, err := this.listener().Accept()
		if err != nil {
			fmt.Println(err)
			break
		}
		vConn.Close()
	}
}
