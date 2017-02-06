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
        protected CResources    m_Resources = new CResources();

#if UNITY_EDITOR
        protected CABRes        m_ABRes     = new CABRes();
        protected CABOut        m_ABOut     = new CABOut();
#endif

        public GameObject Load(string strPath, string strSuffix) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CResMgr.Load({0}, {1})", strPath, strSuffix);

            GameObject go = null;
            switch (NBsn.Config.ResLoadType) {
                case NBsn.EResLoadType.EditorABRes: {
#if UNITY_EDITOR
                     go = m_ABRes.Load(strPath, strSuffix);
#endif
                }
                break;
                case NBsn.EResLoadType.EditorABOut: {
#if UNITY_EDITOR
                     go = m_ABOut.Load(strPath, strSuffix);
#endif
                }
                break;
                case NBsn.EResLoadType.AppAB: {

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

        public void Init() {
#if UNITY_EDITOR
            m_ABOut.Init();
#endif
        }

        //private string m_strResRootDir = null;
        //private Dictionary<string, AssetBundle> m_abCache = new Dictionary<string, AssetBundle>();
        //private AssetBundleManifest m_abManifest = null;

        //public void InitConfig() {
        //    Debug.LogFormat("NBsn.CResMgr.InitConfig()"); 

        //    switch (Config.ms_eResLoadType) {
        //        case NBsn.EResLoadType.EditorABRes: {
        //            m_strResRootDir = "Assets/ABRes/";
        //        }
        //        break;
        //        case NBsn.EResLoadType.EditorABOut: {
        //            m_strResRootDir = Global.ms_strABLocalFullPath + "assets/abres/";
        //        }
        //        break;
        //        case NBsn.EResLoadType.AppAB: {
        //        }
        //        break;
        //    }
        //    Debug.LogFormat("CResMgr.m_strResRootDir={0}", m_strResRootDir);
        //}

        //public void Init() {
        //    Debug.LogFormat("NBsn.CResMgr.Init()"); 

        //    var strLoadPath = Global.ms_strABLocalFullPath + "AB";
        //    var ab = AssetBundle.LoadFromFile(strLoadPath);
        //    m_abManifest = ab.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        //    ab.Unload(false);
        //}

        //// ABRes/Prefeb/UI/UIUpdate.prefeb strPath= Prefeb/UI/UIUpdate.prefeb
        //public GameObject LoadRes(string strPath) {
        //    GameObject ret = null;

        //    switch (Config.ms_eResLoadType) {
        //        case NBsn.EResLoadType.EditorABRes: {
        //            ret = LoadABRes(strPath);
        //        }
        //        break;
        //        case NBsn.EResLoadType.EditorABOut: {
        //            ret = LoadABOut(strPath);
        //        }
        //        break;
        //        case NBsn.EResLoadType.AppAB: {
        //            ret = LoadAppAB(strPath);
        //        }
        //        break;
        //    }
        //    if (ret == null) {
        //        Debug.LogErrorFormat("LoadRes({0}) fail", strPath);
        //        return null;
        //    }

        //    ret = (GameObject)UnityEngine.Object.Instantiate(ret);
        //    ret.name = ret.name.Replace("(Clone)", "");
        //    return ret;
        //}

        //private GameObject LoadABRes(string strPath) {
        //    Debug.LogFormat("NBsn.CResMgr.LoadRes({0})", strPath);
        //    strPath = m_strResRootDir + strPath;
        //    Debug.LogFormat("strPath={0}", strPath);
        //    GameObject ret = null;
        //    ret = AssetDatabase.LoadAssetAtPath<GameObject>(strPath);
        //    return ret;
        //}

        //private GameObject LoadABOut(string strResPath) {
        //    Debug.LogFormat("NBsn.CResMgr.LoadABOut({0})", strResPath);

        //    AssetBundle ab = LoadAB(strResPath);
        //    if (ab == null) {
        //        return null;
        //    }
        //    var index = strResPath.LastIndexOf("/");
        //    var strResName = strResPath.Substring(index+1);
        //    Debug.LogFormat("strResName={0}", strResName);
        //    GameObject ret = ab.LoadAsset<GameObject>(strResName);
        //    return ret;
        //}

        //// ABRes/Prefeb/UI/UIUpdate.prefeb => strPath= Prefeb/UI/UIUpdate.prefeb
        //private AssetBundle LoadAB(string strResPath) {
        //    Debug.LogFormat("NBsn.CResMgr.LoadAB({0})", strResPath);

        //    AssetBundle ab;
        //    if (!m_abCache.TryGetValue(strResPath, out ab)) {
        //        var strABName = "assets/abres/" + strResPath + ".ab";
        //        Debug.LogFormat("strABName={0}", strABName);
        //        var arrDepd = m_abManifest.GetDirectDependencies(strABName);
        //        for(int i = 0; i < arrDepd.Length; ++i) {
        //            var strDepABName = arrDepd[i];
        //            Debug.LogFormat("i={1} strDepABName={0}", strDepABName, i);
        //            strDepABName = strDepABName.Substring(13);
        //            strDepABName = strDepABName.Substring(0, strDepABName.Length - 3);
        //            LoadAB(strDepABName);
        //        }

        //        var strLoadPath = Global.ms_strABLocalFullPath + strABName;
        //        Debug.LogFormat("strLoadPath={0}", strLoadPath);
        //        ab = AssetBundle.LoadFromFile(strLoadPath);
        //        if (ab != null) {
        //            m_abCache.Add(strResPath, ab);
        //        }
        //    }
        //    return ab;
        //}

        //private GameObject LoadAppAB(string strPath) {
        //    Debug.LogFormat("NBsn.CResMgr.LoadAppAB({0})", strPath);
        //    GameObject ret = null;
        //    return ret;
        //}
    }
}