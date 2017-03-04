@echo off

pushd src
	echo download github.com/golang/protobuf/protoc-gen-go
	if not exist github.com/golang/protobuf/protoc-gen-go (
		go get github.com/golang/protobuf/protoc-gen-go
	)

	echo download golang.org/x/crypto
	if not exist github.com/golang/crypto (
		go get github.com/golang/crypto
	)
	if not exist golang.org/x/crypto (
		ln -s %cd%/github.com/golang/crypto %cd%/golang.org/x/crypto
	)

	echo download golang.org/x/net
	if not exist github.com/golang/net (
		go get github.com/golang/net
	)
	if not exist golang.org/x/net (
		ln -s %cd%/github.com/golang/net %cd%/golang.org/x/net
	)

	echo download github.com/xtaci/kcp-go
	if not exist github.com/xtaci/kcp-go (
		go get github.com/xtaci/kcp-go
	)
popd

echo install protoc-gen-go
if not exist bin\protoc-gen-go.exe (
	pushd src\github.com\golang\protobuf\protoc-gen-go
		go install
	popd
)

pause

