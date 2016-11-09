﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_VR_InputTrackingWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.VR.InputTracking), typeof(System.Object));
		L.RegFunction("GetLocalPosition", GetLocalPosition);
		L.RegFunction("GetLocalRotation", GetLocalRotation);
		L.RegFunction("Recenter", Recenter);
		L.RegFunction("New", _CreateUnityEngine_VR_InputTracking);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_VR_InputTracking(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.VR.InputTracking obj = new UnityEngine.VR.InputTracking();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.VR.InputTracking.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLocalPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.VR.VRNode arg0 = (UnityEngine.VR.VRNode)ToLua.CheckObject(L, 1, typeof(UnityEngine.VR.VRNode));
			UnityEngine.Vector3 o = UnityEngine.VR.InputTracking.GetLocalPosition(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLocalRotation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.VR.VRNode arg0 = (UnityEngine.VR.VRNode)ToLua.CheckObject(L, 1, typeof(UnityEngine.VR.VRNode));
			UnityEngine.Quaternion o = UnityEngine.VR.InputTracking.GetLocalRotation(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Recenter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.VR.InputTracking.Recenter();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

