﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ParticleSystem_ExternalForcesModuleWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.ParticleSystem.ExternalForcesModule), null);
		L.RegFunction("New", _CreateUnityEngine_ParticleSystem_ExternalForcesModule);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("enabled", get_enabled, set_enabled);
		L.RegVar("multiplier", get_multiplier, set_multiplier);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_ParticleSystem_ExternalForcesModule(IntPtr L)
	{
		UnityEngine.ParticleSystem.ExternalForcesModule obj = new UnityEngine.ParticleSystem.ExternalForcesModule();
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
			UnityEngine.ParticleSystem.ExternalForcesModule obj = (UnityEngine.ParticleSystem.ExternalForcesModule)o;
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
	static int get_multiplier(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.ExternalForcesModule obj = (UnityEngine.ParticleSystem.ExternalForcesModule)o;
			float ret = obj.multiplier;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index multiplier on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enabled(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.ExternalForcesModule obj = (UnityEngine.ParticleSystem.ExternalForcesModule)o;
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
	static int set_multiplier(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem.ExternalForcesModule obj = (UnityEngine.ParticleSystem.ExternalForcesModule)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.multiplier = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index multiplier on a nil value" : e.Message);
		}
	}
}

