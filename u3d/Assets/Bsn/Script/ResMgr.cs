using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEditor;

namespace NBsn {

    [Reg2LuaAttribute]
    public class CResMgr {
        private static string ms_strEditorABResRootDir = "Assets/ABRes/";
    
        // ABRes/Prefeb/UI/UIUpdate.prefeb strPath= Prefeb/UI/UIUpdate.prefeb
        public GameObject LoadRes(string strPath) {
            GameObject ret = null;

            switch (Config.ms_eResLoadType) {
                case NBsn.EResLoadType.EditorABRes: {
                    ret = LoadABRes(strPath);
                }
                break;
                case NBsn.EResLoadType.EditorABOut: {
                    ret = LoadABOut(strPath);
                }
                break;
                case NBsn.EResLoadType.AppAB: {
                    ret = LoadAppAB(strPath);
                }
                break;
            }
            if (ret == null) {
                Debug.LogErrorFormat("LoadRes({0}) fail", strPath);
                return null;
            }

            ret = (GameObject)UnityEngine.Object.Instantiate(ret);
            ret.name = ret.name.Replace("(Clone)", "");
            return ret;
        }

        private GameObject LoadABRes(string strPath) {
            Debug.LogFormat("NBsn.CResMgr.LoadRes({0})", strPath);
            strPath = ms_strEditorABResRootDir + strPath;
            Debug.LogFormat("strPath={0}", strPath);
            GameObject ret = null;
            ret = AssetDatabase.LoadAssetAtPath<GameObject>(strPath);
            return ret;
        }

        private GameObject LoadABOut(string strPath) {
            Debug.LogFormat("NBsn.CResMgr.LoadABOut({0})", strPath);
            GameObject ret = null;
            return ret;
        }

        private GameObject LoadAppAB(string strPath) {
            Debug.LogFormat("NBsn.CResMgr.LoadAppAB({0})", strPath);
            GameObject ret = null;
            return ret;
        }
    }
}