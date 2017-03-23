/*
func Test_Input(t *testing.T) {
	count := 3
	for index := 0; index < count; index++ {
		time.Sleep(time.Duration(5 * time.Second))
		strLines := ReadLines()
		for strLine := range strLines {
			fmt.Println(strLine)
		}
	}
}
*/
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
	"fmt"
)

type sInput struct {
	m_strLines [][]string
	m_u8Write  uint8
	m_u8Read   uint8
	m_Mutex    sync.Mutex
	m_readFunc func(string)
}

var g_input *sInput
var g_inputMutex sync.Mutex

func InputStart(readFunc func(string)) {
	if g_input != nil {
		return
	}

	g_inputMutex.Lock()
	defer g_inputMutex.Unlock()
	if g_input != nil {
		return
	}

	g_input = &sInput{
		m_readFunc: readFunc,
		m_strLines: make([][]string, 2),
		m_u8Write:  0,
		m_u8Read:   1,
	}
	go g_input.inputThread()
}

func ReadLines() []string {
	if g_input == nil {
		return nil
	}
	return g_input.readLines()
}

func (this *sInput) inputThread() {
	for {
		r := bufio.NewReader(os.Stdin)
		strLine, _, _ := r.ReadLine()
		this.writeLines(string(strLine))
	}
}

func (this *sInput) writeLines(strLine string) {
	this.m_Mutex.Lock()
	defer this.m_Mutex.Unlock()

	if this.m_readFunc != nil {
		this.m_readFunc(strLine)
	} else {
		this.m_strLines[this.m_u8Write] = append(this.m_strLines[this.m_u8Write], strLine)
	}
}

func (this *sInput) readLines() []string {
	this.m_Mutex.Lock()
	defer this.m_Mutex.Unlock()

	this.m_u8Write, this.m_u8Read = this.m_u8Read, this.m_u8Write
	fmt.Println(len(this.m_strLines[this.m_u8Write]))
	this.m_strLines[this.m_u8Write] = this.m_strLines[this.m_u8Write][0:0]
	fmt.Println(len(this.m_strLines[this.m_u8Write]))
	return this.m_strLines[this.m_u8Read]
}
