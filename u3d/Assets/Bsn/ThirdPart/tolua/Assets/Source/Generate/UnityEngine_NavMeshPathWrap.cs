﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_NavMeshPathWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.NavMeshPath), typeof(System.Object));
		L.RegFunction("GetCornersNonAlloc", GetCornersNonAlloc);
		L.RegFunction("ClearCorners", ClearCorners);
		L.RegFunction("New", _CreateUnityEngine_NavMeshPath);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("corners", get_corners, null);
		L.RegVar("status", get_status, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_NavMeshPath(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.NavMeshPath obj = new UnityEngine.NavMeshPath();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.NavMeshPath.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCornersNonAlloc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.NavMeshPath obj = (UnityEngine.NavMeshPath)ToLua.CheckObject(L, 1, typeof(UnityEngine.NavMeshPath));
			UnityEngine.Vector3[] arg0 = ToLua.CheckObjectArray<UnityEngine.Vector3>(L, 2);
			int o = obj.GetCornersNonAlloc(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearCorners(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NavMeshPath obj = (UnityEngine.NavMeshPath)ToLua.CheckObject(L, 1, typeof(UnityEngine.NavMeshPath));
			obj.ClearCorners();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_corners(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.NavMeshPath obj = (UnityEngine.NavMeshPath)o;
			UnityEngine.Vector3[] ret = obj.corners;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index corners on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_status(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.NavMeshPath obj = (UnityEngine.NavMeshPath)o;
			UnityEngine.NavMeshPathStatus ret = obj.status;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index status on a nil value" : e.Message);
		}
	}
}

