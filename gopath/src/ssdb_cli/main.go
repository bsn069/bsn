package main

import (
	"flag"
	"fmt"
	"utils"

	"github.com/ssdb/gossdb/ssdb"
)

var strIp string
var iPort int

var db *ssdb.Client

func main() {
	flag.Parse()

	utils.InputStart(t)

	ip := "127.0.0.1"
	port := 10010
	db, err := ssdb.Connect(ip, port)
	if err != nil {
		fmt.Println(err)
		return
	}
	defer db.Close()

	a := make(chan bool, 0)
	<-a
}

func init() {
	flag.StringVar(&strIp, "ip", "127.0.0.1", "ip地址")
	flag.IntVar(&iPort, "port", 10010, "端口")
}

func t(strLine string) {
	fmt.Println(strLine)
}
