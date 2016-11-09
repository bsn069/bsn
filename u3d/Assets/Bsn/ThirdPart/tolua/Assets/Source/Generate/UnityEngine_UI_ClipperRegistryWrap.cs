﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_ClipperRegistryWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.ClipperRegistry), typeof(System.Object));
		L.RegFunction("Cull", Cull);
		L.RegFunction("Register", _Register);
		L.RegFunction("Unregister", Unregister);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("instance", get_instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Cull(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.ClipperRegistry obj = (UnityEngine.UI.ClipperRegistry)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.ClipperRegistry));
			obj.Cull();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Register(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.IClipper arg0 = (UnityEngine.UI.IClipper)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.IClipper));
			UnityEngine.UI.ClipperRegistry.Register(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unregister(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.IClipper arg0 = (UnityEngine.UI.IClipper)ToLua.CheckObject(L, 1, typeof(UnityEngine.UI.IClipper));
			UnityEngine.UI.ClipperRegistry.Unregister(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, UnityEngine.UI.ClipperRegistry.instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

