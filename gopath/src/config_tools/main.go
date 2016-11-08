/*
go run main.go -local F:\github\bsn\config_tools\xsj_tsj.txt -sync F:\github\bsn\config_tools\sync.txt
*/
package main

import (
	"encoding/csv"
	"flag"
	"fmt"
	"io"
	"os"
	// "path"
	"path/filepath"
	"strconv"
	"strings"
)

var strLocalConfig string
var strSyncConfig string

type sFullPath2Ver struct {
	strFullPath string
	u32Ver      uint32
}

type sSync struct {
	u32Id           uint32
	strFromFullPath string
	strToFullPath   string
	u32Ver          uint32
}

func init() {
	flag.StringVar(&strLocalConfig, "local", "", "local config full path")
	flag.StringVar(&strSyncConfig, "sync", "", "sync config full path")
}

func main() {
	flag.Parse()
	if strLocalConfig == "" || strSyncConfig == "" {
		flag.Usage()
		return
	}

	fmt.Println("strLocalConfig", strLocalConfig)
	fmt.Println("strSyncConfig", strSyncConfig)

	localData := make(map[uint32]sFullPath2Ver, 0)
	if !loadConfig(strLocalConfig, localData) {
		fmt.Println(strLocalConfig, "load fail")
		return
	}
	// for k, v := range localData {
	// 	fmt.Println(k, v.strFullPath, v.u32Ver)
	// }

	syncData := make(map[uint32]sFullPath2Ver, 0)
	if !loadConfig(strSyncConfig, syncData) {
		fmt.Println(strSyncConfig, "load fail")
		return
	}
	// for k, v := range syncData {
	// 	fmt.Println(k, v.strFullPath, v.u32Ver)
	// }

	fmt.Println("syncResult")
	syncResult := needUpdataConfig(localData, syncData)
	if len(syncResult) == 0 {
		return
	}

	for k, v := range syncResult {
		fmt.Println(k, v.u32Id, v.strFromFullPath, v.strToFullPath, v.u32Ver)
		if !doSync(v) {
			continue
		}

		data, _ := localData[v.u32Id]
		data.u32Ver = v.u32Ver
		localData[v.u32Id] = data

		data, _ = syncData[v.u32Id]
		data.u32Ver = v.u32Ver
		syncData[v.u32Id] = data
	}

	//writeConfig(localData, strLocalConfig)
	//writeConfig(syncData, strSyncConfig)
}

func doSync(data sSync) bool {
	dir := filepath.Dir(data.strToFullPath)
	os.MkdirAll(dir, os.ModePerm)
	CopyFile(data.strToFullPath, data.strFromFullPath)
	return true
}

func CopyFile(dstName, srcName string) (written int64, err error) {
	src, err := os.Open(srcName)
	if err != nil {
		fmt.Println(err)
		return
	}
	defer src.Close()
	dst, err := os.Create(dstName)
	if err != nil {
		fmt.Println(err)
		return
	}
	defer dst.Close()
	return io.Copy(dst, src)
}

func writeConfig(data map[uint32]sFullPath2Ver, strFullPath string) {
	file, err := os.Create(strFullPath)
	if err != nil {
		fmt.Println("Error:", err)
		return
	}
	defer file.Close()

	write := csv.NewWriter(file)
	err = write.Write([]string{"uId", "strFullPath", "uVer"})
	if err != nil {
		fmt.Println("Error:", err)
		return
	}
	for k, v := range data {
		err = write.Write([]string{strconv.FormatUint(uint64(k), 10), v.strFullPath, strconv.FormatUint(uint64(v.u32Ver), 10)})
		if err != nil {
			fmt.Println("Error:", err)
			return
		}
	}
	write.Flush()
	fmt.Println("ok")
}

func needUpdataConfig(local map[uint32]sFullPath2Ver, sync map[uint32]sFullPath2Ver) []sSync {
	syncResult := make([]sSync, 0)
	for lk, lv := range local {
		// fmt.Println(lk, lv)
		sv, ok := sync[lk]
		if ok && lv.u32Ver != sv.u32Ver {
			a := sSync{
				u32Id: lk,
			}
			if lv.u32Ver > sv.u32Ver {
				a.u32Ver = lv.u32Ver
				a.strFromFullPath = lv.strFullPath
				a.strToFullPath = sv.strFullPath
			} else {
				a.u32Ver = sv.u32Ver
				a.strFromFullPath = sv.strFullPath
				a.strToFullPath = lv.strFullPath
			}
			syncResult = append(syncResult, a)
		}
	}
	// for k, v := range syncResult {
	// 	fmt.Println(k, v.u32Id, v.strFromFullPath, v.strToFullPath, v.u32Ver)
	// }
	return syncResult
}

func loadConfig(strFilePath string, data map[uint32]sFullPath2Ver) bool {
	file, err := os.Open(strFilePath)
	if err != nil {
		fmt.Println("Error:", err)
		return false
	}
	defer file.Close()

	reader := csv.NewReader(file)
	reader.Read()
	for {
		record, err := reader.Read()
		if err == io.EOF {
			break
		} else if err != nil {
			fmt.Println("Error:", err)
			return false
		}
		// fmt.Println(record) // record has the type []string

		if len(record) != 3 {
			fmt.Println("record != 3")
			return false
		}

		id, err := strconv.ParseUint(record[0], 10, 32)
		if err != nil {
			fmt.Println("Error:", err)
			return false
		}

		ver, err := strconv.ParseUint(record[2], 10, 32)
		if err != nil {
			fmt.Println("Error:", err)
			return false
		}

		data[uint32(id)] = sFullPath2Ver{
			strFullPath: record[1],
			u32Ver:      uint32(ver),
		}
	}

	return true
}
