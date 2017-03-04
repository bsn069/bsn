package utils

import "testing"
import "fmt"

func Test_LookPath(t *testing.T) {
	strPath, err := LookPath("go")
	fmt.Println(strPath, err)
}
