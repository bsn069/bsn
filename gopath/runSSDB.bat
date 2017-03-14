@echo off
set ssdbbin=nogit\ssdb-bin\ssdb-server-1.9.4.exe

if not exist nogit\ssdb-bin (
    echo not found dir nogit\ssdb-bin 
    echo please run setup.bat
    exit
)

set id=10010
echo listen 127.0.0.1:%id%
mkdir ssdb\data\%id%\var
start %ssdbbin% .\ssdb\config\%id%.conf

set id=10011
echo listen 127.0.0.1:%id%
mkdir ssdb\data\%id%\var
start %ssdbbin% .\ssdb\config\%id%.conf

set id=10020
echo listen 127.0.0.1:%id%
mkdir ssdb\data\%id%\var
start %ssdbbin% .\ssdb\config\%id%.conf

set id=10021
echo listen 127.0.0.1:%id%
mkdir ssdb\data\%id%\var
start %ssdbbin% .\ssdb\config\%id%.conf
 