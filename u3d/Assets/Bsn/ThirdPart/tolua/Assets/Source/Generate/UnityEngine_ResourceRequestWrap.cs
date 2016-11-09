﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ResourceRequestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.ResourceRequest), typeof(UnityEngine.AsyncOperation));
		L.RegFunction("New", _CreateUnityEngine_ResourceRequest);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("asset", get_asset, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_ResourceRequest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.ResourceRequest obj = new UnityEngine.ResourceRequest();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.ResourceRequest.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_asset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ResourceRequest obj = (UnityEngine.ResourceRequest)o;
			UnityEngine.Object ret = obj.asset;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index asset on a nil value" : e.Message);
		}
	}
}

