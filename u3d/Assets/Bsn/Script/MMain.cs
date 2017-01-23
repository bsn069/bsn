using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {
    // [Reg2LuaAttribute]
    public class MMain : MonoBehaviour {
        void Awake() {
            DontDestroyOnLoad(gameObject);  //防止销毁自己
            new NBsn.CGlobal();
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.Awake()"); 
            NBsn.CGlobal.Instance.ConfigInit(NBsn.CPlatform.Name());
        }

        void Start() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.Start()"); 
            NBsn.CGlobal.Instance.GameInit(gameObject);
        }

        void OnDestroy() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.OnDestroy()"); 
            NBsn.CGlobal.Instance.GameUnInit();
            NBsn.CGlobal.Instance.Dispose();
        }
    }
}