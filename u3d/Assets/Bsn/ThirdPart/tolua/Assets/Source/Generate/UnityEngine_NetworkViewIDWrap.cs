﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_NetworkViewIDWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.NetworkViewID), null);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("Equals", Equals);
		L.RegFunction("ToString", ToString);
		L.RegFunction("New", _CreateUnityEngine_NetworkViewID);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("unassigned", get_unassigned, null);
		L.RegVar("isMine", get_isMine, null);
		L.RegVar("owner", get_owner, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_NetworkViewID(IntPtr L)
	{
		UnityEngine.NetworkViewID obj = new UnityEngine.NetworkViewID();
		ToLua.PushValue(L, obj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NetworkViewID obj = (UnityEngine.NetworkViewID)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkViewID));
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.NetworkViewID obj = (UnityEngine.NetworkViewID)ToLua.ToObject(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.Equals(arg0);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NetworkViewID obj = (UnityEngine.NetworkViewID)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkViewID));
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.NetworkViewID arg0 = (UnityEngine.NetworkViewID)ToLua.ToObject(L, 1);
			UnityEngine.NetworkViewID arg1 = (UnityEngine.NetworkViewID)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unassigned(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.NetworkViewID.unassigned);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMine(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.NetworkViewID obj = (UnityEngine.NetworkViewID)o;
			bool ret = obj.isMine;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index isMine on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_owner(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.NetworkViewID obj = (UnityEngine.NetworkViewID)o;
			UnityEngine.NetworkPlayer ret = obj.owner;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index owner on a nil value" : e.Message);
		}
	}
}

