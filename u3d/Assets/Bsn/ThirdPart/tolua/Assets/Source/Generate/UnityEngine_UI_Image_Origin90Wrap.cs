﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_Image_Origin90Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.UI.Image.Origin90));
		L.RegVar("BottomLeft", get_BottomLeft, null);
		L.RegVar("TopLeft", get_TopLeft, null);
		L.RegVar("TopRight", get_TopRight, null);
		L.RegVar("BottomRight", get_BottomRight, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BottomLeft(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin90.BottomLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TopLeft(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin90.TopLeft);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TopRight(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin90.TopRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BottomRight(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin90.BottomRight);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.UI.Image.Origin90 o = (UnityEngine.UI.Image.Origin90)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

