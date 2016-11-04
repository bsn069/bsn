package routers

import (
	"github.com/astaxie/beego"
	"u3d_update/controllers"
)

func init() {
	beego.Router("/", &controllers.MainController{})
	beego.Router("/u3d/ver/:platform", &controllers.U3DController{}, "get:GetVer")
}
