﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    [Reg2LuaAttribute]
    public class Main : MonoBehaviour {
        void Awake() {
            Debug.LogFormat("NBsn.Main Awake"); 
            DontDestroyOnLoad(gameObject);  //防止销毁自己
            NBsn.Global.InitConfig(NBsn.Config.GetPlatformName());
        }

        void Start() {
            Debug.LogFormat("NBsn.Main Start"); 
            NBsn.Global.Init(gameObject, this);
        }

        void OnApplicationQuit() {
            Debug.LogFormat("NBsn.Main OnApplicationQuit"); 
            NBsn.Global.OnApplicationQuit();
        }

        void OnDestroy() {
            Debug.LogFormat("NBsn.Main OnDestroy"); 
            NBsn.Global.Uninit();
        }

        public void SetProgress(float fValue) {

        }

        public void SetText(string strText) {

        }
    }
}