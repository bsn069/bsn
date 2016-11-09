﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Rendering_LightEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.Rendering.LightEvent));
		L.RegVar("BeforeShadowMap", get_BeforeShadowMap, null);
		L.RegVar("AfterShadowMap", get_AfterShadowMap, null);
		L.RegVar("BeforeScreenspaceMask", get_BeforeScreenspaceMask, null);
		L.RegVar("AfterScreenspaceMask", get_AfterScreenspaceMask, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BeforeShadowMap(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.LightEvent.BeforeShadowMap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AfterShadowMap(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.LightEvent.AfterShadowMap);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BeforeScreenspaceMask(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.LightEvent.BeforeScreenspaceMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AfterScreenspaceMask(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Rendering.LightEvent.AfterScreenspaceMask);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.Rendering.LightEvent o = (UnityEngine.Rendering.LightEvent)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

