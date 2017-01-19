@echo off

echo download go protobuf
if not exist src\github.com\golang\protobuf\protoc-gen-go (
	go get github.com\golang\protobuf\protoc-gen-go
)

echo setup go protobuf
if not exist bin\protoc-gen-go.exe (
	pushd src\github.com\golang\protobuf\protoc-gen-go
	go build
	go install
	popd

	pushd src\github.com\golang\protobuf\protoc-gen-go
	go build
	go install
	popd
)

pause

