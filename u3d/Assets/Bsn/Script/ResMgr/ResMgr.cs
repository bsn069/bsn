using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections.Generic;

namespace NBsn {

    // [Reg2LuaAttribute]
    public class CResMgr {
        public GameObject Load(string strPath, string strSuffix) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CResMgr.Load({0}, {1})", strPath, strSuffix);

            GameObject go = null;
            switch (NBsn.Config.ResLoadType) {
#if UNITY_EDITOR
                case NBsn.EResLoadType.EditorABRes: {
                    go = m_ABRes.Load(strPath, strSuffix);
                }
                break;
                case NBsn.EResLoadType.EditorABOut: {
                    go = m_ABOut.Load(strPath, strSuffix);
                }
                break;
#endif
                case NBsn.EResLoadType.AppAB: {
                    go = m_ABApp.Load(strPath, strSuffix);
                }
                break;
                default: {
                    NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.Config.ResLoadType={0}", NBsn.Config.ResLoadType);
                    return null;
                }
            }
            
            if (go == null) {
                go = m_Resources.Load(strPath);
            }

            if (go != null) {
                go = (GameObject)UnityEngine.Object.Instantiate(go);
                go.name = go.name.Replace("(Clone)", "");
            }
            return go;
        }

        public bool Init() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CResMgr.Init()");

            if (m_bInit) {
                NBsn.CGlobal.Instance.Log.ErrorFormat("had Init");
                return true;
            }

            switch (NBsn.Config.ResLoadType) {
#if UNITY_EDITOR
                case NBsn.EResLoadType.EditorABRes: {
                    m_ABRes = new CABRes();
                    m_bInit = m_ABRes.Init();
                    break;
                }
                case NBsn.EResLoadType.EditorABOut: {
                    m_ABOut = new CABOut();
                    m_bInit = m_ABOut.Init();
                    break;
                }
#endif
                case NBsn.EResLoadType.AppAB: {
                    m_ABApp = new CABApp();
                    m_bInit = m_ABApp.Init();
                    break;
                }
                default: {
                    NBsn.CGlobal.Instance.Log.ErrorFormat("NBsn.Config.ResLoadType={0}", NBsn.Config.ResLoadType);
                    return false;
                }
            }

            return m_bInit;
        }

        public void UnInit() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CResMgr.UnInit()");

            if (!m_bInit) {
                NBsn.CGlobal.Instance.Log.ErrorFormat("had UnInit");
                return;
            }
            m_bInit = false;

            switch (NBsn.Config.ResLoadType) {
#if UNITY_EDITOR
                case NBsn.EResLoadType.EditorABRes: {
                     m_ABRes.UnInit();
                }
                break;
                case NBsn.EResLoadType.EditorABOut: {
                     m_ABOut.UnInit();
                }
                break;
#endif
                case NBsn.EResLoadType.AppAB: {
                     m_ABApp.UnInit();
                }
                break;
                default: {
                    NBsn.CGlobal.Instance.Log.ErrorFormat("NBsn.Config.ResLoadType={0}", NBsn.Config.ResLoadType);
                    return;
                }
            }
        }

        protected CResources    m_Resources = new CResources();
#if UNITY_EDITOR
        protected CABRes    m_ABRes = null;
        protected CABOut    m_ABOut = null;
#endif
        protected CABApp    m_ABApp = null;
        protected bool      m_bInit = false;
    }
}