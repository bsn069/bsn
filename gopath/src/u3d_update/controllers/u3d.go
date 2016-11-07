package controllers

import (
	"github.com/astaxie/beego"
	"u3d_update/models"
)

type U3DController struct {
	beego.Controller
	model models.U3D
}

func (c *U3DController) Get() {
	c.Data["Website"] = "beego.me"
	c.Data["Email"] = "u3d@gmail.com"
	c.TplName = "index.tpl"
}

func (c *U3DController) GetVer() {
	// var strPlatform = c.Ctx.Input.Param(":platform")
	c.Ctx.WriteString(c.model.GetVer())

}
