using UnityEngine;

public static class LuaConst
{
    //lua逻辑代码目录
    public static string luaDir = null;    
    //tolua lua文件目录        
    public static string toluaDir = null;  
    public static string osDir = null;
    //手机运行时lua文件下载目录   
    public static string luaResDir = null;      
    public static string zbsDir = null;

    public static bool openLuaSocket = true;            //是否打开Lua Socket库
    public static bool openZbsDebugger = false;         //是否连接ZeroBraneStudio调试
}