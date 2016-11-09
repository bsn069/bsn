﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Events_UnityEvent_intWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Events.UnityEvent<int>), typeof(UnityEngine.Events.UnityEventBase), "UnityEvent_int");
		L.RegFunction("AddListener", AddListener);
		L.RegFunction("RemoveListener", RemoveListener);
		L.RegFunction("Invoke", Invoke);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<int> obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<int>));
			UnityEngine.Events.UnityAction<int> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<int>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<int>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<int>), func) as UnityEngine.Events.UnityAction<int>;
			}

			obj.AddListener(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<int> obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<int>));
			UnityEngine.Events.UnityAction<int> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UnityEngine.Events.UnityAction<int>)ToLua.CheckObject(L, 2, typeof(UnityEngine.Events.UnityAction<int>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<int>), func) as UnityEngine.Events.UnityAction<int>;
			}

			obj.RemoveListener(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invoke(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Events.UnityEvent<int> obj = (UnityEngine.Events.UnityEvent<int>)ToLua.CheckObject(L, 1, typeof(UnityEngine.Events.UnityEvent<int>));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.Invoke(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

