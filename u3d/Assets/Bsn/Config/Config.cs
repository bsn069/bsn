using UnityEngine;
using LuaInterface;
using System;
using System.Collections.Generic;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class Config {
        //lua逻辑代码目录
        public static string m_strLuaDir = Application.dataPath + "/Lua";

        //在这里添加你要导出注册到lua的类型列表
        public static List<Type> m_reg2LuaType = new List<Type>{
        };

        //导出时强制做为静态类的类型(注意m_reg2LuaType 还要添加这个类型才能导出)
        //unity 有些类作为sealed class, 其实完全等价于静态类
        public static List<Type> m_reg2LuaStaticType = new List<Type>{
        };
    }
}