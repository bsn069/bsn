﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ParticleSystem_SizeOverLifetimeModuleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.ParticleSystem.SizeOverLifetimeModule), null);
		L.RegFunction("New", _CreateUnityEngine_ParticleSystem_SizeOverLifetimeModule);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("enabled", get_enabled, set_enabled);
		L.RegVar("size", get_size, set_size);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_ParticleSystem_SizeOverLifetimeModule(IntPtr L)
	{
		UnityEngine.ParticleSystem.SizeOverLifetimeModule obj = new UnityEngine.ParticleSystem.SizeOverLifetimeModule();
		ToLua.PushValue(L, obj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.SizeOverLifetimeModule obj = (UnityEngine.ParticleSystem.SizeOverLifetimeModule)o;
			bool ret = obj.enabled;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_size(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.SizeOverLifetimeModule obj = (UnityEngine.ParticleSystem.SizeOverLifetimeModule)o;
			UnityEngine.ParticleSystem.MinMaxCurve ret = obj.size;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index size on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.SizeOverLifetimeModule obj = (UnityEngine.ParticleSystem.SizeOverLifetimeModule)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.enabled = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index enabled on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_size(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.SizeOverLifetimeModule obj = (UnityEngine.ParticleSystem.SizeOverLifetimeModule)o;
			UnityEngine.ParticleSystem.MinMaxCurve arg0 = (UnityEngine.ParticleSystem.MinMaxCurve)ToLua.CheckObject(L, 2, typeof(UnityEngine.ParticleSystem.MinMaxCurve));
			obj.size = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index size on a nil value" : e.Message);
		}
	}
}

