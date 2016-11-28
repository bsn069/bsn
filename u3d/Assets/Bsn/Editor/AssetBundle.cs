using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

namespace NBsnEditor {
    public static class AssetBuddleBuilder  {
        public static string GetOutPath(BuildTarget buildTarget) {
            Debug.LogFormat("NBsnEditor.AssetBuddleBuilder.GetOutPath({0})", buildTarget);
            string outDir = "";
            switch (buildTarget) {
                case BuildTarget.Android: {
                        outDir = "Android";
                    } 
                    break;               
                case BuildTarget.StandaloneWindows: {
                        outDir = "Win32";
                    }
                    break;
                case BuildTarget.StandaloneWindows64: {
                        outDir = "Win64";
                    }
                    break;              
                default: {
                        Debug.LogErrorFormat("unknown buildTarget={0}", buildTarget);
                        return null;
                    }
            }

            string outPathName = string.Format("{0}/../AssertBundle/{1}", Application.dataPath, outDir);
            outPathName = Path.GetFullPath(outPathName);
            Debug.LogFormat("outPathName={0}", outPathName);
            Directory.CreateDirectory(outPathName);
            return outPathName;
        }

        public static void One(BuildTarget buildTarget) {
            Debug.Log("NBsnEditor.AssetBuddleBuilder.One()");
            string outPathName = GetOutPath(buildTarget);
            if (outPathName == null) {
                Debug.LogError("outPathName=null");
                return;
            }

            //获取在Project视图中选择的所有游戏对象
		    Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
 
            //遍历所有的游戏对象
		    foreach (Object obj in SelectedAsset) {
                string sourcePath = AssetDatabase.GetAssetPath (obj);
			    string targetPath = Path.Combine(outPathName, obj.name) + ".assetbundle";
                Debug.LogFormat("{0} {2}->{1}", obj.name, targetPath, sourcePath);
			    if (BuildPipeline.BuildAssetBundle(obj, null, targetPath, BuildAssetBundleOptions.CollectDependencies, buildTarget)) {
 				    Debug.Log("资源打包成功");
			    }
		    }
		    //刷新编辑器
		    AssetDatabase.Refresh ();	
        }

        public static void All(BuildTarget buildTarget) {
            Debug.Log("NBsnEditor.AssetBuddleBuilder.All()");
            string outPathName = GetOutPath(buildTarget);
            if (outPathName == null) {
                Debug.LogError("outPathName=null");
                return;
            }

            string targetPath = Path.Combine(outPathName, "all") + ".assetbundle";
            Debug.LogFormat("targetPath={0}", targetPath);

            //获取在Project视图中选择的所有游戏对象
		    Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
            foreach (Object obj in SelectedAsset) {
                string sourcePath = AssetDatabase.GetAssetPath (obj);
                Debug.LogFormat("{0} {1}", obj.name, sourcePath);
		    }
 
		    if (BuildPipeline.BuildAssetBundle(null, SelectedAsset, targetPath, BuildAssetBundleOptions.CollectDependencies, buildTarget)) {
 				Debug.Log("资源打包成功");
			}
		    //刷新编辑器
		    AssetDatabase.Refresh ();	
        }

         public static void Scene(BuildTarget buildTarget) {
            Debug.Log("NBsnEditor.AssetBuddleBuilder.Scene()");
            string outPathName = GetOutPath(buildTarget);
            if (outPathName == null) {
                Debug.LogError("outPathName=null");
                return;
            }

            //获取在Project视图中选择的所有游戏对象
		    Object[] SelectedAsset = Selection.GetFiltered (typeof(Object), SelectionMode.DeepAssets);
            foreach (Object obj in SelectedAsset) {
                string sourcePath = AssetDatabase.GetAssetPath (obj);
                string targetPath = Path.Combine(outPathName, obj.name) + ".unity3d";
                Debug.LogFormat("{2} {0}->{1}", sourcePath, targetPath, obj.name);

                string  []levels = {sourcePath};
                BuildPipeline.BuildPlayer(levels, targetPath, buildTarget, BuildOptions.BuildAdditionalStreamedScenes);

		    }
 
		    //刷新编辑器
		    AssetDatabase.Refresh ();	
        }
    }
}
