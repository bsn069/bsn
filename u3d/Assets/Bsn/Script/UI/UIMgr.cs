using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    [Reg2LuaAttribute]
    public class UIMgr {
        // Assets/ABRes/Prefab/UI/UIUpdate.prefab
        private static string ms_strUIPrefebRootDir = "Prefab/UI/";

        public Transform m_tfRoot = null;

        #region init
        public void Init(Transform tfUI) {
            m_tfRoot = tfUI;
        }

        public void Uninit() {
            m_tfRoot = null;
        }
        #endregion

        // Assets/ABRes/Prefab/UI/UIUpdate.prefab strUIName=UIUpdate
        public void NewUI(string strUIName) {
            Debug.LogFormat("NBsn.UIMgr.ShowUI({0})", strUIName);
            var strUIPath = string.Format("{0}{1}.prefab", ms_strUIPrefebRootDir, strUIName);
            Debug.LogFormat("strUIPath={0}", strUIPath);
            var goUIPrefeb = Global.ms_CResMgr.LoadRes(strUIPath);
            goUIPrefeb.transform.parent = m_tfRoot;
        }
    }
}