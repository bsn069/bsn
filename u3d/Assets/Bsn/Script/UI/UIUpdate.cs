using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    [Reg2LuaAttribute]
    public class UIUpdate : MonoBehaviour {
        private Slider m_slider = null;
        private Text m_text = null;

        void Awake() {
            Debug.LogFormat("NBsn.CUIUpdate Awake"); 
            var tfSlider = transform.FindChild("Slider");
            m_slider = tfSlider.GetComponent<Slider>();
            m_text = tfSlider.FindChild("Text").GetComponent<Text>();
        }

        void Start() {
            Debug.LogFormat("NBsn.CUIUpdate Start"); 
        }

        public void SetProgress(float fValue) {
            m_slider.value = fValue;
        }

        public void SetText(string strText) {
            m_text.text = strText;
        }
    }
}