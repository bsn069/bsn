using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections.Generic;

namespace NBsn {

    [Reg2LuaAttribute]
    public class CUpdateRes {
        private string m_strError = null;
        private List<string> m_strNeedDownloadFilePath = null;

        public void Start() {
            Global.ms_Main.StartCoroutine(CoroutineUpdate());
        }

        private IEnumerator CoroutineUpdate() {
            Debug.Log("CoroutineUpdate()");
            if (!Global.ms_bUpdateRes) {
                goto Exit0;
            }

            yield return Global.ms_Main.StartCoroutine(CoroutineUpdateGetFileList());
            if (m_strError != null) goto Exit0;  

            yield return Global.ms_Main.StartCoroutine(CoroutineUpdateDownload());
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

        private IEnumerator CoroutineUpdateDownload() {
            Debug.Log("CoroutineUpdateDownload()");

            WWW www = null;
            string strLocalPath = null;
            FileStream fs = null;
            string strDir = null;
            foreach (var strFilePath in m_strNeedDownloadFilePath) {
                www = Global.NewServerResWWW(strFilePath);
                while (!www.isDone) { 
                    yield return null; 
                }
                if (www.error != null) {
                    m_strError = "";
                    Debug.LogErrorFormat("www.error={0}", www.error);
                    yield break;
                }

                strLocalPath = Global.GetResLocalFullPath(strFilePath);
                Debug.LogFormat("strLocalPath={0}", strLocalPath);

                if (File.Exists(strLocalPath)) {
                    fs = new FileStream(strLocalPath, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                } else {
                    strDir = Path.GetDirectoryName(strLocalPath);
                    if (!Directory.Exists(strDir)) {
                        Directory.CreateDirectory(strDir);
                    }
                    fs = new FileStream(strLocalPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                }
                fs.Write(www.bytes, 0, www.bytes.Length);
                fs.Flush();
                fs.Dispose();
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

            m_strNeedDownloadFilePath = new List<string>();
            string strLine = null;
            string[] strLineData = null;
            while (true) {
                strLine = stringReader.ReadLine();
                if (strLine == null) {
                    break;
                }
                Debug.Log(strLine);
                strLineData = strLine.Split(',');
                if (strLineData.Length == 2) {
                    foreach (var item in strLineData) {
                        Debug.Log(item);
                    }
                    m_strNeedDownloadFilePath.Add(strLineData[0]);
                }
            }
        }
    }
}