package gate

import (
	"net"
	"fmt"
	"errors"
)

type SClient struct {
    M_Conn net.Conn
    M_u16Id uint16
    M_u16ConnIndex uint16 //  每次重用 此值+1 防止消息发错客户端
    m_chanWaitStop  chan bool
}

func (this *SClient) id() uint16  {
    return this.M_u16Id
}

func (this *SClient) setId(u16Id uint16)  {
    this.M_u16Id = u16Id
}

func (this *SClient) conn() net.Conn {
    return this.M_Conn
}

func (this *SClient) setConn(iConn net.Conn)  {
    this.M_u16ConnIndex++
    this.M_Conn = iConn
}

func (this *SClient) recvWorker()  {
    fmt.Println("recvWorker begin")
    for {
        recvBuf := make([]byte, 1024)
        err := this.recv(recvBuf)
        if err != nil {
            break
        }
    }    
    this.m_chanWaitStop<-true
    fmt.Println("recvWorker end")
}

func (this *SClient) start(iConn net.Conn)  {
    this.setConn(iConn)
    go this.recvWorker()
}

func (this *SClient) stop()  {
    this.conn().Close()
    <-this.m_chanWaitStop
    this.setConn(nil)
}

func (this *SClient) send(byData []byte) error {
    vLen := len(byData)
	if vLen <= 0 {
		return nil
	}

	writeLen, err := this.conn().Write(byData)
	if err != nil {
		return err
	}
	if writeLen != vLen {
		return errors.New("not write all data")
	}
	return nil
}

func (this *SClient) recv(byData []byte) error {
	vReadLen := len(byData)

	vReadLen, err := this.conn().Read(byData)
	if err != nil {
		if err.Error() == "EOF" {
			fmt.Println("connect disconnect")
		} else {
			fmt.Println("ReadMsg error: ", err)
		}
		return err
	}
	if vReadLen != len(byData) {
		return errors.New("not read all data")
	}
	return nil
}

