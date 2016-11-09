﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ColorUtilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.ColorUtility), typeof(System.Object));
		L.RegFunction("TryParseHtmlString", TryParseHtmlString);
		L.RegFunction("ToHtmlStringRGB", ToHtmlStringRGB);
		L.RegFunction("ToHtmlStringRGBA", ToHtmlStringRGBA);
		L.RegFunction("New", _CreateUnityEngine_ColorUtility);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_ColorUtility(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.ColorUtility obj = new UnityEngine.ColorUtility();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.ColorUtility.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TryParseHtmlString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Color arg1;
			bool o = UnityEngine.ColorUtility.TryParseHtmlString(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg1);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToHtmlStringRGB(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
			string o = UnityEngine.ColorUtility.ToHtmlStringRGB(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToHtmlStringRGBA(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
			string o = UnityEngine.ColorUtility.ToHtmlStringRGBA(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

