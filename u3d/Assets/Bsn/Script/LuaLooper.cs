/*
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
    public class LuaLooper : MonoBehaviour {    
        public void Dispose() {
            Debug.Log("NBsn.LuaLooper Dispose"); 
        }

        void Update() {
#if UNITY_EDITOR
            if (NBsn.Global.ms_luaState == null) {
                Debug.LogError("NBsn.LuaLooper Update m_luaState == null"); 
                return;
            }
#endif
            if (NBsn.Global.ms_luaState.LuaUpdate(Time.deltaTime, Time.unscaledDeltaTime) != 0) {
                NBsn.Global.ThrowException();
            }

            NBsn.Global.ms_luaState.LuaPop(1);
            NBsn.Global.ms_luaState.Collect();
#if UNITY_EDITOR
            if (!NBsn.Global.ms_luaState.CheckTop()) {
                Debug.LogError("NBsn.LuaLooper Update !m_luaState.CheckTop()"); 
                return;
            }
#endif
        }

        void LateUpdate() {
#if UNITY_EDITOR
            if (NBsn.Global.ms_luaState == null) {
                Debug.LogError("NBsn.LuaLooper LateUpdate m_luaState == null"); 
                return;
            }
#endif
            if (NBsn.Global.ms_luaState.LuaLateUpdate() != 0) {
                NBsn.Global.ThrowException();
            }

            NBsn.Global.ms_luaState.LuaPop(1);
#if UNITY_EDITOR
            if (!NBsn.Global.ms_luaState.CheckTop()) {
                Debug.LogError("NBsn.LuaLooper LateUpdate !m_luaState.CheckTop()"); 
                return;
            }
#endif
        }

        void FixedUpdate() {
#if UNITY_EDITOR
            if (NBsn.Global.ms_luaState == null) {
                Debug.LogError("NBsn.LuaLooper FixedUpdate m_luaState == null"); 
                return;
            }
#endif
            if (NBsn.Global.ms_luaState.LuaFixedUpdate(Time.fixedDeltaTime) != 0) {
                NBsn.Global.ThrowException();
            }

            NBsn.Global.ms_luaState.LuaPop(1);
#if UNITY_EDITOR
            if (!NBsn.Global.ms_luaState.CheckTop()) {
                Debug.LogError("NBsn.LuaLooper FixedUpdate !m_luaState.CheckTop()"); 
                return;
            }
#endif
        }

        void OnDestroy() {
            Debug.Log("NBsn.LuaLooper OnDestroy"); 
            Dispose();
        }
    }
}