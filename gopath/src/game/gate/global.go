package gate


import (
	"fmt"
)

type SGlobal struct {
    M_SClientMgr SClientMgr
}

func (this *SGlobal) Start() {
    fmt.Println("start gate")

    this.clientMgr().SetAddr(":50000")
    err := this.clientMgr().Listen()
    if err != nil {
        fmt.Println(err)
        return
    }

    go this.run()
}

func (this *SGlobal) Stop() {
    fmt.Println("stop gate")
    this.clientMgr().StopListen()
}

func (this *SGlobal) run()  {
    fmt.Println("gate run")
}

func (this *SGlobal) clientMgr() *SClientMgr  {
    return &this.M_SClientMgr
}
