using UnityEngine;
using LuaInterface;
using System.IO;
using System.Text;

namespace NBsn {
    public class LuaReadFile : LuaInterface.LuaFileUtils {
        public LuaReadFile() {
            instance = this;
            beZip = false;
            Debug.LogFormat("Application.persistentDataPath={0}", Application.persistentDataPath);
            Debug.LogFormat("Application.dataPath={0}", Application.dataPath);
            Debug.LogFormat("Application.streamingAssetsPath={0}", Application.streamingAssetsPath);
            Debug.LogFormat("Application.temporaryCachePath={0}", Application.temporaryCachePath);
        }

        /*
         * lua require  
         * LuaState.DoFile
         */
        public override byte[] ReadFile(string fileName)
        {
            return base.ReadFile(fileName);
        }

        public override string FindFileError(string fileName) {
            return base.FindFileError(fileName);
        }
    }
}
