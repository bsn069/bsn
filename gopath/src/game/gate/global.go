package gate


import (
	"fmt"
)

type SGlobal struct {
    M_SClientMgr SClientMgr
}

func (this *SGlobal) Start() {
    fmt.Println("start gate")

    this.clientMgr().init()
    this.clientMgr().setAddr(":50000")
    err := this.clientMgr().startListen()
    if err != nil {
        fmt.Println(err)
        return
    }

    go this.run()
}

func (this *SGlobal) Stop() {
    fmt.Println("stop gate")
    this.clientMgr().stopListen()
    fmt.Println("stop gate end")
}

func (this *SGlobal) run()  {
    fmt.Println("gate run")
}

func (this *SGlobal) clientMgr() *SClientMgr  {
    return &this.M_SClientMgr
}
