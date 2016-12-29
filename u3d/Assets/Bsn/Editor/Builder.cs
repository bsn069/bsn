using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace NBsnEditor {
    public static class Builder  {
        public static void Bsn_Build(BuildTarget buildTarget) {
            Debug.Log("NBsnEditor.Builder.Bsn_Build()");
            string[] buildScenePaths = new string[]{
                "Assets/Bsn/Scene/bsn_main.unity",
            };
            Builder.Build(buildTarget, buildScenePaths);
        }

        public static bool Build(BuildTarget buildTarget, string[] sceneList) {
            if (sceneList == null) {
                Debug.LogError("sceneList == null");
                return false;
            }
            if (sceneList.Length == 0) {
                Debug.LogError("sceneList.Length == 0");
                return false;
            }

            for (int i = 0; i < sceneList.Length; i++) {
                Debug.Log(sceneList[i]);
            }

            string extName = "";
            string outDir = "";
            switch (buildTarget) {
                case BuildTarget.Android: {
                        extName = ".apk";
                        outDir = "./Out";
                    } 
                    break;               
                case BuildTarget.StandaloneWindows: {
                        extName = ".exe";
                        outDir = "./Out/Win32";
                    }
                    break;
                case BuildTarget.StandaloneWindows64: {
                        extName = ".exe";
                        outDir = "./Out/Win64";
                    }
                    break;              
                default: {
                        Debug.LogErrorFormat("unknown buildTarget={0}", buildTarget);
                        return false;
                    }
            }
            string outPathName = string.Format("{0}/{1}{2}", outDir, "bsn", extName);
            Debug.LogFormat("outPathName={0}", outPathName);

            EditorUserBuildSettings.SwitchActiveBuildTarget(buildTarget);
            BuildPipeline.BuildPlayer(sceneList, outPathName, buildTarget, BuildOptions.None);
            return true;
        }
    }
}
