﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_CollisionDetectionModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.CollisionDetectionMode));
		L.RegVar("Discrete", get_Discrete, null);
		L.RegVar("Continuous", get_Continuous, null);
		L.RegVar("ContinuousDynamic", get_ContinuousDynamic, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Discrete(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.CollisionDetectionMode.Discrete);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Continuous(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.CollisionDetectionMode.Continuous);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ContinuousDynamic(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.CollisionDetectionMode.ContinuousDynamic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.CollisionDetectionMode o = (UnityEngine.CollisionDetectionMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

