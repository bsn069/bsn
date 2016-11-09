﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_Match_MatchDirectConnectInfoWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.Match.MatchDirectConnectInfo), typeof(UnityEngine.Networking.Match.ResponseBase));
		L.RegFunction("ToString", ToString);
		L.RegFunction("Parse", Parse);
		L.RegFunction("New", _CreateUnityEngine_Networking_Match_MatchDirectConnectInfo);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("nodeId", get_nodeId, set_nodeId);
		L.RegVar("publicAddress", get_publicAddress, set_publicAddress);
		L.RegVar("privateAddress", get_privateAddress, set_privateAddress);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Networking_Match_MatchDirectConnectInfo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Networking.Match.MatchDirectConnectInfo obj = new UnityEngine.Networking.Match.MatchDirectConnectInfo();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Networking.Match.MatchDirectConnectInfo.New");
			}
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
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)ToLua.CheckObject(L, 1, typeof(UnityEngine.Networking.Match.MatchDirectConnectInfo));
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
	static int Parse(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)ToLua.CheckObject(L, 1, typeof(UnityEngine.Networking.Match.MatchDirectConnectInfo));
			object arg0 = ToLua.ToVarObject(L, 2);
			obj.Parse(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nodeId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			UnityEngine.Networking.Types.NodeID ret = obj.nodeId;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index nodeId on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_publicAddress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			string ret = obj.publicAddress;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index publicAddress on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_privateAddress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			string ret = obj.privateAddress;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index privateAddress on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nodeId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			UnityEngine.Networking.Types.NodeID arg0 = (UnityEngine.Networking.Types.NodeID)ToLua.CheckObject(L, 2, typeof(UnityEngine.Networking.Types.NodeID));
			obj.nodeId = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index nodeId on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_publicAddress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.publicAddress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index publicAddress on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_privateAddress(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.MatchDirectConnectInfo obj = (UnityEngine.Networking.Match.MatchDirectConnectInfo)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.privateAddress = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index privateAddress on a nil value" : e.Message);
		}
	}
}

