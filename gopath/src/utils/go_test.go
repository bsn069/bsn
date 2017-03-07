package utils

import "testing"

func Test_IsRootUser(t *testing.T) {
	if !IsRootUser() {
		t.Error()
	}
}

func Test_Env(t *testing.T) {

}
