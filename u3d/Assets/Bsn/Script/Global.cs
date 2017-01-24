using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    // [Reg2LuaAttribute]
    public class CGlobal : IDisposable {
        public static NBsn.CGlobal Instance {
            get { 
                #if UNITY_EDITOR
                if (m_instance == null) {
                    new CGlobal();
                }
                #endif
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

        public NBsn.CResMgr ResMgr {
            get { return m_ResMgr; }
        }

        public NBsn.CUIMgr UIMgr {
            get { return m_UIMgr; }
        }

        #region
        public CGlobal() {
            m_instance = this;
        }
        protected static CGlobal m_instance = null;

        protected NBsn.CLog m_Log = new NBsn.CLog();
        protected NBsn.CPathConfig m_PathConfig = new NBsn.CPathConfig();
        protected NBsn.NToLua.CConfig m_ToLuaConfig = new NBsn.NToLua.CConfig();
        protected NBsn.CResMgr m_ResMgr = new NBsn.CResMgr();
        protected NBsn.CUIMgr m_UIMgr = new NBsn.CUIMgr();

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

        // 游戏逻辑初始化
        public void GameInit(GameObject goBsn) {
            Log.Info("NBsn.CGlobal.GameInit()"); 
            UIMgr.Init(goBsn.transform.FindChild("UI"));
            UIMgr.GetUI("UIBsnUpdate");
        }

        public void GameUnInit() {
            Log.Info("NBsn.CGlobal.GameUnInit()"); 

            UIMgr.UnInit();
            m_UIMgr = null;
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