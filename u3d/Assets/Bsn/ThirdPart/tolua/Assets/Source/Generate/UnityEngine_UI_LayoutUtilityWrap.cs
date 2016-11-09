﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_LayoutUtilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("LayoutUtility");
		L.RegFunction("GetMinSize", GetMinSize);
		L.RegFunction("GetPreferredSize", GetPreferredSize);
		L.RegFunction("GetFlexibleSize", GetFlexibleSize);
		L.RegFunction("GetMinWidth", GetMinWidth);
		L.RegFunction("GetPreferredWidth", GetPreferredWidth);
		L.RegFunction("GetFlexibleWidth", GetFlexibleWidth);
		L.RegFunction("GetMinHeight", GetMinHeight);
		L.RegFunction("GetPreferredHeight", GetPreferredHeight);
		L.RegFunction("GetFlexibleHeight", GetFlexibleHeight);
		L.RegFunction("GetLayoutProperty", GetLayoutProperty);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMinSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = UnityEngine.UI.LayoutUtility.GetMinSize(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPreferredSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = UnityEngine.UI.LayoutUtility.GetPreferredSize(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFlexibleSize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			float o = UnityEngine.UI.LayoutUtility.GetFlexibleSize(arg0, arg1);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMinWidth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetMinWidth(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPreferredWidth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetPreferredWidth(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFlexibleWidth(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetFlexibleWidth(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetMinHeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetMinHeight(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPreferredHeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetPreferredHeight(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFlexibleHeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			float o = UnityEngine.UI.LayoutUtility.GetFlexibleHeight(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLayoutProperty(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RectTransform), typeof(System.Func<UnityEngine.UI.ILayoutElement,float>), typeof(float)))
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.ToObject(L, 1);
				System.Func<UnityEngine.UI.ILayoutElement,float> arg1 = null;
				LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

				if (funcType2 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Func<UnityEngine.UI.ILayoutElement,float>)ToLua.ToObject(L, 2);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 2);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Func<UnityEngine.UI.ILayoutElement,float>), func) as System.Func<UnityEngine.UI.ILayoutElement,float>;
				}

				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				float o = UnityEngine.UI.LayoutUtility.GetLayoutProperty(arg0, arg1, arg2);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.RectTransform), typeof(System.Func<UnityEngine.UI.ILayoutElement,float>), typeof(float), typeof(LuaInterface.LuaOut<UnityEngine.UI.ILayoutElement>)))
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.ToObject(L, 1);
				System.Func<UnityEngine.UI.ILayoutElement,float> arg1 = null;
				LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

				if (funcType2 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (System.Func<UnityEngine.UI.ILayoutElement,float>)ToLua.ToObject(L, 2);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 2);
					arg1 = DelegateFactory.CreateDelegate(typeof(System.Func<UnityEngine.UI.ILayoutElement,float>), func) as System.Func<UnityEngine.UI.ILayoutElement,float>;
				}

				float arg2 = (float)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.UI.ILayoutElement arg3 = null;
				float o = UnityEngine.UI.LayoutUtility.GetLayoutProperty(arg0, arg1, arg2, out arg3);
				LuaDLL.lua_pushnumber(L, o);
				ToLua.PushObject(L, arg3);
				return 2;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.UI.LayoutUtility.GetLayoutProperty");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

