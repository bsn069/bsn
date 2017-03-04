package utils

import "testing"
import "fmt"

func Test_PushPopU8(t *testing.T) {
	var byBuf []byte
	var byTemp []byte
	byBuf = make([]byte, 10)

	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PushU8(byTemp, uint8(i))
	}
	fmt.Println(byBuf)

	var u8Temp uint8
	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PopU8(byTemp, &u8Temp)
		if u8Temp != uint8(i) {
			t.Fatal()
		}
	}
}

func Test_PushPopU16(t *testing.T) {
	var byBuf []byte
	var byTemp []byte
	byBuf = make([]byte, 10*2)

	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PushU16(byTemp, uint16(i))
		if byTemp == nil {
			break
		}
	}
	fmt.Println(byBuf)

	var u16Temp uint16
	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PopU16(byTemp, &u16Temp)
		if byTemp == nil {
			break
		}
		if u16Temp != uint16(i) {
			t.Fatal()
		}
	}
}

func Test_PushPopU32(t *testing.T) {
	var byBuf []byte
	var byTemp []byte
	byBuf = make([]byte, 10*4)

	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PushU32(byTemp, uint32(i))
		if byTemp == nil {
			break
		}
	}
	fmt.Println(byBuf)

	var u32Temp uint32
	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PopU32(byTemp, &u32Temp)
		if byTemp == nil {
			break
		}
		if u32Temp != uint32(i) {
			t.Fatal()
		}
	}
}

func Test_PushPopU64(t *testing.T) {
	var byBuf []byte
	var byTemp []byte
	byBuf = make([]byte, 10*8)

	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PushU64(byTemp, uint64(i))
		if byTemp == nil {
			break
		}
	}
	fmt.Println(byBuf)

	var u64Temp uint64
	byTemp = byBuf
	for i := 0; i < len(byBuf); i++ {
		byTemp = PopU64(byTemp, &u64Temp)
		if byTemp == nil {
			break
		}
		if u64Temp != uint64(i) {
			t.Fatal()
		}
	}
}

func Test_PushPopU16String(t *testing.T) {
	var byBuf []byte
	var byTemp []byte
	var strValue string
	var strTemp string
	byBuf = make([]byte, 30)

	strTemp = string("我abc+23")
	fmt.Println(strTemp)
	byTemp = PushU16String(byBuf, strTemp)
	if byTemp == nil {
		t.Fatal()
	}
	byTemp = PopU16String(byBuf, &strValue)
	if byTemp != nil && strValue != strTemp {
		t.Fatal()
	}
	fmt.Println(strValue)

	strTemp = string("11111")
	fmt.Println(strTemp)
	byTemp = PushU16String(byBuf, strTemp)
	if byTemp == nil {
		t.Fatal()
	}

	strTemp = string("22222")
	fmt.Println(strTemp)
	byTemp = PushU16String(byTemp, strTemp)
	if byTemp == nil {
		t.Fatal()
	}
	s
	byTemp = PopU16String(byBuf, &strValue)
	fmt.Println(strValue)
	byTemp = PopU16String(byTemp, &strValue)
	fmt.Println(strValue)
}
