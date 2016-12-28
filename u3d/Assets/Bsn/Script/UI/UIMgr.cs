using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    [Reg2LuaAttribute]
    public class UIMgr {
        public Transform m_tfRoot = null;

        #region init
        public void Init(Transform tfUI) {
            m_tfRoot = tfUI;
        }

        public void Uninit() {
            m_tfRoot = null;
        }
        #endregion

        public void ShowUI(string strUIName) {

        }
    }
}