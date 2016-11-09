﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Networking_Match_ListMatchResponseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Networking.Match.ListMatchResponse), typeof(UnityEngine.Networking.Match.BasicResponse));
		L.RegFunction("ToString", ToString);
		L.RegFunction("Parse", Parse);
		L.RegFunction("New", _CreateUnityEngine_Networking_Match_ListMatchResponse);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("matches", get_matches, set_matches);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Networking_Match_ListMatchResponse(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Networking.Match.ListMatchResponse obj = new UnityEngine.Networking.Match.ListMatchResponse();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc>)))
			{
				System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc> arg0 = (System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc>)ToLua.CheckObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc>));
				UnityEngine.Networking.Match.ListMatchResponse obj = new UnityEngine.Networking.Match.ListMatchResponse(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Networking.Match.ListMatchResponse.New");
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
			UnityEngine.Networking.Match.ListMatchResponse obj = (UnityEngine.Networking.Match.ListMatchResponse)ToLua.CheckObject(L, 1, typeof(UnityEngine.Networking.Match.ListMatchResponse));
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
			UnityEngine.Networking.Match.ListMatchResponse obj = (UnityEngine.Networking.Match.ListMatchResponse)ToLua.CheckObject(L, 1, typeof(UnityEngine.Networking.Match.ListMatchResponse));
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
	static int get_matches(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.ListMatchResponse obj = (UnityEngine.Networking.Match.ListMatchResponse)o;
			System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc> ret = obj.matches;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index matches on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_matches(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Networking.Match.ListMatchResponse obj = (UnityEngine.Networking.Match.ListMatchResponse)o;
			System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc> arg0 = (System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Networking.Match.MatchDesc>));
			obj.matches = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index matches on a nil value" : e.Message);
		}
	}
}

