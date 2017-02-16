package main

import (
	_ "u3d_update/routers"
	"github.com/astaxie/beego"
)
func main() {
	beego.SetStaticPath("/u3d_update", "./../")
	beego.BConfig.WebConfig.DirectoryIndex=true
	beego.Run()
}

