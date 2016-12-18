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
}

func (this *SClient) Id() uint16  {
    return this.M_u16Id
}

func (this *SClient) SetId(u16Id uint16)  {
    this.M_u16Id = u16Id
}

func (this *SClient) Conn() net.Conn {
    return this.M_Conn
}

func (this *SClient) SetConn(iConn net.Conn)  {
    this.M_u16ConnIndex++
    this.M_Conn = iConn
}

func (this *SClient) Send(byData []byte) error {
    vLen := len(byData)
	if vLen <= 0 {
		return nil
	}

	writeLen, err := this.Conn().Write(byData)
	if err != nil {
		return err
	}
	if writeLen != vLen {
		return errors.New("not write all data")
	}
	return nil
}

func (this *SClient) Recv(byData []byte) error {
	vReadLen := len(byData)

	vReadLen, err := this.Conn().Read(byData)
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

