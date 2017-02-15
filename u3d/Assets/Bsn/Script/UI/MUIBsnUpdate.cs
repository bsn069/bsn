using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {
    public class MUIBsnUpdate : MonoBehaviour {
        private Slider m_slider = null;
        private Text m_value = null;
        private Text m_tip = null;

        void Awake() {
            NBsn.CGlobal.Instance.Log.Info("NBsn.MUIBsnUpdate.Awake()"); 

            var tfSlider = transform.FindChild("Slider");
            m_slider    = tfSlider.GetComponent<Slider>();
            m_value     = tfSlider.FindChild("Text").GetComponent<Text>();
            m_tip       = transform.FindChild("Tip").GetComponent<Text>();
        }

        public void SetProgress(float fValue) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MUIBsnUpdate.SetProgress({0})", fValue); 
            m_slider.value = fValue;
        }

        public void SetValue(string strText) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MUIBsnUpdate.SetValue({0})", strText); 
            m_value.text = strText;
        }

        public void SetTip(string strText) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MUIBsnUpdate.SetTip({0})", strText); 
            m_tip.text = strText;
        }
    }
}