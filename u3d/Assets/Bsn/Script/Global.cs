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
        public static NBsn.UIMgr        ms_UIMgr = new NBsn.UIMgr();
        public static NBsn.CUpdateRes   ms_CUpdateRes = null;
        public static NBsn.CResMgr      ms_CResMgr = new NBsn.CResMgr();
        
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


        #region coroutine
        public static Coroutine StartCoroutine(IEnumerator iEnumerator) {
            if (Global.ms_Main == null) {
                Debug.LogErrorFormat("NBsn.Global.ms_Main == null"); 
                return null;
            }
            return Global.ms_Main.StartCoroutine(iEnumerator);
        }

        public static void StopCoroutine(Coroutine coroutine) {
            if (Global.ms_Main == null) {
                Debug.LogErrorFormat("NBsn.Global.ms_Main == null"); 
                return;
            }
            Global.ms_Main.StopCoroutine(coroutine);
        }
        #endregion

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
            
#if !UNITY_EDITOR
            Config.ms_eResLoadType = NBsn.EResLoadType.AppAB;
#endif
            Debug.LogFormat("Config.ms_eResLoadType={0}", Config.ms_eResLoadType);

            if (Config.ms_eResLoadType != NBsn.EResLoadType.AppAB) {
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

        public static void Init(GameObject goMain, NBsn.Main Main) {
            Debug.LogFormat("NBsn.Global Init goMain={0}", goMain); 
            
            Global.ms_goMain    = goMain;
            Global.ms_Main      = Main;
            Global.ms_UIMgr.Init(goMain.transform.FindChild("UI"));

            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = Config.ms_nFPS;

            ms_UIMgr.NewUI("UIUpdate");
            Global.ms_CUpdateRes = new NBsn.CUpdateRes();
            Global.ms_CUpdateRes.Start();
        }

        public static void Uninit() {
            Debug.Log("NBsn.Global Uninit"); 
 
            Global.ms_CUpdateRes = null;
            Global.ms_UIMgr.Uninit();
            Global.ms_Main      = null;
            Global.ms_goMain    = null;

            Global.UninitLua();
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
                Global.ms_luaLooper = null;
            }
 
            if (Global.ms_luaState != null) {
                Global.ms_luaState.Dispose();
                Global.ms_luaState = null;  
            }
        }
        #endregion
    }
}