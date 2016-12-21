package main

import (
	// "game/client"
	"bufio"
	"fmt"
	"game/gate"
	"os"
)

func main() {
	var vGate gate.SGlobal
	vGate.Run()
	defer vGate.Cmd("stop")

	r := bufio.NewReader(os.Stdin)
	b, _, _ := r.ReadLine()
	line := string(b)
	fmt.Println(line)
}
