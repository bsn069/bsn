﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_FocusTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.FocusType));
		L.RegVar("Native", get_Native, null);
		L.RegVar("Keyboard", get_Keyboard, null);
		L.RegVar("Passive", get_Passive, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Native(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.FocusType.Native);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Keyboard(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.FocusType.Keyboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Passive(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.FocusType.Passive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.FocusType o = (UnityEngine.FocusType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

