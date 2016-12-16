package models

import (
	// "database/sql"
	// "fmt"
	// "github.com/astaxie/beego/orm"
	_ "github.com/go-sql-driver/mysql"
)

// var db *sql.DB

type User struct {
	Id int `orm:"auto"`

	Name string

	Profile_id int
}

func init() {
	// orm.Debug = true
	// orm.RegisterModel(new(User))
	// orm.RunSyncdb("default", false, true)
	// orm.RegisterDriver("mysql", orm.DR_MySQL)
	// orm.RegisterDataBase("default", "mysql", "root:jsm3d@10.20.110.37:3306/group27")
	// // var err error
	// db, err = sql.Open("mysql", "root:jsm3d@tcp(10.20.110.37:3306)/group27")
	// if err != nil {
	// 	fmt.Sprintln(err)
	// 	return
	// }

	// _, err = db.Exec("CREATE TABLE u3dTest (value string)")
	// if err != nil {
	// 	fmt.Sprintln(err)
	// }
}

type U3D struct {
}

func (this *U3D) GetVer() string {
	// o := orm.NewOrm()
	// o.Using("default")
	return "a"
}
