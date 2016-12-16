package main

import (
    // "game/client"
    "game/gate"
    "bufio"
    "os"
    "fmt"
)

func main()  {
    var vGate gate.SGlobal
    vGate.Start()

    // var vClient client.SGlobal
    // vClient.Run()


    r := bufio.NewReader(os.Stdin)
	b, _, _ := r.ReadLine()
	line := string(b)
    fmt.Println(line)

    vGate.Stop()
}