using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [Reg2LuaAttribute]
    public class CGlobal {
        public static NBsn.CGlobal Instance {
            get {
                return m_instance;
            }
        }

        public NBsn.CLog Log {
            get { return m_Log; }
        }

        public string PlatformName {
            get { return m_strPlatformName; }
        }

        // AB根目录 相对资源路径 
        public string PlatformABPath {
            get { return m_strPlatformABPath; }
        }

        // AB根目录 本地全路径
        public string ABLocalFullPath {
            get { return m_strABLocalFullPath; }
        }

        // 资源根目录 本地全路径
        public string ResLocalFullPath {
            get { return m_strResLocalFullPath; }
        }

        public string LuaLocalFullPath {
            get { return m_strLuaLocalFullPath; }
        }

        public string ToLuaLocalFullPath {
            get { return m_strToLuaLocalFullPath; }
        }

        #region
        public CGlobal() {
            m_instance = this;
        }
        protected static CGlobal m_instance = null;

        protected NBsn.CLog m_Log = new NBsn.CLog();
        protected string    m_strPlatformName = null;
        protected string    m_strPlatformABPath = null;
        protected string    m_strABLocalFullPath = null;
        protected string    m_strResLocalFullPath = null;
        protected string    m_strLuaLocalFullPath = null;
        protected string    m_strToLuaLocalFullPath = null;
        #endregion

        #region InitConfig
        public void InitConfig(string strPlatformName) {
            Log.InfoFormat("NBsn.CGlobal.InitConfig({0})", strPlatformName); 

            Log.InfoFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            Log.InfoFormat("Application.dataPath={0}", Application.dataPath);
            Log.InfoFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            Log.InfoFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);

            m_strPlatformName = strPlatformName;
            Log.InfoFormat("NBsn.CGlobal.Instance.PlatformName={0}", NBsn.CGlobal.Instance.PlatformName); 

            m_strPlatformABPath = string.Format(
                NBsn.Config.ms_strPlatformABPathFormat
                , NBsn.CGlobal.Instance.PlatformName
                );
            Log.InfoFormat("NBsn.Config.ms_strPlatformABPathFormat={0}", NBsn.Config.ms_strPlatformABPathFormat); 
            Log.InfoFormat("NBsn.CGlobal.Instance.PlatformABPath={0}", NBsn.CGlobal.Instance.PlatformABPath); 
            
    #if !UNITY_EDITOR
            Config.ms_eResLoadType = NBsn.EResLoadType.AppAB;
    #endif
            Log.InfoFormat("Config.ms_eResLoadType={0}", Config.ms_eResLoadType);

            if (Config.ms_eResLoadType != NBsn.EResLoadType.AppAB) {
                m_strResLocalFullPath       = Application.dataPath + "/";
                m_strABLocalFullPath       = NBsn.CGlobal.Instance.ResLocalFullPath + NBsn.CGlobal.Instance.PlatformABPath + "/";
                m_strLuaLocalFullPath      = NBsn.CGlobal.Instance.ResLocalFullPath + "Lua";
                m_strToLuaLocalFullPath    = NBsn.CGlobal.Instance.ResLocalFullPath + "Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
            }
            else {
                m_strResLocalFullPath       = Application.persistentDataPath + "/" + Config.ms_strServerResLocalDirName + "/";
                m_strABLocalFullPath       = NBsn.CGlobal.Instance.ResLocalFullPath + NBsn.CGlobal.Instance.PlatformABPath + "/";
                m_strLuaLocalFullPath      = NBsn.CGlobal.Instance.ResLocalFullPath + "Lua";
                m_strToLuaLocalFullPath    = NBsn.CGlobal.Instance.ResLocalFullPath + "ToLua";  
            }

            Log.InfoFormat("NBsn.CGlobal.Instance.ResLocalFullPath={0}", NBsn.CGlobal.Instance.ResLocalFullPath);
            Log.InfoFormat("NBsn.CGlobal.Instance.ABLocalFullPath={0}", NBsn.CGlobal.Instance.ABLocalFullPath);
            Log.InfoFormat("NBsn.CGlobal.Instance.LuaLocalFullPath={0}", NBsn.CGlobal.Instance.LuaLocalFullPath);
            Log.InfoFormat("NBsn.CGlobal.Instance.ToLuaLocalFullPath={0}", NBsn.CGlobal.Instance.ToLuaLocalFullPath);

            LuaConst.osDir = NBsn.CGlobal.Instance.PlatformName;
            LuaConst.luaDir = NBsn.CGlobal.Instance.LuaLocalFullPath;
            LuaConst.toluaDir = NBsn.CGlobal.Instance.ToLuaLocalFullPath;
            LuaConst.luaResDir = NBsn.CGlobal.Instance.LuaLocalFullPath;
            Log.InfoFormat("LuaConst.osDir={0}", LuaConst.osDir);
            Log.InfoFormat("LuaConst.luaDir={0}", LuaConst.luaDir);
            Log.InfoFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir);
            Log.InfoFormat("LuaConst.luaResDir={0}", LuaConst.luaResDir);
        }
        #endregion


        //public static LuaState          ms_luaState  = null;
        //public static GameObject        ms_goMain    = null;
        //public static NBsn.MMain         ms_Main      = null;
        //public static NBsn.CLuaUpdate    ms_luaLooper = null;
        //public static NBsn.UIMgr        ms_UIMgr = new NBsn.UIMgr();
        //public static NBsn.CUpdateRes   ms_CUpdateRes = null;
        //public static NBsn.CResMgr      ms_CResMgr = new NBsn.CResMgr();
        

    }
}