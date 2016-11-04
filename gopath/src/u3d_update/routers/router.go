package routers

import (
	"github.com/astaxie/beego"
	"u3d_update/controllers"
)

func init() {
	beego.Router("/", &controllers.MainController{})
	beego.Router("/u3d", &controllers.U3DController{})
}
