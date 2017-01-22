using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class CCoroutine {
        //public static Coroutine StartCoroutine(IEnumerator iEnumerator) {
        //    if (Global.ms_Main == null) {
        //        Debug.LogErrorFormat("NBsn.Global.ms_Main == null"); 
        //        return null;
        //    }
        //    return Global.ms_Main.StartCoroutine(iEnumerator);
        //}

        //public static void StopCoroutine(Coroutine coroutine) {
        //    if (Global.ms_Main == null) {
        //        Debug.LogErrorFormat("NBsn.Global.ms_Main == null"); 
        //        return;
        //    }
        //    Global.ms_Main.StopCoroutine(coroutine);
        //}
    }
}