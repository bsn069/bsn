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
        
        // 平台名
        public static string    ms_strPlatformName = null;
        // 资源根目录 本地全路径
        public static string    ms_strResLocalFullPath = null;
        // AB根目录 相对资源路径 
        public static string    ms_strPlatformABPath = null;
        // AB根目录 本地全路径
        public static string    ms_strABLocalFullPath = null;

        public static string    ms_strLuaLocalFullPath = null;
        public static string    ms_strToLuaLocalFullPath = null;

        public static bool      ms_bUpdateRes = true;


        #region init
        public static void InitConfig(string strPlatformName) {
            Debug.LogFormat("NBsn.Global InitConfig strPlatformName={0}", strPlatformName); 

            Debug.LogFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            Debug.LogFormat("Application.dataPath={0}", Application.dataPath);
            Debug.LogFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            Debug.LogFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);

            ms_strPlatformName = strPlatformName;
            Debug.LogFormat("ms_strPlatformName={0}", ms_strPlatformName); 

            ms_strPlatformABPath = string.Format(
                NBsn.Config.ms_strPlatformABPathFormat
                , ms_strPlatformName
                );
            Debug.LogFormat("NBsn.Config.ms_strPlatformABPathFormat={0}", NBsn.Config.ms_strPlatformABPathFormat); 
            Debug.LogFormat("ms_strPlatformABPath={0}", ms_strPlatformABPath); 
            
            var bUseLoaclRes = false;
            #if UNITY_EDITOR
                if (Config.ms_bUseLocalResInEditor) {
                    bUseLoaclRes = true;
                }
            #endif
            Debug.LogFormat("bUseLoaclRes={0}", bUseLoaclRes);
            if (bUseLoaclRes) {
                ms_bUpdateRes = false;
                ms_strResLocalFullPath = Application.dataPath + "/";
                ms_strABLocalFullPath = ms_strResLocalFullPath + ms_strPlatformABPath + "/";
                ms_strLuaLocalFullPath = ms_strResLocalFullPath + "Lua";
                ms_strToLuaLocalFullPath = ms_strResLocalFullPath + "Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
            }
            else {
                ms_strResLocalFullPath = Application.persistentDataPath + "/" + Config.ms_strServerResLocalDirName + "/";
                ms_strABLocalFullPath = ms_strResLocalFullPath + ms_strPlatformABPath + "/";
                ms_strLuaLocalFullPath = ms_strResLocalFullPath + "Lua";
                ms_strToLuaLocalFullPath = ms_strResLocalFullPath + "ToLua";  
            }

            Debug.LogFormat("ms_bUpdateRes={0}", ms_bUpdateRes);
            Debug.LogFormat("Config.ms_bUseLocalResInEditor={0}", Config.ms_bUseLocalResInEditor); 
            Debug.LogFormat("ms_strResLocalFullPath={0}", ms_strResLocalFullPath);
            Debug.LogFormat("ms_strABLocalFullPath={0}", ms_strABLocalFullPath);
            Debug.LogFormat("ms_strLuaLocalFullPath={0}", ms_strLuaLocalFullPath);
            Debug.LogFormat("ms_strToLuaLocalFullPath={0}", ms_strToLuaLocalFullPath);

            LuaConst.osDir = ms_strPlatformName;
            LuaConst.luaDir = ms_strLuaLocalFullPath;
            LuaConst.toluaDir = ms_strToLuaLocalFullPath;
            LuaConst.luaResDir = ms_strLuaLocalFullPath;
            Debug.LogFormat("LuaConst.osDir={0}", LuaConst.osDir);
            Debug.LogFormat("LuaConst.luaDir={0}", LuaConst.luaDir);
            Debug.LogFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir);
            Debug.LogFormat("LuaConst.luaResDir={0}", LuaConst.luaResDir);
        }

        // strFilePath "Lua/Main.lua"
        // return 
        public static string GetResLocalFullPath(string strPathName) {
            return ms_strResLocalFullPath + strPathName;
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