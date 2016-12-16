package routers

import (
	"u3d_update/controllers"

	"github.com/astaxie/beego"
)

func init() {
	beego.Router("/", &controllers.MainController{})

	u3d := new(controllers.U3DController)
	beego.Router("/u3d3/ver/:platform", u3d, "get:GetVer")
}
