@echo off
pushd ..\nogit\ssdb-bin
    echo 127.0.0.1:8888
    ssdb-server-1.9.4.exe ./ssdb.conf
popd