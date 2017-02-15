using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn.NToLua {
    //[Reg2LuaAttribute]
    public class CConfig {
        public string LuaLocalFullPath {
            get { return m_strLuaLocalFullPath; }
        }

        public string ToLuaLocalFullPath {
            get { return m_strToLuaLocalFullPath; }
        }

        #region
        public CConfig() {

        }

        protected string    m_strLuaLocalFullPath = null;
        protected string    m_strToLuaLocalFullPath = null;
        #endregion

        public void Init() {
            NBsn.CGlobal.Instance.Log.Info("NBsn.NToLua.Init()"); 

            if (NBsn.Config.ResLoadType == NBsn.EResLoadType.AppAB) {
                m_strLuaLocalFullPath      = NBsn.CGlobal.Instance.PathConfig.ResLocalFullPath + "Lua";
                m_strToLuaLocalFullPath    = NBsn.CGlobal.Instance.PathConfig.ResLocalFullPath + "ToLua";  
            }
            else {
                m_strLuaLocalFullPath      = NBsn.CGlobal.Instance.PathConfig.ResLocalFullPath + "Lua";
                m_strToLuaLocalFullPath    = NBsn.CGlobal.Instance.PathConfig.ResLocalFullPath + "Bsn/ThirdPart/tolua/Assets/ToLua/Lua";  
            }

            NBsn.CGlobal.Instance.Log.InfoFormat("LuaLocalFullPath={0}", LuaLocalFullPath);
            NBsn.CGlobal.Instance.Log.InfoFormat("ToLuaLocalFullPath={0}", ToLuaLocalFullPath);

            LuaConst.osDir      = NBsn.CGlobal.Instance.PlatformName;
            LuaConst.luaDir     = LuaLocalFullPath;
            LuaConst.toluaDir   = ToLuaLocalFullPath;
            LuaConst.luaResDir  = LuaLocalFullPath;
            NBsn.CGlobal.Instance.Log.InfoFormat("LuaConst.osDir={0}", LuaConst.osDir);
            NBsn.CGlobal.Instance.Log.InfoFormat("LuaConst.luaDir={0}", LuaConst.luaDir);
            NBsn.CGlobal.Instance.Log.InfoFormat("LuaConst.toluaDir={0}", LuaConst.toluaDir);
            NBsn.CGlobal.Instance.Log.InfoFormat("LuaConst.luaResDir={0}", LuaConst.luaResDir);
        }
    }
}