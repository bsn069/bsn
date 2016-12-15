using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {

    [Reg2LuaAttribute]
    public class CUpdateRes {
        private bool m_bError = false;

        public void Start() {
            Global.ms_Main.StartCoroutine(CoroutineUpdate());
        }

        private IEnumerator CoroutineUpdate() {
            if (!Config.ms_bUseServerRes) {
                goto Exit0;
            }

            yield return Global.ms_Main.StartCoroutine(CoroutineUpdateTest1());
            if (m_bError) goto Exit0;  

            yield return Global.ms_Main.StartCoroutine(CoroutineUpdateTest2());
            if (m_bError) goto Exit0;  
        
        Exit0:
            if (m_bError) {
                Global.UpdateResFail();
            }
            else {
                Global.UpdateResSuccess();
            }
        }

        private IEnumerator CoroutineUpdateTest1() {
            Debug.Log("CoroutineUpdateTest1()");
            var www = new WWW("http://localhost:8080/test1.txt");
            while (!www.isDone) { 
                yield return null; 
            }
            Debug.LogFormat("error={0} bytesDownloaded={1}", www.error, www.bytesDownloaded);
            if (www.error != null) {
                m_bError = true;
            }
        }

        private IEnumerator CoroutineUpdateTest2() {
            Debug.Log("CoroutineUpdateTest2()");
            var www = new WWW("http://localhost:8080/test2.txt");
            while (!www.isDone) { 
                yield return null; 
            }
            Debug.LogFormat("error={0} bytesDownloaded={1}", www.error, www.bytesDownloaded);
            if (www.error != null) {
                m_bError = true;
            }
        }
    }
}