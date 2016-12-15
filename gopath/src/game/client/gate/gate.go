package gate

import (
	"net"
	"fmt"
	"errors"
)

type SGate struct {
    M_strAddr string
    M_Conn net.Conn
	M_u8InitStep uint8
}

func (this *SGate) Conn() net.Conn {
    return this.M_Conn
}


func (this *SGate) Addr() string {
	return this.M_strAddr
}

func (this *SGate) SetAddr(strAddr string) error {
	this.M_strAddr = strAddr
	return nil
}

func (this *SGate) Init() error  {
	if this.M_u8InitStep != 0 {
		return errors.New("had init")
	}

	this.M_u8InitStep++
	fmt.Println("init ok")

	return nil
}

func (this *SGate) Uninit()   {
	if this.M_u8InitStep == 0 {
		return 
	}

	if this.M_u8InitStep == 1 {
		this.M_u8InitStep--
		fmt.Println("uninit ok")
	}
}

func (this *SGate) Send(byData []byte) error {
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

func (this *SGate) Recv(byData []byte) error {
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


func (this *SGate) Connect() (err error) {
	if "" == this.Addr() {
		return errors.New("no addr")
	}

	if this.Conn() != nil {
		return errors.New("had connect")
	}

	vConn, err := net.Dial("tcp", this.Addr())
	if err != nil {
		return err
	}
	this.M_Conn = vConn

	return nil
}
