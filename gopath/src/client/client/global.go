package client


import (
	"fmt"
    "client/gate"
	"bufio"
	"os"
)

type SGlobal struct {
    M_SGate gate.SGate
}

func (this *SGlobal) Gate() *gate.SGate  {
    return &this.M_SGate
}

func (this *SGlobal) Run() {
    fmt.Println("this is client")

    err := this.initGate()
    if err != nil {
        return
    }
    defer this.uninitGate()
    fmt.Println("this is client")

    r := bufio.NewReader(os.Stdin)
	b, _, _ := r.ReadLine()
	line := string(b)
    fmt.Println(line)
    fmt.Println("this is client")
    
}

func (this *SGlobal) initGate() error  {
    err := this.Gate().Init()
    if err != nil {
        fmt.Println(err)
        return err
    }

    this.Gate().SetAddr(":80")
    fmt.Println(this.Gate().Addr())
    err = this.Gate().Connect()
    if err != nil {
        fmt.Println(err)
        return err
    }
    return nil
}

func (this *SGlobal) uninitGate()   {
    this.Gate().Uninit()
}