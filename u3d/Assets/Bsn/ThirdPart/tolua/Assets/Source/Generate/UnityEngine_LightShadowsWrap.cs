﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_LightShadowsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.LightShadows));
		L.RegVar("None", get_None, null);
		L.RegVar("Hard", get_Hard, null);
		L.RegVar("Soft", get_Soft, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightShadows.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Hard(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightShadows.Hard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Soft(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightShadows.Soft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.LightShadows o = (UnityEngine.LightShadows)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

