﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_Image_Origin360Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.UI.Image.Origin360));
		L.RegVar("Bottom", get_Bottom, null);
		L.RegVar("Right", get_Right, null);
		L.RegVar("Top", get_Top, null);
		L.RegVar("Left", get_Left, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Bottom(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin360.Bottom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Right(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin360.Right);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Top(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin360.Top);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Left(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.Image.Origin360.Left);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.UI.Image.Origin360 o = (UnityEngine.UI.Image.Origin360)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

