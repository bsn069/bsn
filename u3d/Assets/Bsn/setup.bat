git clone https://github.com/topameng/tolua.git

xcopy tolua\Assets\Plugins Assets\Plugins /S /E /Y
xcopy tolua\Assets Assets\Resources\ToLua /S /E /Y
rmdir Assets\Resources\ToLua\Source /S /Q
rmdir Assets\Resources\ToLua\Editor /S /Q