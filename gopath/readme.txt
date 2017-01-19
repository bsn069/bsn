
1.go protobuf
https://github.com/google/protobuf/releases
下载protoc-3.0.0-beta-1-win32.zip 解压到bsn_path/win (可以在cmd中调用protoc)
go get github.com/golang/protobuf/protoc-gen-go
cd github.com/golang/protobuf/protoc-gen-go
go build
go install
cd github.com/golang/protobuf/proto
go build
go install