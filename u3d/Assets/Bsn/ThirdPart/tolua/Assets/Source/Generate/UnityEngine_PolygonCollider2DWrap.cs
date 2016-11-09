﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_PolygonCollider2DWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.PolygonCollider2D), typeof(UnityEngine.Collider2D));
		L.RegFunction("GetPath", GetPath);
		L.RegFunction("SetPath", SetPath);
		L.RegFunction("GetTotalPointCount", GetTotalPointCount);
		L.RegFunction("CreatePrimitive", CreatePrimitive);
		L.RegFunction("New", _CreateUnityEngine_PolygonCollider2D);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("points", get_points, set_points);
		L.RegVar("pathCount", get_pathCount, set_pathCount);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_PolygonCollider2D(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.PolygonCollider2D obj = new UnityEngine.PolygonCollider2D();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.PolygonCollider2D.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.PolygonCollider2D));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector2[] o = obj.GetPath(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.PolygonCollider2D));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector2[] arg1 = ToLua.CheckObjectArray<UnityEngine.Vector2>(L, 3);
			obj.SetPath(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTotalPointCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.PolygonCollider2D));
			int o = obj.GetTotalPointCount();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePrimitive(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.PolygonCollider2D), typeof(int)))
			{
				UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				obj.CreatePrimitive(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.PolygonCollider2D), typeof(int), typeof(UnityEngine.Vector2)))
			{
				UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 3);
				obj.CreatePrimitive(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.PolygonCollider2D), typeof(int), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)))
			{
				UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 3);
				UnityEngine.Vector2 arg2 = ToLua.ToVector2(L, 4);
				obj.CreatePrimitive(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.PolygonCollider2D.CreatePrimitive");
			}
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
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
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
	static int get_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)o;
			UnityEngine.Vector2[] ret = obj.points;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index points on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pathCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)o;
			int ret = obj.pathCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index pathCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)o;
			UnityEngine.Vector2[] arg0 = ToLua.CheckObjectArray<UnityEngine.Vector2>(L, 2);
			obj.points = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index points on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pathCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.PolygonCollider2D obj = (UnityEngine.PolygonCollider2D)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.pathCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index pathCount on a nil value" : e.Message);
		}
	}
}

