﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_Match_CreateOrJoinMatchRequestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.Match.CreateOrJoinMatchRequest), typeof(UnityEngine.Networking.Match.CreateMatchRequest));
		L.RegFunction("New", _CreateUnityEngine_Networking_Match_CreateOrJoinMatchRequest);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Networking_Match_CreateOrJoinMatchRequest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Networking.Match.CreateOrJoinMatchRequest obj = new UnityEngine.Networking.Match.CreateOrJoinMatchRequest();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Networking.Match.CreateOrJoinMatchRequest.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

