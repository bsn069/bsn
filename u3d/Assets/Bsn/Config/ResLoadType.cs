using UnityEngine;
using LuaInterface;
using System;
using System.Collections.Generic;

namespace NBsn {
    // 资源加载类型
    // [Reg2LuaAttribute]
    public enum EResLoadType {
        // 编辑器模式的 资源(非AB)存放目录
        EditorABRes = 1,
        // 编辑器模式的 AB存放目录
        EditorABOut = 2,
        // app的 AB存放目录
        AppAB = 3,
    }
}