﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_AttributeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Attribute), typeof(System.Object));
		L.RegFunction("GetCustomAttribute", GetCustomAttribute);
		L.RegFunction("GetCustomAttributes", GetCustomAttributes);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("IsDefaultAttribute", IsDefaultAttribute);
		L.RegFunction("IsDefined", IsDefined);
		L.RegFunction("Match", Match);
		L.RegFunction("Equals", Equals);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("TypeId", get_TypeId, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustomAttribute(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute o = System.Attribute.GetCustomAttribute(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Attribute.GetCustomAttribute");
			}
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

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(bool)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(bool)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(bool)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(bool)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				bool arg1 = LuaDLL.lua_toboolean(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				System.Attribute[] o = System.Attribute.GetCustomAttributes(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Attribute.GetCustomAttributes");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Attribute obj = (System.Attribute)ToLua.CheckObject(L, 1, typeof(System.Attribute));
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDefaultAttribute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Attribute obj = (System.Attribute)ToLua.CheckObject(L, 1, typeof(System.Attribute));
			bool o = obj.IsDefaultAttribute();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsDefined(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool o = System.Attribute.IsDefined(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool o = System.Attribute.IsDefined(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool o = System.Attribute.IsDefined(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool o = System.Attribute.IsDefined(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Module), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Module arg0 = (System.Reflection.Module)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				bool o = System.Attribute.IsDefined(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.ParameterInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.ParameterInfo arg0 = (System.Reflection.ParameterInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				bool o = System.Attribute.IsDefined(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.MemberInfo), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.MemberInfo arg0 = (System.Reflection.MemberInfo)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				bool o = System.Attribute.IsDefined(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(System.Reflection.Assembly), typeof(System.Type), typeof(bool)))
			{
				System.Reflection.Assembly arg0 = (System.Reflection.Assembly)ToLua.ToObject(L, 1);
				System.Type arg1 = (System.Type)ToLua.ToObject(L, 2);
				bool arg2 = LuaDLL.lua_toboolean(L, 3);
				bool o = System.Attribute.IsDefined(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Attribute.IsDefined");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Match(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Attribute obj = (System.Attribute)ToLua.CheckObject(L, 1, typeof(System.Attribute));
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj.Match(arg0);
			LuaDLL.lua_pushboolean(L, o);
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
			System.Attribute obj = (System.Attribute)ToLua.CheckObject(L, 1, typeof(System.Attribute));
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TypeId(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Attribute obj = (System.Attribute)o;
			object ret = obj.TypeId;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index TypeId on a nil value" : e.Message);
		}
	}
}

