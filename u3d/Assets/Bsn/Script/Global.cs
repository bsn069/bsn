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

        public NBsn.MMain Main {
            get { return m_Main; }
        }

        public UnityEngine.GameObject GoMain {
            get { return m_goMain; }
        }

        public UnityEngine.Transform TfMain {
            get { return m_tfMain; }
        }

        public NBsn.CCoroutine Coroutine {
            get { return m_Coroutine; }
        }

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

        #region game init
        // 游戏逻辑初始化
        public void AppInit(GameObject goMain, NBsn.MMain Main) {
            Log.Info("NBsn.CGlobal.AppInit()"); 

            m_goMain    = goMain;
            m_Main      = Main;
            m_tfMain    = m_goMain.transform;

            Coroutine.Init(m_Main);
            ResMgr.Init();
            UIMgr.Init(m_tfMain.FindChild("UI"));
        }

        public void AppUnInit() {
            Log.Info("NBsn.CGlobal.AppUnInit()"); 

            UIMgr.UnInit();
            ResMgr.UnInit();
            Coroutine.UnInit();

            m_tfMain    = null;
            m_Main      = null;
            m_goMain    = null;
        }
        #endregion

        public void StartApp() {
            Log.Info("NBsn.CGlobal.StartApp()"); 

            var goUI = UIMgr.GetUI("UIBsnUpdate");
            var mUI = goUI.AddComponent<MUIBsnUpdate>();
            mUI.SetTip( CNetState.NetName() );
        }

        #region
        public CGlobal() {
            m_instance = this;
        }
        public void Dispose() {
            m_instance = null;
        }

        protected static CGlobal m_instance = null;

        protected NBsn.CLog m_Log = new NBsn.CLog();
        protected NBsn.CPathConfig m_PathConfig = new NBsn.CPathConfig();
        protected NBsn.NToLua.CConfig m_ToLuaConfig = new NBsn.NToLua.CConfig();
        protected NBsn.CResMgr m_ResMgr = new NBsn.CResMgr();
        protected NBsn.CUIMgr m_UIMgr = new NBsn.CUIMgr();
        protected NBsn.CCoroutine m_Coroutine = new NBsn.CCoroutine();

        protected NBsn.MMain m_Main = null;
        protected GameObject m_goMain = null;
        protected Transform m_tfMain = null;

        protected string    m_strPlatformName = null;
        #endregion
    }
}