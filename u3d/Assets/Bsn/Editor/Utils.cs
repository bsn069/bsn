using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NBsnEditor {
    public static class Utils  {
        // http://www.xuanyusong.com/archives/4207 查找资源被哪里引用了
        [MenuItem("Bsn/Assets/Find References", false, 1)]
        static private void FindReferences() {
            using(NBsn.CTimer timer = new NBsn.CTimer("FindReferences")) {
                FindReferencesImp();
            }
        }

        static private void FindReferencesImp() {
            EditorSettings.serializationMode = SerializationMode.ForceText;
            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (string.IsNullOrEmpty(path)) {
                return;
            }
            string guid = AssetDatabase.AssetPathToGUID(path);
            Debug.LogFormat("path={0}, guid={1}", path, guid);

            var withinExtensions = new List<string>(){".prefab",".unity",".mat",".asset"};
            string[] files = Directory.GetFiles(Application.dataPath, "*.*", SearchOption.AllDirectories)
                .Where(s => withinExtensions.Contains(Path.GetExtension(s).ToLower())).ToArray();
            
            int startIndex = 0;    
            EditorApplication.update = delegate() {
                string file = files[startIndex];
                bool isCancel = EditorUtility.DisplayCancelableProgressBar("匹配资源中", file, (float)startIndex / (float)files.Length);
    
                if (Regex.IsMatch(File.ReadAllText(file), guid)) {
                    Debug.Log(NBsn.Utils.GetRelativeAssetsPath(file));
                }
    
                startIndex++;
                if (isCancel || startIndex >= files.Length) {
                    EditorUtility.ClearProgressBar();
                    EditorApplication.update = null;
                    startIndex = 0;
                    Debug.Log("匹配结束");
                }
            };
        }
    }
}
