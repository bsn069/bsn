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
    public static class MenuAB {
        [MenuItem("Bsn/AB/1SetAssetName", false, 1)]
        public static void SetAssetName() {
            Debug.Log("NBsnEditor.MenuAB.SetAssetName()");
		    AssetDatabase.Refresh();
            AssetBuddleBuilder.SetAssertName("ABRes", ".ab");
        } 

        #region MakeAB
        [MenuItem("Bsn/AB/2MakeAB/Win", false, 2)]
        public static void MakeABWin() {
            Debug.Log("NBsnEditor.MenuAB.MakeABWin()");
		    AssetDatabase.Refresh();
            AssetBuddleBuilder.U5AB(BuildTarget.StandaloneWindows);
        } 

        [MenuItem("Bsn/AB/2MakeAB/Android", false, 3)]
        public static void MakeABAndroid() {
            Debug.Log("NBsnEditor.MenuAB.MakeABAndroid()");
		    AssetDatabase.Refresh();
            AssetBuddleBuilder.U5AB(BuildTarget.Android);
        } 
        #endregion
    }
}
