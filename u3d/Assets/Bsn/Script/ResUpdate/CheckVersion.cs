using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace NBsn {

    //[Reg2LuaAttribute]
    public class CCheckVersion {

        private string GetLocalVersion()  {
            return null;
        }

        private string ReqVersion()  {
            return null;
        }


        private IEnumerator CoroutineReqVersion() {
            NBsn.Config.GetServerResUrl(1);

            yield return null; 
        }
    }
}