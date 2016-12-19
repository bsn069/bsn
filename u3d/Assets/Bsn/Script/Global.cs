using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {

    [Reg2LuaAttribute]
    public static class Global {
        public static LuaState          ms_luaState  = null;
        public static GameObject        ms_goMain    = null;
        public static NBsn.Main         ms_Main      = null;
        public static NBsn.LuaLooper    ms_luaLooper = null;
        // 资源本地根目录
        public static string            ms_strResLocalPath = null;

        #region init
        public static void InitConfig() {
            Debug.LogFormat("NBsn.Global InitConfig"); 

            Debug.LogFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            Debug.LogFormat("Application.dataPath={0}", Application.dataPath);
            Debug.LogFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            Debug.LogFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);
            Debug.LogFormat("LuaConst.osDir={0}", LuaConst.osDir);

#if UNITY_EDITOR
            if (!Config.ms_bUseServerRes) {
                ms_strResLocalPath = Application.dataPath + "/";
                LuaConst.luaDir = ms_strResLocalPath + "Lua";
                LuaConst.toluaDir = ms_strResLocalPath + "Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
            }
#else
            Config.ms_bUseServerRes = true;
#endif
            if (Config.ms_bUseServerRes) {
                Config.ms_strServerResUrl += LuaConst.osDir + "/";
                ms_strResLocalPath = Application.persistentDataPath + "/" + Config.ms_strServerResLocalDirName + "/";
                LuaConst.luaDir = ms_strResLocalPath + "Lua";
                LuaConst.toluaDir = ms_strResLocalPath + "ToLua"; 
            }

            Debug.LogFormat("Config.ms_bUseServerRes={0}", Config.ms_bUseServerRes); 
            Debug.LogFormat("Config.ms_strServerResUrl={0}", Config.ms_strServerResUrl);
            Debug.LogFormat("Global.ms_strResLocalPath={0}", Global.ms_strResLocalPath); 
            Debug.LogFormat("LuaConst.luaDir={0}", LuaConst.luaDir); 
            Debug.LogFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir); 
        }

        public static string GetResLocalPath(string strFilePath) {
            return Global.ms_strResLocalPath + strFilePath;
        }

        public static void Init(GameObject goMain, NBsn.Main Main) {
            Debug.LogFormat("NBsn.Global Init goMain={0}", goMain); 
            Global.ms_goMain    = goMain;
            Global.ms_Main      = Main;

            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = Config.ms_nFPS;

            Global.UpdateRes();
        }

        public static void Uninit() {
            Debug.Log("NBsn.Global Uninit"); 
 
            Global.ms_goMain    = null;
            Global.ms_Main      = null;

            Global.UninitLua();
        }
        #endregion

        public static void OnApplicationQuit() {
            Debug.Log("NBsn.Global OnApplicationQuit"); 
        }

        #region
        public static void UpdateRes() {
            Debug.Log("NBsn.Global UpdateRes"); 
            var updateRes = new CUpdateRes();
            updateRes.Start();
        }

        public static void UpdateResSuccess() {
            Debug.Log("NBsn.Global UpdateResSuccess"); 
            Global.InitLua();
        }

        public static void UpdateResFail() {
            Debug.Log("NBsn.Global UpdateResFail"); 
            Application.Quit();
        }
        #endregion

        #region lua
        public static void InitLua() {
            Debug.Log("NBsn.Global InitLua"); 
            var luaReadFile = new LuaReadFile();
            Global.ms_luaState  = new LuaState();
            luaReadFile.ClearSearchPath();
            Global.ms_luaState.AddSearchPath(LuaConst.toluaDir);
            luaReadFile.ShowAll();
 
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_pb);      
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_lpeg);
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_bit);
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_socket_core);
 
            Global.ms_luaState.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_cjson);
            Global.ms_luaState.LuaSetField(-2, "cjson");
 
            Global.ms_luaState.OpenLibs(LuaDLL.luaopen_cjson_safe);
            Global.ms_luaState.LuaSetField(-2, "cjson.safe");
    
            Global.ms_luaState.LuaSetTop(0);
            LuaBinder.Bind(Global.ms_luaState);
            LuaCoroutine.Register(Global.ms_luaState, Global.ms_Main);
  
            Global.ms_luaState.Start();
   
            luaReadFile.ClearSearchPath();
            Global.ms_luaState.AddSearchPath(LuaConst.luaDir);
            luaReadFile.ShowAll();
            Global.ms_luaState.DoFile("Main");
            LuaFunction main = ms_luaState.GetFunction("Main");
            main.Call();
            main.Dispose();
            main = null;   
 
            Global.ms_luaLooper = Global.ms_goMain.AddComponent<NBsn.LuaLooper>();
        }

        public static void UninitLua() {
            Debug.Log("NBsn.Global UninitLua"); 
            if (Global.ms_luaLooper != null) {
                Global.ms_luaLooper.Dispose();
                Global.ms_luaLooper = null;
            }
 
            if (Global.ms_luaState != null) {
                Global.ms_luaState.Dispose();
                Global.ms_luaState = null;  
            }
        }

        public static void ThrowException() {
            Debug.Log("NBsn.Global ThrowException"); 
            string error = ms_luaState.LuaToString(-1);
            Global.ms_luaState.LuaPop(2);                
            throw new LuaException(error, LuaException.GetLastError());
        }
        #endregion

        #region
        public static WWW NewServerResWWW(string pathName) {
            string strUrl = Config.ms_strServerResUrl + pathName;
            Debug.LogFormat("NBsn.Global NewServerResWWW strUrl={0}", strUrl); 
            return new WWW(strUrl);
        }
        #endregion
    }
}