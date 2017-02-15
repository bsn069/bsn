using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    //[Reg2LuaAttribute]
    public class CPathConfig {
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

        #region
        public CPathConfig() {

        }

        protected string    m_strPlatformABPath = null;
        protected string    m_strABLocalFullPath = null;
        protected string    m_strResLocalFullPath = null;
        #endregion

        public void Init() {
            NBsn.CGlobal.Instance.Log.Info("NBsn.CPathConfig.Init()"); 

            NBsn.CGlobal.Instance.Log.InfoFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            NBsn.CGlobal.Instance.Log.InfoFormat("Application.dataPath={0}", Application.dataPath);
            NBsn.CGlobal.Instance.Log.InfoFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            NBsn.CGlobal.Instance.Log.InfoFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);

            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.Config.PlatformABPathFormat={0}", NBsn.Config.PlatformABPathFormat); 
            m_strPlatformABPath = string.Format(
                NBsn.Config.PlatformABPathFormat
                , NBsn.CGlobal.Instance.PlatformName
                );
            NBsn.CGlobal.Instance.Log.InfoFormat("PlatformABPath={0}", PlatformABPath); 

            if (NBsn.Config.ResLoadType == NBsn.EResLoadType.AppAB) {
                m_strResLocalFullPath   = Application.persistentDataPath + "/" + NBsn.Config.ServerResLocalDirName + "/";
            }
            else {
                m_strResLocalFullPath   = Application.dataPath + "/";
            }
            NBsn.CGlobal.Instance.Log.InfoFormat("ResLocalFullPath={0}", ResLocalFullPath);

            m_strABLocalFullPath    = ResLocalFullPath + PlatformABPath + "/";
            NBsn.CGlobal.Instance.Log.InfoFormat("ABLocalFullPath={0}", ABLocalFullPath);
        }
    }
}