﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_NetworkWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Network), typeof(System.Object));
		L.RegFunction("InitializeServer", InitializeServer);
		L.RegFunction("InitializeSecurity", InitializeSecurity);
		L.RegFunction("Connect", Connect);
		L.RegFunction("Disconnect", Disconnect);
		L.RegFunction("CloseConnection", CloseConnection);
		L.RegFunction("AllocateViewID", AllocateViewID);
		L.RegFunction("Instantiate", Instantiate);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("DestroyPlayerObjects", DestroyPlayerObjects);
		L.RegFunction("RemoveRPCs", RemoveRPCs);
		L.RegFunction("RemoveRPCsInGroup", RemoveRPCsInGroup);
		L.RegFunction("SetLevelPrefix", SetLevelPrefix);
		L.RegFunction("GetLastPing", GetLastPing);
		L.RegFunction("GetAveragePing", GetAveragePing);
		L.RegFunction("SetReceivingEnabled", SetReceivingEnabled);
		L.RegFunction("SetSendingEnabled", SetSendingEnabled);
		L.RegFunction("TestConnection", TestConnection);
		L.RegFunction("TestConnectionNAT", TestConnectionNAT);
		L.RegFunction("HavePublicAddress", HavePublicAddress);
		L.RegFunction("New", _CreateUnityEngine_Network);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("incomingPassword", get_incomingPassword, set_incomingPassword);
		L.RegVar("logLevel", get_logLevel, set_logLevel);
		L.RegVar("connections", get_connections, null);
		L.RegVar("player", get_player, null);
		L.RegVar("isClient", get_isClient, null);
		L.RegVar("isServer", get_isServer, null);
		L.RegVar("peerType", get_peerType, null);
		L.RegVar("sendRate", get_sendRate, set_sendRate);
		L.RegVar("isMessageQueueRunning", get_isMessageQueueRunning, set_isMessageQueueRunning);
		L.RegVar("time", get_time, null);
		L.RegVar("minimumAllocatableViewIDs", get_minimumAllocatableViewIDs, set_minimumAllocatableViewIDs);
		L.RegVar("natFacilitatorIP", get_natFacilitatorIP, set_natFacilitatorIP);
		L.RegVar("natFacilitatorPort", get_natFacilitatorPort, set_natFacilitatorPort);
		L.RegVar("connectionTesterIP", get_connectionTesterIP, set_connectionTesterIP);
		L.RegVar("connectionTesterPort", get_connectionTesterPort, set_connectionTesterPort);
		L.RegVar("maxConnections", get_maxConnections, set_maxConnections);
		L.RegVar("proxyIP", get_proxyIP, set_proxyIP);
		L.RegVar("proxyPort", get_proxyPort, set_proxyPort);
		L.RegVar("useProxy", get_useProxy, set_useProxy);
		L.RegVar("proxyPassword", get_proxyPassword, set_proxyPassword);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Network(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Network obj = new UnityEngine.Network();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Network.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitializeServer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			UnityEngine.NetworkConnectionError o = UnityEngine.Network.InitializeServer(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitializeSecurity(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Network.InitializeSecurity();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Connect(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.HostData)))
			{
				UnityEngine.HostData arg0 = (UnityEngine.HostData)ToLua.ToObject(L, 1);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(int)))
			{
				string arg0 = ToLua.ToString(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.HostData), typeof(string)))
			{
				UnityEngine.HostData arg0 = (UnityEngine.HostData)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string[]), typeof(int)))
			{
				string[] arg0 = ToLua.CheckStringArray(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(int), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(string[]), typeof(int), typeof(string)))
			{
				string[] arg0 = ToLua.CheckStringArray(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				string arg2 = ToLua.ToString(L, 3);
				UnityEngine.NetworkConnectionError o = UnityEngine.Network.Connect(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.Connect");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Disconnect(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Network.Disconnect();
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(int)))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Network.Disconnect(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.Disconnect");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CloseConnection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkPlayer));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Network.CloseConnection(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AllocateViewID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.NetworkViewID o = UnityEngine.Network.AllocateViewID();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Instantiate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Object));
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
			UnityEngine.Quaternion arg2 = ToLua.ToQuaternion(L, 3);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 4);
			UnityEngine.Object o = UnityEngine.Network.Instantiate(arg0, arg1, arg2, arg3);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.GameObject)))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				UnityEngine.Network.Destroy(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.NetworkViewID)))
			{
				UnityEngine.NetworkViewID arg0 = (UnityEngine.NetworkViewID)ToLua.ToObject(L, 1);
				UnityEngine.Network.Destroy(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.Destroy");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyPlayerObjects(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkPlayer));
			UnityEngine.Network.DestroyPlayerObjects(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRPCs(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.NetworkViewID)))
			{
				UnityEngine.NetworkViewID arg0 = (UnityEngine.NetworkViewID)ToLua.ToObject(L, 1);
				UnityEngine.Network.RemoveRPCs(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.NetworkPlayer)))
			{
				UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.ToObject(L, 1);
				UnityEngine.Network.RemoveRPCs(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.NetworkPlayer), typeof(int)))
			{
				UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.ToObject(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Network.RemoveRPCs(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.RemoveRPCs");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRPCsInGroup(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Network.RemoveRPCsInGroup(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLevelPrefix(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.Network.SetLevelPrefix(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLastPing(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkPlayer));
			int o = UnityEngine.Network.GetLastPing(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAveragePing(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkPlayer));
			int o = UnityEngine.Network.GetAveragePing(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetReceivingEnabled(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.CheckObject(L, 1, typeof(UnityEngine.NetworkPlayer));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			UnityEngine.Network.SetReceivingEnabled(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSendingEnabled(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(int), typeof(bool)))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				UnityEngine.Network.SetSendingEnabled(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.NetworkPlayer), typeof(int), typeof(bool)))
			{
				UnityEngine.NetworkPlayer arg0 = (UnityEngine.NetworkPlayer)ToLua.ToObject(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				UnityEngine.Network.SetSendingEnabled(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.SetSendingEnabled");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestConnection(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.ConnectionTesterStatus o = UnityEngine.Network.TestConnection();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(bool)))
			{
				bool arg0 = LuaDLL.lua_toboolean(L, 1);
				UnityEngine.ConnectionTesterStatus o = UnityEngine.Network.TestConnection(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.TestConnection");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestConnectionNAT(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.ConnectionTesterStatus o = UnityEngine.Network.TestConnectionNAT();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(bool)))
			{
				bool arg0 = LuaDLL.lua_toboolean(L, 1);
				UnityEngine.ConnectionTesterStatus o = UnityEngine.Network.TestConnectionNAT(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Network.TestConnectionNAT");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HavePublicAddress(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = UnityEngine.Network.HavePublicAddress();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_incomingPassword(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Network.incomingPassword);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logLevel(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Network.logLevel);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_connections(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Network.connections);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_player(IntPtr L)
	{
		try
		{
			ToLua.PushValue(L, UnityEngine.Network.player);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isClient(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Network.isClient);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isServer(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Network.isServer);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_peerType(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Network.peerType);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sendRate(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Network.sendRate);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMessageQueueRunning(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Network.isMessageQueueRunning);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, UnityEngine.Network.time);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minimumAllocatableViewIDs(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Network.minimumAllocatableViewIDs);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_natFacilitatorIP(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Network.natFacilitatorIP);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_natFacilitatorPort(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Network.natFacilitatorPort);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_connectionTesterIP(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Network.connectionTesterIP);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_connectionTesterPort(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Network.connectionTesterPort);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxConnections(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Network.maxConnections);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_proxyIP(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Network.proxyIP);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_proxyPort(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Network.proxyPort);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useProxy(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, UnityEngine.Network.useProxy);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_proxyPassword(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, UnityEngine.Network.proxyPassword);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_incomingPassword(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Network.incomingPassword = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logLevel(IntPtr L)
	{
		try
		{
			UnityEngine.NetworkLogLevel arg0 = (UnityEngine.NetworkLogLevel)ToLua.CheckObject(L, 2, typeof(UnityEngine.NetworkLogLevel));
			UnityEngine.Network.logLevel = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_sendRate(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.sendRate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_isMessageQueueRunning(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Network.isMessageQueueRunning = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_minimumAllocatableViewIDs(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.minimumAllocatableViewIDs = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_natFacilitatorIP(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Network.natFacilitatorIP = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_natFacilitatorPort(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.natFacilitatorPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_connectionTesterIP(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Network.connectionTesterIP = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_connectionTesterPort(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.connectionTesterPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxConnections(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.maxConnections = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_proxyIP(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Network.proxyIP = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_proxyPort(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Network.proxyPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useProxy(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			UnityEngine.Network.useProxy = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_proxyPassword(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Network.proxyPassword = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

