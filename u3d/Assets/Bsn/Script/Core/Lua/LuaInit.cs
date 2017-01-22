using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class CLuaInit {
        //public static void Init() {
        //    Debug.Log("NBsn.CGlobal InitLua"); 
        //    var luaReadFile = new LuaReadFile();
        //    CGlobal.ms_luaState  = new LuaState();
        //    luaReadFile.ClearSearchPath();
        //    CGlobal.ms_luaState.AddSearchPath(LuaConst.toluaDir);
        //    luaReadFile.ShowAll();
 
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_pb);      
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_lpeg);
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_bit);
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_socket_core);
 
        //    CGlobal.ms_luaState.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_cjson);
        //    CGlobal.ms_luaState.LuaSetField(-2, "cjson");
 
        //    CGlobal.ms_luaState.OpenLibs(LuaDLL.luaopen_cjson_safe);
        //    CGlobal.ms_luaState.LuaSetField(-2, "cjson.safe");
    
        //    CGlobal.ms_luaState.LuaSetTop(0);
        //    LuaBinder.Bind(CGlobal.ms_luaState);
        //    LuaCoroutine.Register(CGlobal.ms_luaState, CGlobal.ms_Main);
  
        //    CGlobal.ms_luaState.Start();
   
        //    luaReadFile.ClearSearchPath();
        //    CGlobal.ms_luaState.AddSearchPath(LuaConst.luaDir);
        //    luaReadFile.ShowAll();
        //    CGlobal.ms_luaState.DoFile("Main");
        //    LuaFunction main = CGlobal.ms_luaState.GetFunction("Main");
        //    main.Call();
        //    main.Dispose();
        //    main = null;   
 
        //    CGlobal.ms_luaLooper = CGlobal.ms_goMain.AddComponent<NBsn.LuaLooper>();
        //}

        //public static void UnInit() {
        //    Debug.Log("NBsn.CGlobal UninitLua"); 
        //    if (CGlobal.ms_luaLooper != null) {
        //        CGlobal.ms_luaLooper = null;
        //    }
 
        //    if (CGlobal.ms_luaState != null) {
        //        CGlobal.ms_luaState.Dispose();
        //        CGlobal.ms_luaState = null;  
        //    }
        //}
    }
}