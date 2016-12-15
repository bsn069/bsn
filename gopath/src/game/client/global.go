package client


import (
	"fmt"
    "game/client/gate"
)

type SGlobal struct {
    M_SGate gate.SGate
}


func (this *SGlobal) Start() {
    fmt.Println("start client")
    go this.run()
}

func (this *SGlobal) Stop() {
    fmt.Println("stop client")
    this.uninitGate()
}

func (this *SGlobal) run()  {
    err := this.initGate()
    defer this.uninitGate()
    if err != nil {
        return
    }
}

func (this *SGlobal) gate() *gate.SGate  {
    return &this.M_SGate
}

func (this *SGlobal) initGate() error  {
    err := this.gate().Init()
    if err != nil {
        fmt.Println(err)
        return err
    }

    this.gate().SetAddr(":80")
    fmt.Println(this.gate().Addr())
    err = this.gate().Connect()
    if err != nil {
        fmt.Println(err)
        return err
    }
    return nil
}

func (this *SGlobal) uninitGate()   {
    this.gate().Uninit()
}