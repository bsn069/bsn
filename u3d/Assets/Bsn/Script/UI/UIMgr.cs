using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    [Reg2LuaAttribute]
    public class CUIMgr {
        private Transform m_tfUIRoot = null;
        
        private string m_strUIPrefebRootDir = "Prefab/UI/";

        // strUIName=UIBsnUpdate
        // Assets/ABRes/Prefab/UI/UIBsnUpdate.prefab
        //   ?Resources/Prefab/UI/UIBsnUpdate.prefab
        public GameObject GetUI(string strUIName) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CUIMgr.GetUI({0})", strUIName); 

            var strUIPath = string.Format("{0}{1}", m_strUIPrefebRootDir, strUIName);
            NBsn.CGlobal.Instance.Log.InfoFormat("strUIPath={0}", strUIPath);

            var goUIPrefeb = NBsn.CGlobal.Instance.ResMgr.Load(strUIPath);
            if (goUIPrefeb == null) {
                NBsn.CGlobal.Instance.Log.InfoFormat("LoadRes fail! strUIPath={0}", strUIPath);
                return null;
            }

            goUIPrefeb.transform.SetParent(m_tfUIRoot);
            var rectTransform = goUIPrefeb.GetComponent<RectTransform>();
            rectTransform.localPosition = Vector3.zero;
            rectTransform.sizeDelta = Vector2.zero;
            rectTransform.localScale = Vector3.one;
            // rectTransform.localRotation = Quaternion.identity;
            return goUIPrefeb;
        }

        #region init
        public void Init(Transform tfUIRoot) {
           m_tfUIRoot = tfUIRoot;
        }

        public void UnInit() {
           m_tfUIRoot = null;
        }
        #endregion

        // Assets/ABRes/Prefab/UI/UIUpdate.prefab
        //private static string ms_strUIPrefebRootDir = "Prefab/UI/";

        //public Transform m_tfRoot = null;

        //#region init
        //public void Init(Transform tfUI) {
        //    m_tfRoot = tfUI;
        //}

        //public void Uninit() {
        //    m_tfRoot = null;
        //}
        //#endregion

        //// Assets/ABRes/Prefab/UI/UIUpdate.prefab strUIName=UIUpdate
        //public GameObject NewUI(string strUIName) {
        //    Debug.LogFormat("NBsn.UIMgr.ShowUI({0})", strUIName);
        //    var strUIPath = string.Format("{0}{1}.prefab", ms_strUIPrefebRootDir, strUIName);
        //    Debug.LogFormat("strUIPath={0}", strUIPath);
        //    var goUIPrefeb = Global.ms_CResMgr.LoadRes(strUIPath);
        //    if (goUIPrefeb == null) {
        //        Debug.LogErrorFormat("LoadRes fail! strUIPath={0}", strUIPath);
        //        return null;
        //    }

        //    goUIPrefeb.transform.SetParent(m_tfRoot);
        //    var rectTransform = goUIPrefeb.GetComponent<RectTransform>();
        //    rectTransform.localPosition = Vector3.zero;
        //    rectTransform.sizeDelta = Vector2.zero;
        //    rectTransform.localScale = Vector3.one;
        //    // rectTransform.localRotation = Quaternion.identity;
        //    return goUIPrefeb;
        //}
    }
}