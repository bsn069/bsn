using UnityEngine;
using LuaInterface;
using System;
using System.Collections.Generic;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class Config {
        // 编辑器模式
        public static bool ms_bEditorMode = true;
        // 应用名称
        public static string ms_appName = "bsn";
        // 
        public static int   ms_nFPS      = 30;  

        //在这里添加你要导出注册到lua的类型列表
        public static List<Type> m_reg2LuaType = new List<Type>{
        };

        //导出时强制做为静态类的类型(注意m_reg2LuaType 还要添加这个类型才能导出)
        //unity 有些类作为sealed class, 其实完全等价于静态类
        public static List<Type> m_reg2LuaStaticType = new List<Type>{
        };
    }
}