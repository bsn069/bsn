using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

namespace NBsnEditor {
    public static class CConfig  {

        public static string GetPlatformName(BuildTarget buildTarget) {
            Debug.LogFormat("NBsnEditor.CConfig.GetPlatformName({0})", buildTarget);
            string strPlatform = "";
            switch (buildTarget) {
                case BuildTarget.Android: {
                        strPlatform = "Android";
                    } 
                    break;               
                case BuildTarget.StandaloneWindows:
                case BuildTarget.StandaloneWindows64: {
                        strPlatform = "Win";
                    }
                    break;              
                default: {
                        Debug.LogErrorFormat("unknown buildTarget={0}", buildTarget);
                        return null;
                    }
            }

            return strPlatform;
        }
    }
}