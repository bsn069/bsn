package utils

import (
	"bufio"
	"sync"

	// "log"
	"os"
	// "reflect"
	// "bytes"
	// "path"
	// "runtime"
)

type sInput struct {
	m_strLines [][]string
	m_u8Write  uint8
	m_u8Read   uint8
}

var g_input *sInput
var g_inputMutex sync.Mutex

func InputRun() {
	g_inputMutex.Lock()
	defer g_inputMutex.Unlock()

	if g_input != nil {
		return
	}
	g_input = &sInput{}
	g_input.init()
	g_input.run()
}

func InputLines() []string {
	g_inputMutex.Lock()
	defer g_inputMutex.Unlock()

	if g_input == nil {
		return nil
	}
	g_input.swapBuff()
	return g_input.m_strLines[g_input.m_u8Read]
}

func (this *sInput) init() {
	this.m_strLines = make([][]string, 2)
	this.m_u8Write = 0
	this.m_u8Read = 1
}

func (this *sInput) run() {
	go this.inputThread()
}

func (this *sInput) swapBuff() {
	this.m_u8Write, this.m_u8Read = this.m_u8Read, this.m_u8Write
}

func (this *sInput) inputThread() {
	for {
		strLine := this.inputReadLine()
		this.m_strLines[this.m_u8Write] = append(this.m_strLines[this.m_u8Write], strLine)
	}
}

func (this *sInput) inputReadLine() string {
	r := bufio.NewReader(os.Stdin)
	b, _, _ := r.ReadLine()
	return string(b)
}
