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
            Global.StartCoroutine(CoroutineUpdate());
        }

        #region update result
        private void UpdateResSuccess() {
            Debug.Log("NBsn.CUpdateRes UpdateResSuccess"); 
            Global.InitLua();
        }

        private void UpdateResFail() {
            Debug.Log("NBsn.CUpdateRes UpdateResFail"); 
            Application.Quit();
        }
        #endregion

        private static WWW NewServerResWWW(string pathName) {
            string strUrl = Config.ms_strServerResUrl + NBsn.Global.ms_strPlatformName + "/" + pathName;
            Debug.LogFormat("NBsn.Global NewServerResWWW strUrl={0}", strUrl); 
            return new WWW(strUrl);
        }

        // strFilePath "Lua/Main.lua"
        // return 
        private static string GetResLocalFullPath(string strPathName) {
            return NBsn.Global.ms_strResLocalFullPath + strPathName;
        }

        private IEnumerator CoroutineUpdate() {
            Debug.Log("CoroutineUpdate()");
            if (!Global.ms_bUpdateRes) { // 不更新资源
                goto Exit0;
            }

            yield return Global.StartCoroutine(CoroutineUpdateGetFileList());
            if (m_strError != null) goto Exit0;  

            // yield return Global.StartCoroutine(CoroutineUpdateDownload());
            // if (m_strError != null) goto Exit0;  

        Exit0:
            if (m_strError != null) {
                Debug.LogError(m_strError);
                UpdateResFail();
            }
            else {
                UpdateResSuccess();
            }
            Global.ms_CUpdateRes = null;
        }

        // private IEnumerator CoroutineUpdateDownload() {
        //     Debug.Log("CoroutineUpdateDownload()");

        //     var tfUIUpdate = Global.ms_UIMgr.GetUI("UIUpdate");
        //     var oUIUpdate = tfUIUpdate.GetComponent<UIUpdate>();

        //     WWW www = null;
        //     string strLocalPath = null;
        //     FileStream fs = null;
        //     string strDir = null;
        //     float fStepValue = 1.0f / m_strNeedDownloadFilePath.Count;
        //     float fValue = fStepValue;
        //     foreach (var strFilePath in m_strNeedDownloadFilePath) {
        //         oUIUpdate.SetText(strFilePath);
        //         www = NewServerResWWW(strFilePath);
        //         while (!www.isDone) { 
        //             yield return null; 
        //         }
        //         if (www.error != null) {
        //             m_strError = "";
        //             Debug.LogErrorFormat("www.error={0}", www.error);
        //             yield break;
        //         }

        //         strLocalPath = GetResLocalFullPath(strFilePath);
        //         Debug.LogFormat("strLocalPath={0}", strLocalPath);

        //         if (File.Exists(strLocalPath)) {
        //             fs = new FileStream(strLocalPath, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
        //         } else {
        //             strDir = Path.GetDirectoryName(strLocalPath);
        //             if (!Directory.Exists(strDir)) {
        //                 Directory.CreateDirectory(strDir);
        //             }
        //             fs = new FileStream(strLocalPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        //         }
        //         fs.Write(www.bytes, 0, www.bytes.Length);
        //         fs.Flush();
        //         fs.Dispose();
        //         yield return new WaitForSeconds(1);

        //         fValue += fStepValue;
        //         oUIUpdate.SetProgress(fValue);
        //     }
        //     oUIUpdate.gameObject.SetActive(false);
        // }
        
        private IEnumerator CoroutineUpdateGetFileList() {
            Debug.Log("CoroutineUpdateGetFileList()");

            var www = NewServerResWWW("FileList.txt");
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