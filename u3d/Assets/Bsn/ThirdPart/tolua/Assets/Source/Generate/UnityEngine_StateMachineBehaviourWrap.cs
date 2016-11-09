﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_StateMachineBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.ScriptableObject));
		L.RegFunction("OnStateEnter", OnStateEnter);
		L.RegFunction("OnStateUpdate", OnStateUpdate);
		L.RegFunction("OnStateExit", OnStateExit);
		L.RegFunction("OnStateMove", OnStateMove);
		L.RegFunction("OnStateIK", OnStateIK);
		L.RegFunction("OnStateMachineEnter", OnStateMachineEnter);
		L.RegFunction("OnStateMachineExit", OnStateMachineExit);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateEnter(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.OnStateEnter(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 5);
				obj.OnStateEnter(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateEnter");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateUpdate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.OnStateUpdate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 5);
				obj.OnStateUpdate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateUpdate");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateExit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.OnStateExit(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 5);
				obj.OnStateExit(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateExit");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMove(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.OnStateMove(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 5);
				obj.OnStateMove(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateMove");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateIK(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.OnStateIK(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(UnityEngine.AnimatorStateInfo), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				UnityEngine.AnimatorStateInfo arg1 = (UnityEngine.AnimatorStateInfo)ToLua.ToObject(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg3 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 5);
				obj.OnStateIK(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateIK");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMachineEnter(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.OnStateMachineEnter(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg2 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 4);
				obj.OnStateMachineEnter(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateMachineEnter");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStateMachineExit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(int)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.OnStateMachineExit(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.StateMachineBehaviour), typeof(UnityEngine.Animator), typeof(int), typeof(UnityEngine.Experimental.Director.AnimatorControllerPlayable)))
			{
				UnityEngine.StateMachineBehaviour obj = (UnityEngine.StateMachineBehaviour)ToLua.ToObject(L, 1);
				UnityEngine.Animator arg0 = (UnityEngine.Animator)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable arg2 = (UnityEngine.Experimental.Director.AnimatorControllerPlayable)ToLua.ToObject(L, 4);
				obj.OnStateMachineExit(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.StateMachineBehaviour.OnStateMachineExit");
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
}

