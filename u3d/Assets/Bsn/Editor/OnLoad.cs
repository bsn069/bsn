using System;
using UnityEditor;
using UnityEngine;
using BindType = ToLuaMenu.BindType;

namespace NBsnEditor {

    [InitializeOnLoad]
    public static class OnLoad {
        static OnLoad() {
            Debug.Log("NBsnEditor.OnLoad OnLoad()");
        }
    }

}