﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ParticleSystemRenderModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.ParticleSystemRenderMode));
		L.RegVar("Billboard", get_Billboard, null);
		L.RegVar("Stretch", get_Stretch, null);
		L.RegVar("HorizontalBillboard", get_HorizontalBillboard, null);
		L.RegVar("VerticalBillboard", get_VerticalBillboard, null);
		L.RegVar("Mesh", get_Mesh, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Billboard(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ParticleSystemRenderMode.Billboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Stretch(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ParticleSystemRenderMode.Stretch);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_HorizontalBillboard(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ParticleSystemRenderMode.HorizontalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_VerticalBillboard(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ParticleSystemRenderMode.VerticalBillboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Mesh(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.ParticleSystemRenderMode.Mesh);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.ParticleSystemRenderMode o = (UnityEngine.ParticleSystemRenderMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

