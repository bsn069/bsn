#! /bin/bash


if [ ! -d "nogit" ]; then
	mkdir nogit
fi

pushd nogit
	if [ ! -d "tolua" ]; then
		echo clone tolua from https://github.com/topameng/tolua.git
		git clone https://github.com/topameng/tolua.git
		cp -r nogit/tolua u3d/Assets/Bsn/ThirdPart/tolua 
	fi
popd

pushd u3d/Assets/Bsn/ThirdPart/tolua
	rm -rf Luajit 
	rm -rf ProjectSettings 
	rm -rf Unity5.x 
	rm -rf Assets/Editor
	rm -f Assets/Editor.meta 
	rm -rf Assets/Lua
	rm -f Assets/Lua.meta 
	rm -f Assets/Source/LuaConst.*
	rm -rf Assets/ToLua/Examples
	rm -f Assets/ToLua/Examples.meta
	rm -f Assets/ToLua/Editor/ToLuaExport.*
	rm -f Assets/ToLua/Editor/ToLuaMenu.*
popd


