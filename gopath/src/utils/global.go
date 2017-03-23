package utils

import (
	"fmt"
	"sync"
)

type SCmd struct {
	m_chanStringCmd       chan string
	m_chanWaitCmdComplete chan bool
	m_bHadStop            bool
	m_funcDoCmd           func(string)
	m_mutex               sync.Mutex
}

func NewSCmd(funcDoCmd func(string)) *SCmd {
	if funcDoCmd == nil {
		return nil
	}

	var pSCmd = &SCmd{
		m_bHadStop:            false,
		m_chanStringCmd:       make(chan string, 0),
		m_chanWaitCmdComplete: make(chan bool, 0),
		m_funcDoCmd:           funcDoCmd,
	}
	go pSCmd.mainWorker()
	return pSCmd
}

func (this *SCmd) Cmd(strCmd string) {
	fmt.Println("Cmd", strCmd)

	if this.m_bHadStop {
		fmt.Println("had stop")
		return
	}

	this.m_chanStringCmd <- strCmd
}

func (this *SCmd) Quit() {
	close(this.m_chanStringCmd)
}

func (this *SCmd) mainWorker() {
	for strCmd := range this.m_chanStringCmd {
		this.m_funcDoCmd(strCmd)
	}
}
