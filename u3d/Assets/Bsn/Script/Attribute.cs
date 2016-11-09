using UnityEngine;
using System.Collections;
using LuaInterface;
using System.Runtime.InteropServices;
using System;

namespace NBsn {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class Reg2LuaAttribute : System.Attribute {
        public Reg2LuaAttribute() {
		}
	}

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class NotReg2LuaAttribute : System.Attribute {
        public NotReg2LuaAttribute() {
		}
	}
}