using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;
using System.IO;

namespace NBsn {

    [Reg2LuaAttribute]
    public class CUpdateRes {
        private string m_strError = null;

        public void Start() {
            Global.ms_Main.StartCoroutine(CoroutineUpdate());
        }

        private IEnumerator CoroutineUpdate() {
            Debug.Log("CoroutineUpdate()");
            if (!Config.ms_bUseServerRes) {
                goto Exit0;
            }

            yield return Global.ms_Main.StartCoroutine(CoroutineUpdateGetFileList());
            if (m_strError != null) goto Exit0;  

        Exit0:
            if (m_strError != null) {
                Debug.LogError(m_strError);
                Global.UpdateResFail();
            }
            else {
                Global.UpdateResSuccess();
            }
        }

        private IEnumerator CoroutineUpdateGetFileList() {
            Debug.Log("CoroutineUpdateGetFileList()");

            var www = Global.NewServerResWWW("FileList.txt");
            while (!www.isDone) { 
                yield return null; 
            }

            if (www.error != null) {
                m_strError = "";
                Debug.LogErrorFormat("www.error={0}", www.error);
                yield break;
            }

            var strText = www.text;
            Debug.Log(strText);

            StringReader stringReader = new StringReader(strText);
            if (stringReader == null) {
                m_strError = "";
                Debug.LogError("stringReader == null");
                yield break;
            }

            string strLine = null;
            string[] strLineData = null;
            while (true) {
                strLine = stringReader.ReadLine();
                if (strLine == null) {
                    break;
                }
                Debug.Log(strLine);
                strLineData = strLine.Split(',');
                foreach (var item in strLineData) {
                    Debug.Log(item);
                }
            }

            Debug.Log("LuaConst.luaDir files");
            var strLuaFiles = Directory.GetFiles(LuaConst.luaDir);
            foreach (var item in strLuaFiles) {
                Debug.Log(item);
            }

            Debug.Log("LuaConst.toluaDir files");
            var strToLuaFiles = Directory.GetFiles(LuaConst.toluaDir, "*", SearchOption.AllDirectories);
            foreach (var item in strToLuaFiles) {
                Debug.Log(item);
            }
        }
    }
}