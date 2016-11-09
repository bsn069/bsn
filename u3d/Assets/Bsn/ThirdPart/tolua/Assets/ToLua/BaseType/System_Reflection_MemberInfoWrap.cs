﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Reflection_MemberInfoWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Reflection.MemberInfo), typeof(System.Object));
		L.RegFunction("IsDefined", IsDefined);
		L.RegFunction("GetCustomAttributes", GetCustomAttributes);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("DeclaringType", get_DeclaringType, null);
		L.RegVar("MemberType", get_MemberType, null);
		L.RegVar("Name", get_Name, null);
		L.RegVar("ReflectedType", get_ReflectedType, null);
		L.RegVar("Module", get_Module, null);
		L.RegVar("MetadataToken", get_MetadataToken, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDefined(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)ToLua.CheckObject(L, 1, typeof(System.Reflection.MemberInfo));
			System.Type arg0 = (System.Type)ToLua.CheckObject(L, 2, typeof(System.Type));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			bool o = obj.IsDefined(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustomAttributes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(bool)))
			{
				System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				object[] o = obj.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg0 = (System.Type)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				object[] o = obj.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Reflection.MemberInfo.GetCustomAttributes");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DeclaringType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			System.Type ret = obj.DeclaringType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index DeclaringType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MemberType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			System.Reflection.MemberTypes ret = obj.MemberType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MemberType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			string ret = obj.Name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Name on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReflectedType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			System.Type ret = obj.ReflectedType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ReflectedType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Module(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			System.Reflection.Module ret = obj.Module;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Module on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MetadataToken(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Reflection.MemberInfo obj = (System.Reflection.MemberInfo)o;
			int ret = obj.MetadataToken;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MetadataToken on a nil value" : e.Message);
		}
	}
}

