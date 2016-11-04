package controllers

import (
	"github.com/astaxie/beego"
)

type U3DController struct {
	beego.Controller
}

func (c *U3DController) Get() {
	c.Data["Website"] = "beego.me"
	c.Data["Email"] = "u3d@gmail.com"
	c.TplName = "index.tpl"
}

func (c *U3DController) GetVer() {
	c.Data["Website"] = c.Ctx.Input.Param(":platform")
	c.Data["Email"] = "GetVer@gmail.com"
	c.TplName = "index.tpl"
}
