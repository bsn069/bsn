package utils

import (
	"os/exec"
)

func LookPath(strFileName string) (string, error) {
	return exec.LookPath(strFileName)
}
