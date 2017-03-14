package utils

import (
	"testing"
)

func Test_PathLook(t *testing.T) {
	strGoExePath, _ := PathLook("go")
	strGoBinPath := PathJoin(PathGoRoot(), "bin")
	strGoExePath = PathDir(strGoExePath)
	if strGoExePath != strGoBinPath {
		t.Fatal()
	}
}

func Test_PathPwd(t *testing.T) {
	strGoPath := PathGoPath()
	strCurPath := PathJoin(strGoPath, "src/utils")
	if PathPwd() != strCurPath {
		t.Fatal()
	}
}
