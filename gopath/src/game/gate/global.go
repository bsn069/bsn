package gate


import (
	"fmt"
)

type SGlobal struct {
    M_SClientMgr SClientMgr
    m_chanStringCmd chan string
    m_chanWaitCmdComplete chan bool
    m_bHadStop bool
}

func (this *SGlobal) doCmd(strCmd string) {
    switch strCmd {
    case "start":
        this.start()
    case "stop":
        this.stop()
    }
}

func (this *SGlobal) Run() {
    this.m_bHadStop = false
    this.m_chanStringCmd = make(chan string, 0)
    this.m_chanWaitCmdComplete = make(chan bool, 0)

    go this.mainWorker()
    this.Cmd("start")
}

func (this *SGlobal) Cmd(strCmd string) {
    fmt.Println("Cmd", strCmd)

    if this.m_bHadStop {
        fmt.Println("had stop")
        return
    }

    this.m_chanStringCmd<-strCmd
    <-this.m_chanWaitCmdComplete
}

func (this *SGlobal) mainWorker()  {
    for !this.m_bHadStop {
        strCmd := <-this.m_chanStringCmd
        this.doCmd(strCmd)
        this.m_chanWaitCmdComplete<-true
    }
}

func (this *SGlobal) start() {
    fmt.Println("start gate")
    this.clientMgr().start()
}

func (this *SGlobal) stop() {
    fmt.Println("stop gate")
    this.clientMgr().stop()
    this.m_bHadStop = true
    fmt.Println("stop gate end")
}

func (this *SGlobal) clientMgr() *SClientMgr  {
    return &this.M_SClientMgr
}
