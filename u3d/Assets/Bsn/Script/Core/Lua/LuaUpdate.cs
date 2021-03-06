﻿/*
Copyright (c) 2015-2016 topameng(topameng@qq.com)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using UnityEngine;
using LuaInterface;

namespace NBsn {
    [Reg2LuaAttribute]
    public class CLuaUpdate : MonoBehaviour { 
//        void Update() {
//            var luaState = NBsn.Global.ms_luaState;
//            if (luaState == null) {
//#if UNITY_EDITOR
//                Debug.LogError("NBsn.LuaLooper Update luaState == null"); 
//#endif
//                return;
//            }

//            if (luaState.LuaUpdate(Time.deltaTime, Time.unscaledDeltaTime) != 0) {
//                NBsn.CLuaException.Throw();
//            }

//            luaState.LuaPop(1);
//            luaState.Collect();
//#if UNITY_EDITOR
//            if (!luaState.CheckTop()) {
//                Debug.LogError("NBsn.LuaLooper Update !luaState.CheckTop()"); 
//                return;
//            }
//#endif
//        }

//        void LateUpdate() {
//            var luaState = NBsn.Global.ms_luaState;
//            if (luaState == null) {
//#if UNITY_EDITOR
//                Debug.LogError("NBsn.LuaLooper LateUpdate luaState == null"); 
//#endif
//                return;
//            }
//            if (luaState.LuaLateUpdate() != 0) {
//                NBsn.CLuaException.Throw();
//            }

//            luaState.LuaPop(1);
//#if UNITY_EDITOR
//            if (!luaState.CheckTop()) {
//                Debug.LogError("NBsn.LuaLooper LateUpdate !luaState.CheckTop()"); 
//                return;
//            }
//#endif
//        }

//        void FixedUpdate() {
//            var luaState = NBsn.Global.ms_luaState;
//            if (luaState == null) {
//#if UNITY_EDITOR
//                Debug.LogError("NBsn.LuaLooper FixedUpdate luaState == null"); 
//#endif
//                return;
//            }
//            if (luaState.LuaFixedUpdate(Time.fixedDeltaTime) != 0) {
//                NBsn.CLuaException.Throw();
//            }

//            luaState.LuaPop(1);
//#if UNITY_EDITOR
//            if (!luaState.CheckTop()) {
//                Debug.LogError("NBsn.LuaLooper FixedUpdate !luaState.CheckTop()"); 
//                return;
//            }
//#endif
//        }
    }
}