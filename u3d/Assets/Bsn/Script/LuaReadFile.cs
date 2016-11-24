using UnityEngine;
using LuaInterface;
using System.IO;
using System.Text;

namespace NBsn {
    public class LuaReadFile : LuaInterface.LuaFileUtils {
        public LuaReadFile() {
            instance = this;
            beZip = false;
        }

        /*
         * lua require  
         * LuaState.DoFile
         */
        public override byte[] ReadFile(string fileName) {
            Debug.LogFormat("LuaReadFile.ReadFile({0})", fileName);
            return base.ReadFile(fileName);
        }

        public override string FindFileError(string fileName) {
            Debug.LogFormat("LuaReadFile.FindFileError({0})", fileName);
            return base.FindFileError(fileName);
        }

        public void ClearSearchPath() {
            searchPaths.Clear();
        }

        public void ShowAll() {
            Debug.Log("LuaReadFile.ShowAll");
            for (int i = 0; i < searchPaths.Count; i++) {
                Debug.LogFormat("{0}={1}", i, searchPaths[i]);
            }
        }
    }
}
