package utils

import (
	"os"
	"os/exec"
	"path/filepath"
)

func PathLook(strFileName string) (string, error) {
	return exec.LookPath(strFileName)
}

func PathPwd() string {
	strDir, _ := os.Getwd()
	return strDir
}

func PathFormat(strPath string) string {
	return filepath.FromSlash(strPath)
}

func PathJoin(strName ...string) string {
	return filepath.Join(strName...)
}

func PathGoPath() string {
	return Env("GOPATH")
}

func PathGoRoot() string {
	return Env("GOROOT")
}

func PathDir(strPath string) string  {
	return filepath.Dir(strPath)
}