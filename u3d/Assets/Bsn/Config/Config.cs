using UnityEngine;
using LuaInterface;
using System;
using System.Collections.Generic;

namespace NBsn {
    [Reg2LuaAttribute]
    public static class Config {
        // 编辑器模式
        public static bool ms_bEditorMode = true; // 废除
        // 应用名称
        public static string ms_appName = "bsn"; // 废除
        // 
        public static int   ms_nFPS      = 30;  
        // 是否使用服务器资源
        // 非编辑器模式下 总为true
        public static bool ms_bUseServerRes = true;
        // 服务器资源根目录http://172.18.100.47:10000/static/u3d/
        public static string ms_strServerResUrl = "http://172.18.100.47:10000/static/u3d/";
        // 服务器资源 下载到本地的目录名
        public static string ms_strServerResLocalDirName = "ServerRes";

        //在这里添加你要导出注册到lua的类型列表
        public static List<Type> m_reg2LuaType = new List<Type>{
        };

        //导出时强制做为静态类的类型(注意m_reg2LuaType 还要添加这个类型才能导出)
        //unity 有些类作为sealed class, 其实完全等价于静态类
        public static List<Type> m_reg2LuaStaticType = new List<Type>{
        };
    }
}