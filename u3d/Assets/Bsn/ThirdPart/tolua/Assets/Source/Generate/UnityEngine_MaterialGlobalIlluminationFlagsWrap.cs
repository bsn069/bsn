﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_MaterialGlobalIlluminationFlagsWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.MaterialGlobalIlluminationFlags));
		L.RegVar("None", get_None, null);
		L.RegVar("RealtimeEmissive", get_RealtimeEmissive, null);
		L.RegVar("BakedEmissive", get_BakedEmissive, null);
		L.RegVar("EmissiveIsBlack", get_EmissiveIsBlack, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_None(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.MaterialGlobalIlluminationFlags.None);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RealtimeEmissive(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.MaterialGlobalIlluminationFlags.RealtimeEmissive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BakedEmissive(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.MaterialGlobalIlluminationFlags.BakedEmissive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EmissiveIsBlack(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.MaterialGlobalIlluminationFlags.EmissiveIsBlack);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.MaterialGlobalIlluminationFlags o = (UnityEngine.MaterialGlobalIlluminationFlags)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

