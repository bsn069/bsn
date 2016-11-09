﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_CubemapWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Cubemap), typeof(UnityEngine.Texture));
		L.RegFunction("SetPixel", SetPixel);
		L.RegFunction("GetPixel", GetPixel);
		L.RegFunction("GetPixels", GetPixels);
		L.RegFunction("SetPixels", SetPixels);
		L.RegFunction("Apply", Apply);
		L.RegFunction("SmoothEdges", SmoothEdges);
		L.RegFunction("New", _CreateUnityEngine_Cubemap);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("mipmapCount", get_mipmapCount, null);
		L.RegVar("format", get_format, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Cubemap(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				UnityEngine.TextureFormat arg1 = (UnityEngine.TextureFormat)ToLua.CheckObject(L, 2, typeof(UnityEngine.TextureFormat));
				bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
				UnityEngine.Cubemap obj = new UnityEngine.Cubemap(arg0, arg1, arg2);
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Cubemap.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.CheckObject(L, 1, typeof(UnityEngine.Cubemap));
			UnityEngine.CubemapFace arg0 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 2, typeof(UnityEngine.CubemapFace));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			UnityEngine.Color arg3 = ToLua.ToColor(L, 5);
			obj.SetPixel(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.CheckObject(L, 1, typeof(UnityEngine.Cubemap));
			UnityEngine.CubemapFace arg0 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 2, typeof(UnityEngine.CubemapFace));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			UnityEngine.Color o = obj.GetPixel(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(UnityEngine.CubemapFace)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				UnityEngine.CubemapFace arg0 = (UnityEngine.CubemapFace)ToLua.ToObject(L, 2);
				UnityEngine.Color[] o = obj.GetPixels(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(UnityEngine.CubemapFace), typeof(int)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				UnityEngine.CubemapFace arg0 = (UnityEngine.CubemapFace)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Color[] o = obj.GetPixels(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Cubemap.GetPixels");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				UnityEngine.Color[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 2);
				UnityEngine.CubemapFace arg1 = (UnityEngine.CubemapFace)ToLua.ToObject(L, 3);
				obj.SetPixels(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(UnityEngine.Color[]), typeof(UnityEngine.CubemapFace), typeof(int)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				UnityEngine.Color[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 2);
				UnityEngine.CubemapFace arg1 = (UnityEngine.CubemapFace)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.SetPixels(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Cubemap.SetPixels");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				obj.Apply();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(bool)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				obj.Apply(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(bool), typeof(bool)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.Apply(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Cubemap.Apply");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SmoothEdges(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				obj.SmoothEdges();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Cubemap), typeof(int)))
			{
				UnityEngine.Cubemap obj = (UnityEngine.Cubemap)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				obj.SmoothEdges(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Cubemap.SmoothEdges");
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
	static int get_mipmapCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Cubemap obj = (UnityEngine.Cubemap)o;
			int ret = obj.mipmapCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipmapCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_format(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Cubemap obj = (UnityEngine.Cubemap)o;
			UnityEngine.TextureFormat ret = obj.format;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index format on a nil value" : e.Message);
		}
	}
}

