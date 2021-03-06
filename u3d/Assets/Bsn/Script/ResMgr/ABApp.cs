using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections.Generic;

namespace NBsn {
    public class CABApp {
        private string m_strPathFormat = "assets/abres/{0}.ab";
        private Dictionary<string, AssetBundle> m_abCache = new Dictionary<string, AssetBundle>();
        private AssetBundleManifest             m_abManifest = null;

        public GameObject Load(string strPath, string strSuffix) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CABOut.Load({0}, {1})", strPath, strSuffix); 

            strPath += "." + strSuffix;
            AssetBundle ab = LoadAB(strPath);
            if (ab == null) {
                return null;
            }

            var index = strPath.LastIndexOf("/");
            var strResName = strPath.Substring(index+1);
            NBsn.CGlobal.Instance.Log.InfoFormat("strResName={0}", strResName);
            return ab.LoadAsset<GameObject>(strResName);
        }

        public bool Init() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CABOut.Init()"); 

            var strLoadPath = NBsn.CGlobal.Instance.PathConfig.ABLocalFullPath + "AB";
            var ab = AssetBundle.LoadFromFile(strLoadPath);
            m_abManifest = ab.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
            ab.Unload(false);
            return true;
        }

        public void UnInit() {

        }

        private AssetBundle LoadAB(string strResPath) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CABOut.LoadAB({0})", strResPath);

            AssetBundle ab;
            if (!m_abCache.TryGetValue(strResPath, out ab)) {
                var strABName = string.Format(m_strPathFormat, strResPath);
                NBsn.CGlobal.Instance.Log.InfoFormat("strABName={0}", strABName);
                var arrDepd = m_abManifest.GetDirectDependencies(strABName);
                for(int i = 0; i < arrDepd.Length; ++i) {
                    var strDepABName = arrDepd[i];
                    NBsn.CGlobal.Instance.Log.InfoFormat("i={1} strDepABName={0}", strDepABName, i);
                    strDepABName = strDepABName.Substring(13);
                    strDepABName = strDepABName.Substring(0, strDepABName.Length - 3);
                    LoadAB(strDepABName);
                }

                var strLoadPath = NBsn.CGlobal.Instance.PathConfig.ABLocalFullPath + strABName;
                NBsn.CGlobal.Instance.Log.InfoFormat("strLoadPath={0}", strLoadPath);
                ab = AssetBundle.LoadFromFile(strLoadPath);
                if (ab != null) {
                    m_abCache.Add(strResPath, ab);
                }
            }
            return ab;
        }
    }
}

