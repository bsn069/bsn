using UnityEngine;
using LuaInterface;
using System;
using System.Collections.Generic;

namespace NBsn {
    //[Reg2LuaAttribute]
    public static class Config {
        // AB存放相对Assets目录格式化
        // {0} strPlatform[Win, Android]
        public static string PlatformABPathFormat {
            get { return "ABOut/{0}/AB"; }
        }

        // 资源加载类型
        public static NBsn.EResLoadType ResLoadType {
            get { return ms_eResLoadType; }
            set { ms_eResLoadType = value; }
        }

        // 服务器资源根目录http://172.18.100.47:10000/static/u3d/
        public static string GetServerResUrl() {
            var uIndex = ms_uServerUrlIndex % (uint)ms_strServerResUrl.Length;
            return ms_strServerResUrl[uIndex];
        }

        public bool ToNextServerResUrl() {

        }

        // 服务器资源 下载到本地的根目录名
        public static string ServerResLocalDirName {
            get { return "ServerRes"; }
        }


        private static NBsn.EResLoadType ms_eResLoadType = NBsn.EResLoadType.EditorABOut;
        private static string[] ms_strServerResUrl = new string[] {
            "http://172.18.100.47:10000/static/u3d/",
        };
        private static uint ms_uServerUrlIndex = 0;

        //public static int   ms_nFPS      = 30;  
        ////在这里添加你要导出注册到lua的类型列表
        //public static List<Type> m_reg2LuaType = new List<Type>{
        //};
        ////导出时强制做为静态类的类型(注意m_reg2LuaType 还要添加这个类型才能导出)
        ////unity 有些类作为sealed class, 其实完全等价于静态类
        //public static List<Type> m_reg2LuaStaticType = new List<Type>{
        //};
    }
}