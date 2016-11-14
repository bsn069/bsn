@echo off

pushd nogit
if exist tolua (
	echo tolua had found
) else (
	echo clone tolua from https://github.com/topameng/tolua.git
	git clone https://github.com/topameng/tolua.git
)
popd

xcopy nogit\tolua u3d\Assets\Bsn\ThirdPart\tolua /E /Y

pushd u3d\Assets\Bsn\ThirdPart\tolua
	echo clear %cd%
	if exist Luajit (
		echo remove %cd%\LuaJit  
		rmdir Luajit /S /Q
	) else (
		echo had remove %cd%\LuaJit 
	)

	if exist ProjectSettings (
		echo remove %cd%\ProjectSettings
		rmdir ProjectSettings /S /Q
	) else (
		echo had remove %cd%\ProjectSettings
	)

	if exist Unity5.x (
		echo remove %cd%\Unity5.x
		rmdir Unity5.x /S /Q
	) else (
		echo had remove %cd%\Unity5.x
	)

	pushd Assets
		if exist Editor (
			echo remove %cd%\Editor
			rmdir Editor /S /Q
			del Editor.meta /Q
		) else (
			echo had remove %cd%\Editor
		)

		if exist Lua (
			echo remove %cd%\Lua
			rmdir Lua /S /Q
			del Lua.meta /Q
		) else (
			echo had remove %cd%\Lua
		)

		pushd Source
			if exist LuaConst.* (
				echo remove %cd%\LuaConst.*
				del LuaConst.* /Q
			) else (
				echo had remove %cd%\LuaConst.*
			)
		popd

		pushd ToLua
			if exist Examples (
				echo remove %cd%\Examples
				rmdir Examples /S /Q
				del Examples.meta /Q
			) else (
				echo had remove %cd%\Examples
			)

			pushd Editor
				if exist ToLuaExport.* (
					echo remove %cd%\ToLuaExport.*
					del ToLuaExport.* /Q
				) else (
					echo had remove %cd%\ToLuaExport.*
				)

				if exist ToLuaMenu.* (
					echo remove %cd%\ToLuaMenu.*
					del ToLuaMenu.* /Q
				) else (
					echo had remove %cd%\ToLuaMenu.*
				)
			popd
		popd
	popd 

popd

rem GOBIN=E:\github\bsn\gopath\bin
rem GOPATH=E:\github\bsn\gopath
rem GOROOT=D:\Software\Go17
rem 
rem go get github.com/astaxie/beego