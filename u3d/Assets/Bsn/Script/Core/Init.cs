using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class CInit {
    //    public static void Config(string strPlatformName) {
    //        Debug.LogFormat("NBsn.CInit.Config({0})", strPlatformName); 


    //        Debug.LogFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
    //        Debug.LogFormat("Application.dataPath={0}", Application.dataPath);
    //        Debug.LogFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
    //        Debug.LogFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);

    //        ms_strPlatformName = strPlatformName;
    //        Debug.LogFormat("ms_strPlatformName={0}", ms_strPlatformName); 

    //        ms_strPlatformABPath = string.Format(
    //            NBsn.Config.ms_strPlatformABPathFormat
    //            , ms_strPlatformName
    //            );
    //        Debug.LogFormat("NBsn.Config.ms_strPlatformABPathFormat={0}", NBsn.Config.ms_strPlatformABPathFormat); 
    //        Debug.LogFormat("ms_strPlatformABPath={0}", ms_strPlatformABPath); 
            
    //#if !UNITY_EDITOR
    //        Config.ms_eResLoadType = NBsn.EResLoadType.AppAB;
    //#endif
    //        Debug.LogFormat("Config.ms_eResLoadType={0}", Config.ms_eResLoadType);

    //        if (Config.ms_eResLoadType != NBsn.EResLoadType.AppAB) {
    //            ms_strResLocalFullPath = Application.dataPath + "/";
    //            ms_strABLocalFullPath = ms_strResLocalFullPath + ms_strPlatformABPath + "/";
    //            ms_strLuaLocalFullPath = ms_strResLocalFullPath + "Lua";
    //            ms_strToLuaLocalFullPath = ms_strResLocalFullPath + "Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
    //        }
    //        else {
    //            ms_strResLocalFullPath = Application.persistentDataPath + "/" + Config.ms_strServerResLocalDirName + "/";
    //            ms_strABLocalFullPath = ms_strResLocalFullPath + ms_strPlatformABPath + "/";
    //            ms_strLuaLocalFullPath = ms_strResLocalFullPath + "Lua";
    //            ms_strToLuaLocalFullPath = ms_strResLocalFullPath + "ToLua";  
    //        }

    //        Debug.LogFormat("ms_strResLocalFullPath={0}", ms_strResLocalFullPath);
    //        Debug.LogFormat("ms_strABLocalFullPath={0}", ms_strABLocalFullPath);
    //        Debug.LogFormat("ms_strLuaLocalFullPath={0}", ms_strLuaLocalFullPath);
    //        Debug.LogFormat("ms_strToLuaLocalFullPath={0}", ms_strToLuaLocalFullPath);

    //        LuaConst.osDir = ms_strPlatformName;
    //        LuaConst.luaDir = ms_strLuaLocalFullPath;
    //        LuaConst.toluaDir = ms_strToLuaLocalFullPath;
    //        LuaConst.luaResDir = ms_strLuaLocalFullPath;
    //        Debug.LogFormat("LuaConst.osDir={0}", LuaConst.osDir);
    //        Debug.LogFormat("LuaConst.luaDir={0}", LuaConst.luaDir);
    //        Debug.LogFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir);
    //        Debug.LogFormat("LuaConst.luaResDir={0}", LuaConst.luaResDir);
    //        ms_CResMgr.InitConfig();
    //    }

    //    public static void Start(GameObject goMain, NBsn.Main Main) {
    //        Debug.LogFormat("NBsn.CGlobal Init goMain={0}", goMain); 
            
    //        CGlobal.ms_goMain    = goMain;
    //        CGlobal.ms_Main      = Main;
    //        CGlobal.ms_UIMgr.Init(goMain.transform.FindChild("UI"));
    //        CGlobal.ms_CResMgr.Init();
            
    //        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    //        Application.targetFrameRate = Config.ms_nFPS;

    //        ms_UIMgr.NewUI("UIUpdate");
    //        ms_UIMgr.NewUI("UIUpdate2");
    //        CGlobal.ms_CUpdateRes = new NBsn.CUpdateRes();
    //        CGlobal.ms_CUpdateRes.Start();
    //    }

    //    public static void Stop() {
    //        Debug.Log("NBsn.CGlobal Uninit"); 

    //        CGlobal.ms_CUpdateRes = null;
    //        CGlobal.ms_UIMgr.Uninit();
    //        CGlobal.ms_Main      = null;
    //        CGlobal.ms_goMain    = null;

    //        CGlobal.UninitLua();
    //    }
    }
}