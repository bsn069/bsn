﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_GraphicRegistryWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.GraphicRegistry), typeof(System.Object));
		L.RegFunction("RegisterGraphicForCanvas", RegisterGraphicForCanvas);
		L.RegFunction("UnregisterGraphicForCanvas", UnregisterGraphicForCanvas);
		L.RegFunction("GetGraphicsForCanvas", GetGraphicsForCanvas);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("instance", get_instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RegisterGraphicForCanvas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Canvas arg0 = (UnityEngine.Canvas)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Canvas));
			UnityEngine.UI.Graphic arg1 = (UnityEngine.UI.Graphic)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Graphic));
			UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnregisterGraphicForCanvas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Canvas arg0 = (UnityEngine.Canvas)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Canvas));
			UnityEngine.UI.Graphic arg1 = (UnityEngine.UI.Graphic)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Graphic));
			UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGraphicsForCanvas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Canvas arg0 = (UnityEngine.Canvas)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Canvas));
			System.Collections.Generic.IList<UnityEngine.UI.Graphic> o = UnityEngine.UI.GraphicRegistry.GetGraphicsForCanvas(arg0);
			ToLua.PushObject(L, o);
			return 1;
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
			ToLua.PushObject(L, UnityEngine.UI.GraphicRegistry.instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

