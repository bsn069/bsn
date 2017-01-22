using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {
    [Reg2LuaAttribute]
    public class MMain : MonoBehaviour {
        void Awake() {
            DontDestroyOnLoad(gameObject);  //防止销毁自己
            new NBsn.CGlobal();
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.Awake()"); 
            NBsn.CGlobal.Instance.InitConfig(NBsn.CPlatform.Name());
        }

        void Start() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.Start()"); 
        }

        void OnDestroy() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.MMain.OnDestroy()"); 
        }
    }
}