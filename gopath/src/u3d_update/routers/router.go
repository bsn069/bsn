package routers

import (
	"github.com/astaxie/beego"
	"u3d_update/controllers"
)

func init() {
	beego.Router("/", &controllers.MainController{})

	u3d := new(controllers.U3DController)
	beego.Router("/u3d/ver/:platform", u3d, "get:GetVer")
}
