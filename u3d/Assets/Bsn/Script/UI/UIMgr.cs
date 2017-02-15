using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    //[Reg2LuaAttribute]
    public class CUIMgr {
        // Assets/ABRes/Prefab/UI/UIBsnUpdate.prefab
        //   ?Resources/Prefab/UI/UIBsnUpdate.prefab
        // strUIName=UIBsnUpdate
        public GameObject GetUI(string strUIName) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CUIMgr.GetUI({0})", strUIName); 

            var strUIPath = string.Format("{0}{1}", ms_strUIPrefebRootDir, strUIName);
            NBsn.CGlobal.Instance.Log.InfoFormat("strUIPath={0}", strUIPath);

            var goUIPrefeb = NBsn.CGlobal.Instance.ResMgr.Load(strUIPath, "prefab");
            if (goUIPrefeb == null) {
                NBsn.CGlobal.Instance.Log.InfoFormat("LoadRes fail! strUIPath={0}", strUIPath);
                return null;
            }

            goUIPrefeb.transform.SetParent(m_tfUIRoot);
            var rectTransform = goUIPrefeb.GetComponent<RectTransform>();
            rectTransform.localPosition = Vector3.zero;
            rectTransform.sizeDelta = Vector2.zero;
            rectTransform.localScale = Vector3.one;
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

        #region member var
        private Transform m_tfUIRoot = null;
        private static string ms_strUIPrefebRootDir = "Prefab/UI/";
        #endregion
    }
}