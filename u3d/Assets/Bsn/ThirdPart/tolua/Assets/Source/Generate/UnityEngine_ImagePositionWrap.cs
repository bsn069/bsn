﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ImagePositionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.ImagePosition));
		L.RegVar("ImageLeft", get_ImageLeft, null);
		L.RegVar("ImageAbove", get_ImageAbove, null);
		L.RegVar("ImageOnly", get_ImageOnly, null);
		L.RegVar("TextOnly", get_TextOnly, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ImageLeft(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ImagePosition.ImageLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ImageAbove(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ImagePosition.ImageAbove);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ImageOnly(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ImagePosition.ImageOnly);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TextOnly(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ImagePosition.TextOnly);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.ImagePosition o = (UnityEngine.ImagePosition)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

