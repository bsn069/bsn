using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {

    [Reg2LuaAttribute]
    public static class Global {
        public static LuaState          m_luaState  = null;
        public static GameObject        m_goMain    = null;
        public static NBsn.Main         m_Main      = null;
        public static NBsn.LuaLooper    m_luaLooper = null;
        public static string            ms_appPath  = null;

        #region init
        public static void InitConfig() {
            Debug.LogFormat("NBsn.Global InitConfig"); 

            Debug.LogFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            Debug.LogFormat("Application.dataPath={0}", Application.dataPath);
            Debug.LogFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            Debug.LogFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);
            Debug.LogFormat("Config.ms_bEditorMode={0}", Config.ms_bEditorMode); 

            string path = Application.persistentDataPath;
            if (Config.ms_bEditorMode) {
                LuaConst.luaDir = string.Format("{0}/Lua", Application.dataPath);
                LuaConst.toluaDir = Application.dataPath + "/Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
            }
            else {
                Global.ms_appPath = string.Format("{0}/{1}", Application.persistentDataPath, Config.ms_appName);
                LuaConst.luaDir = string.Format("{0}/Lua", Global.ms_appPath);
                LuaConst.toluaDir = string.Format("{0}/ToLua", Global.ms_appPath);
            }
            Debug.LogFormat("Global.ms_appPath={0}", Global.ms_appPath); 
            Debug.LogFormat("LuaConst.luaDir={0}", LuaConst.luaDir); 
            Debug.LogFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir); 
        }

        public static void Init(GameObject goMain, NBsn.Main Main) {
            Debug.LogFormat("NBsn.Global Init goMain={0}", goMain); 
            Global.m_goMain    = goMain;
            Global.m_Main      = Main;

            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = Config.ms_nFPS;

            Global.UpdateRes();
        }

        public static void Uninit() {
            Debug.Log("NBsn.Global Uninit"); 
 
            Global.m_goMain    = null;
            Global.m_Main      = null;

            Global.UninitLua();
        }
        #endregion

        public static void OnApplicationQuit() {
            Debug.Log("NBsn.Global OnApplicationQuit"); 
        }

        #region
        public static void UpdateRes() {
            Debug.Log("NBsn.Global UpdateRes"); 
            if (Config.ms_bEditorMode) {
                Global.UpdateResSuccess();
            }
            // todo: update res
        }

        public static void UpdateResSuccess() {
            Debug.Log("NBsn.Global UpdateResSuccess"); 

            Global.InitLua();
        }
        #endregion

        #region lua
        public static void InitLua() {
            Debug.Log("NBsn.Global InitLua"); 
            var luaReadFile = new LuaReadFile();
            Global.m_luaState  = new LuaState();
            luaReadFile.ClearSearchPath();
            Global.m_luaState.AddSearchPath(LuaConst.toluaDir);
            luaReadFile.ShowAll();
 
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_pb);      
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_lpeg);
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_bit);
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_socket_core);
 
            Global.m_luaState.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_cjson);
            Global.m_luaState.LuaSetField(-2, "cjson");
 
            Global.m_luaState.OpenLibs(LuaDLL.luaopen_cjson_safe);
            Global.m_luaState.LuaSetField(-2, "cjson.safe");
    
            Global.m_luaState.LuaSetTop(0);
            LuaBinder.Bind(Global.m_luaState);
            LuaCoroutine.Register(Global.m_luaState, Global.m_Main);
  
            Global.m_luaState.Start();
   
            luaReadFile.ClearSearchPath();
            Global.m_luaState.AddSearchPath(LuaConst.luaDir);
            luaReadFile.ShowAll();
            Global.m_luaState.DoFile("Main");
            LuaFunction main = m_luaState.GetFunction("Main");
            main.Call();
            main.Dispose();
            main = null;   
 
            Global.m_luaLooper = Global.m_goMain.AddComponent<NBsn.LuaLooper>();
        }

        public static void UninitLua() {
            Debug.Log("NBsn.Global UninitLua"); 
            Global.m_luaLooper.Dispose();
            Global.m_luaLooper = null;
 
            Global.m_luaState.Dispose();
            Global.m_luaState = null;  
        }

        public static void ThrowException() {
            Debug.Log("NBsn.Global ThrowException"); 
            string error = m_luaState.LuaToString(-1);
            Global.m_luaState.LuaPop(2);                
            throw new LuaException(error, LuaException.GetLastError());
        }
        #endregion
    }
}