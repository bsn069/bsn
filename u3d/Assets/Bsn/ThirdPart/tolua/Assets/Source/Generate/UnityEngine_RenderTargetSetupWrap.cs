﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_RenderTargetSetupWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.RenderTargetSetup), null);
		L.RegFunction("New", _CreateUnityEngine_RenderTargetSetup);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("color", get_color, set_color);
		L.RegVar("depth", get_depth, set_depth);
		L.RegVar("mipLevel", get_mipLevel, set_mipLevel);
		L.RegVar("cubemapFace", get_cubemapFace, set_cubemapFace);
		L.RegVar("colorLoad", get_colorLoad, set_colorLoad);
		L.RegVar("colorStore", get_colorStore, set_colorStore);
		L.RegVar("depthLoad", get_depthLoad, set_depthLoad);
		L.RegVar("depthStore", get_depthStore, set_depthStore);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_RenderTargetSetup(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer)))
			{
				UnityEngine.RenderBuffer arg0 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 1, typeof(UnityEngine.RenderBuffer));
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer)))
			{
				UnityEngine.RenderBuffer[] arg0 = ToLua.CheckObjectArray<UnityEngine.RenderBuffer>(L, 1);
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(int)))
			{
				UnityEngine.RenderBuffer[] arg0 = ToLua.CheckObjectArray<UnityEngine.RenderBuffer>(L, 1);
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1, arg2);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(int)))
			{
				UnityEngine.RenderBuffer arg0 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 1, typeof(UnityEngine.RenderBuffer));
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1, arg2);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(int), typeof(UnityEngine.CubemapFace)))
			{
				UnityEngine.RenderBuffer[] arg0 = ToLua.CheckObjectArray<UnityEngine.RenderBuffer>(L, 1);
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.CubemapFace arg3 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 4, typeof(UnityEngine.CubemapFace));
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1, arg2, arg3);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(int), typeof(UnityEngine.CubemapFace)))
			{
				UnityEngine.RenderBuffer arg0 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 1, typeof(UnityEngine.RenderBuffer));
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.CubemapFace arg3 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 4, typeof(UnityEngine.CubemapFace));
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1, arg2, arg3);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 8 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer), typeof(int), typeof(UnityEngine.CubemapFace), typeof(UnityEngine.Rendering.RenderBufferLoadAction[]), typeof(UnityEngine.Rendering.RenderBufferStoreAction[]), typeof(UnityEngine.Rendering.RenderBufferLoadAction), typeof(UnityEngine.Rendering.RenderBufferStoreAction)))
			{
				UnityEngine.RenderBuffer[] arg0 = ToLua.CheckObjectArray<UnityEngine.RenderBuffer>(L, 1);
				UnityEngine.RenderBuffer arg1 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.CubemapFace arg3 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 4, typeof(UnityEngine.CubemapFace));
				UnityEngine.Rendering.RenderBufferLoadAction[] arg4 = ToLua.CheckObjectArray<UnityEngine.Rendering.RenderBufferLoadAction>(L, 5);
				UnityEngine.Rendering.RenderBufferStoreAction[] arg5 = ToLua.CheckObjectArray<UnityEngine.Rendering.RenderBufferStoreAction>(L, 6);
				UnityEngine.Rendering.RenderBufferLoadAction arg6 = (UnityEngine.Rendering.RenderBufferLoadAction)ToLua.CheckObject(L, 7, typeof(UnityEngine.Rendering.RenderBufferLoadAction));
				UnityEngine.Rendering.RenderBufferStoreAction arg7 = (UnityEngine.Rendering.RenderBufferStoreAction)ToLua.CheckObject(L, 8, typeof(UnityEngine.Rendering.RenderBufferStoreAction));
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 0)
			{
				UnityEngine.RenderTargetSetup obj = new UnityEngine.RenderTargetSetup();
				ToLua.PushValue(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.RenderTargetSetup.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.RenderBuffer[] ret = obj.color;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index color on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.RenderBuffer ret = obj.depth;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mipLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			int ret = obj.mipLevel;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipLevel on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cubemapFace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.CubemapFace ret = obj.cubemapFace;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index cubemapFace on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorLoad(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferLoadAction[] ret = obj.colorLoad;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colorLoad on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorStore(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferStoreAction[] ret = obj.colorStore;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colorStore on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depthLoad(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferLoadAction ret = obj.depthLoad;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depthLoad on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depthStore(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferStoreAction ret = obj.depthStore;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depthStore on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.RenderBuffer[] arg0 = ToLua.CheckObjectArray<UnityEngine.RenderBuffer>(L, 2);
			obj.color = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index color on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.RenderBuffer arg0 = (UnityEngine.RenderBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderBuffer));
			obj.depth = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mipLevel(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.mipLevel = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipLevel on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cubemapFace(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.CubemapFace arg0 = (UnityEngine.CubemapFace)ToLua.CheckObject(L, 2, typeof(UnityEngine.CubemapFace));
			obj.cubemapFace = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index cubemapFace on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colorLoad(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferLoadAction[] arg0 = ToLua.CheckObjectArray<UnityEngine.Rendering.RenderBufferLoadAction>(L, 2);
			obj.colorLoad = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colorLoad on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colorStore(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferStoreAction[] arg0 = ToLua.CheckObjectArray<UnityEngine.Rendering.RenderBufferStoreAction>(L, 2);
			obj.colorStore = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index colorStore on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_depthLoad(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferLoadAction arg0 = (UnityEngine.Rendering.RenderBufferLoadAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferLoadAction));
			obj.depthLoad = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depthLoad on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_depthStore(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.RenderTargetSetup obj = (UnityEngine.RenderTargetSetup)o;
			UnityEngine.Rendering.RenderBufferStoreAction arg0 = (UnityEngine.Rendering.RenderBufferStoreAction)ToLua.CheckObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferStoreAction));
			obj.depthStore = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index depthStore on a nil value" : e.Message);
		}
	}
}

