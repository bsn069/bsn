using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [Reg2LuaAttribute]
    public class CGlobal : IDisposable {
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

        public NBsn.NToLua.CConfig ToLuaConfig {
            get { return m_ToLuaConfig; }
        }

        public NBsn.CPathConfig PathConfig {
            get { return m_PathConfig; }
        }

        #region
        public CGlobal() {
            m_instance = this;
        }
        protected static CGlobal m_instance = null;

        protected NBsn.CLog m_Log = new NBsn.CLog();
        protected NBsn.CPathConfig m_PathConfig = new NBsn.CPathConfig();
        protected NBsn.NToLua.CConfig m_ToLuaConfig = new NBsn.NToLua.CConfig();

        protected string    m_strPlatformName = null;

        #endregion

        // 初始化配置 不依赖游戏逻辑 编辑器代码亦可调用
        public void ConfigInit(string strPlatformName) {
            Log.InfoFormat("NBsn.CGlobal.InitConfig({0})", strPlatformName); 

#if !UNITY_EDITOR
            NBsn.Config.ResLoadType = NBsn.EResLoadType.AppAB;
#endif
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.Config.ResLoadType={0}", NBsn.Config.ResLoadType);

            m_strPlatformName = strPlatformName;
            Log.InfoFormat("NBsn.CGlobal.Instance.PlatformName={0}", NBsn.CGlobal.Instance.PlatformName); 
          
            PathConfig.Init();
            ToLuaConfig.Init();
        }

        public void Dispose() {
            m_instance = null;
        }

        //public static LuaState          ms_luaState  = null;
        //public static GameObject        ms_goMain    = null;
        //public static NBsn.MMain         ms_Main      = null;
        //public static NBsn.CLuaUpdate    ms_luaLooper = null;
        //public static NBsn.UIMgr        ms_UIMgr = new NBsn.UIMgr();
        //public static NBsn.CUpdateRes   ms_CUpdateRes = null;
        //public static NBsn.CResMgr      ms_CResMgr = new NBsn.CResMgr();
    }
}