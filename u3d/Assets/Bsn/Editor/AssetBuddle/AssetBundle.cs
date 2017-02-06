using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

namespace NBsnEditor {       

    public static class CAssetBuddleBuilder  {
        // strABResRelativeDir "ABRes" relative
        // strABsuffix ".ab"
        public static bool SetABName(string strABResRelativeDir, string strABsuffix) {
            NBsn.CGlobal.Instance.Log.InfoFormat(
                "NBsnEditor.CAssetBuddleBuilder.SetABName(\"{0}\", \"{1}\")"
                , strABResRelativeDir
                , strABsuffix
            ); 
            EditorUtility.DisplayProgressBar("设置AssetName名称", "正在设置AssetName名称中...", 0f);
            
            var strABResFullPath = Path.Combine(Application.dataPath, strABResRelativeDir);
            NBsn.CGlobal.Instance.Log.InfoFormat("strABResFullPath={0}", strABResFullPath);
            if (!Directory.Exists(strABResFullPath)) {
                NBsn.CGlobal.Instance.Log.InfoFormat("not found dir strABResFullPath={0}", strABResFullPath);
                goto Exit0;
            }

            int basePathLength = Application.dataPath.Length - 6; // F:/github/bsn/u3d/Assets /Assets=6
            var dirInfo = new DirectoryInfo(strABResFullPath);
            var files = dirInfo.GetFiles("*", SearchOption.AllDirectories);
            for (var i = 0; i < files.Length; ++i) {
                var fileInfo = files[i];
                var strFileFullPath = fileInfo.FullName;
                EditorUtility.DisplayProgressBar("设置AssetName名称", "正在设置AssetName名称中...", 1f * i / files.Length);
                if (strFileFullPath.EndsWith(".meta")) {
                    continue;
                }
                strFileFullPath = NBsn.Utils.FormatPathSplitChar(strFileFullPath);

                NBsn.CGlobal.Instance.Log.InfoFormat(
                    "strFileFullPath={0}"
                    , strFileFullPath
                    );
                var basePath = strFileFullPath.Substring(basePathLength);
                var importer = AssetImporter.GetAtPath(basePath);
                if (importer == null) {
                    NBsn.CGlobal.Instance.Log.InfoFormat("basePath={0} importer == null", basePath);
                    goto Exit0;
                }
                NBsn.CGlobal.Instance.Log.InfoFormat("basePath={0}", basePath);
                importer.assetBundleName = basePath + strABsuffix;
            }

        Exit0:
            EditorUtility.ClearProgressBar();
            return true;
        }

        public static void MakeAB(BuildTarget buildTarget) {
            NBsn.CGlobal.Instance.Log.InfoFormat("NBsn.CMenuAB.MakeAB({0})", buildTarget); 

            string strPlatform = NBsn.CPlatform.Name(buildTarget);
            NBsn.CGlobal.Instance.ConfigInit(strPlatform);
            
            var strOutFullPath = string.Format("{0}/{1}"
               , Application.dataPath
               , NBsn.CGlobal.Instance.PathConfig.PlatformABPath
            );
            NBsn.CGlobal.Instance.Log.InfoFormat("strOutFullPath={0}", strOutFullPath);
            Directory.CreateDirectory(strOutFullPath);

		    AssetDatabase.Refresh();
            BuildPipeline.BuildAssetBundles(strOutFullPath, BuildAssetBundleOptions.UncompressedAssetBundle, buildTarget);
		    AssetDatabase.Refresh();
        } 

        // public static string GetOutFullPath(BuildTarget buildTarget) {
        //     NBsn.CGlobal.Instance.Log.InfoFormat(
        //         "NBsnEditor.CAssetBuddleBuilder.GetOutFullPath({0})"
        //         , buildTarget
        //     ); 
            
        //     string strPlatform = NBsnEditor.CConfig.GetPlatformName(buildTarget);
        //     NBsn.CGlobal.Instance.InitConfig(strPlatform);
            
        //     var strOutFullPath = string.Format("{0}/{1}"
        //        , Application.dataPath
        //        ,NBsn.Global.ms_strPlatformABPath
        //     );
        //     Debug.LogFormat("strOutFullPath={0}", strOutFullPath);
        //     Directory.CreateDirectory(strOutFullPath);
        //     return strOutFullPath;
        //     return null;
        // }

        // strABResRelativeDir "ABRes" relative
        // strABsuffix ".ab"
        // public static bool SetAssertName(string strABResDir, string strABsuffix) {
        //     Debug.LogFormat("SetAssertName strABResDir={0} strABsuffix={1}", strABResDir, strABsuffix);
        //     EditorUtility.DisplayProgressBar("设置AssetName名称", "正在设置AssetName名称中...", 0f);
            
        //     var strABResFullPath = Path.Combine(Application.dataPath, strABResDir);
        //     Debug.LogFormat("strABResFullPath={0}", strABResFullPath);
        //     if (!Directory.Exists(strABResFullPath)) {
        //         Debug.LogErrorFormat("not found dir strABResFullPath={0}", strABResFullPath);
        //         goto Exit0;
        //     }

        //     int basePathLength = Application.dataPath.Length - 6; // F:/github/bsn/u3d/Assets /Assets=6
        //     var dirInfo = new DirectoryInfo(strABResFullPath);
        //     var files = dirInfo.GetFiles("*", SearchOption.AllDirectories);
        //     for (var i = 0; i < files.Length; ++i) {
        //         var fileInfo = files[i];
        //         var strFileFullPath = fileInfo.FullName;
        //         EditorUtility.DisplayProgressBar("设置AssetName名称", "正在设置AssetName名称中...", 1f * i / files.Length);
        //         if (strFileFullPath.EndsWith(".meta")) {
        //             continue;
        //         }

        //         Debug.LogFormat("strFileFullPath={0}", strFileFullPath);
        //         var basePath = strFileFullPath.Substring(basePathLength);
        //         var importer = AssetImporter.GetAtPath(basePath);
        //         if (importer == null) {
        //             Debug.LogErrorFormat("basePath={0} importer == null", basePath);
        //             goto Exit0;
        //         }
        //         importer.assetBundleName = basePath + strABsuffix;
        //     }

        // Exit0:
        //     EditorUtility.ClearProgressBar();
        //     return true;
        // }

        // public static void U5AB(BuildTarget buildTarget) {
        //     Debug.Log("NBsnEditor.AssetBuddleBuilder.U5AB()");
        //     string strOutFullPath = GetOutFullPath(buildTarget);
        //     if (strOutFullPath == null) {
        //         Debug.LogError("strOutFullPath == null");
        //         return;
        //     }

		//     AssetDatabase.Refresh();
        //     BuildPipeline.BuildAssetBundles(strOutFullPath);
        // }        
        // public static void One(BuildTarget buildTarget) {
        //     Debug.Log("NBsnEditor.AssetBuddleBuilder.One()");
        //     string outPathName = GetOutFullPath(buildTarget);
        //     if (outPathName == null) {
        //         Debug.LogError("outPathName=null");
        //         return;
        //     }

        //     //获取在Project视图中选择的所有游戏对象
		//     Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
 
        //     //遍历所有的游戏对象
		//     foreach (Object obj in SelectedAsset) {
        //         string sourcePath = AssetDatabase.GetAssetPath (obj);
		// 	    string targetPath = Path.Combine(outPathName, obj.name) + ".assetbundle";
        //         Debug.LogFormat("{0} {2}->{1}", obj.name, targetPath, sourcePath);
		// 	    if (BuildPipeline.BuildAssetBundle(obj, null, targetPath, BuildAssetBundleOptions.CollectDependencies, buildTarget)) {
 		// 		    Debug.Log("资源打包成功");
		// 	    }
		//     }
		//     //刷新编辑器
		//     AssetDatabase.Refresh ();	
        // }

        // public static void All(BuildTarget buildTarget) {
        //     Debug.Log("NBsnEditor.AssetBuddleBuilder.All()");
        //     string outPathName = GetOutFullPath(buildTarget);
        //     if (outPathName == null) {
        //         Debug.LogError("outPathName=null");
        //         return;
        //     }

        //     string targetPath = Path.Combine(outPathName, "all") + ".assetbundle";
        //     Debug.LogFormat("targetPath={0}", targetPath);

        //     //获取在Project视图中选择的所有游戏对象
		//     Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
        //     foreach (Object obj in SelectedAsset) {
        //         string sourcePath = AssetDatabase.GetAssetPath (obj);
        //         Debug.LogFormat("{0} {1}", obj.name, sourcePath);
		//     }
 
		//     if (BuildPipeline.BuildAssetBundle(null, SelectedAsset, targetPath, BuildAssetBundleOptions.CollectDependencies, buildTarget)) {
 		// 		Debug.Log("资源打包成功");
		// 	}
		//     //刷新编辑器
		//     AssetDatabase.Refresh ();	
        // }

        // public static void Scene(BuildTarget buildTarget) {
        //     Debug.Log("NBsnEditor.AssetBuddleBuilder.Scene()");
        //     string outPathName = GetOutFullPath(buildTarget);
        //     if (outPathName == null) {
        //         Debug.LogError("outPathName=null");
        //         return;
        //     }

        //     //获取在Project视图中选择的所有游戏对象
		//     Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
        //     foreach (Object obj in SelectedAsset) {
        //         string sourcePath = AssetDatabase.GetAssetPath (obj);
        //         string targetPath = Path.Combine(outPathName, obj.name) + ".unity3d";
        //         Debug.LogFormat("{2} {0}->{1}", sourcePath, targetPath, obj.name);

        //         string  []levels = {sourcePath};
        //         BuildPipeline.BuildPlayer(levels, targetPath, buildTarget, BuildOptions.BuildAdditionalStreamedScenes);

		//     }
 
		//     //刷新编辑器
		//     AssetDatabase.Refresh ();	
        // }
    }
}
