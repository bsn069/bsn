using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.IO;
using System.Diagnostics;
using LuaInterface;
using System.Threading; 

using Debug = UnityEngine.Debug;
using Debugger = LuaInterface.Debugger;
using BindType = ToLuaMenu.BindType;

namespace NBsnEditor {
    public static class CMenuAB {
        [MenuItem("Bsn/AB/1SetABName", false, 1)]
        public static void SetABName() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CMenuAB.SetABName()"); 
            NBsn.CGlobal.Instance.ConfigInit(NBsn.CPlatform.Name());
		    AssetDatabase.Refresh();
            NBsnEditor.CAssetBuddleBuilder.SetABName("ABRes", ".ab");
        } 

        #region MakeAB
        [MenuItem("Bsn/AB/2MakeAB/Win", false, 2)]
        public static void MakeABWin() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CMenuAB.MakeABWin()"); 
            NBsnEditor.CAssetBuddleBuilder.MakeAB(BuildTarget.StandaloneWindows);
        } 

        [MenuItem("Bsn/AB/2MakeAB/Android", false, 3)]
        public static void MakeABAndroid() {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CMenuAB.MakeABAndroid()"); 
            NBsnEditor.CAssetBuddleBuilder.MakeAB(BuildTarget.Android);
        } 
        #endregion
    }
}
