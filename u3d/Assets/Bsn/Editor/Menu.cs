using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.IO;
using System.Diagnostics;
using LuaInterface;
using System.Threading; 

using Object = UnityEngine.Object;
using Debug = UnityEngine.Debug;
using Debugger = LuaInterface.Debugger;
using System.Threading;
using BindType = ToLuaMenu.BindType;

namespace NBsnEditor {
    public static class Menu {
        [MenuItem("Bsn/Test", false, 1)]
        public static void Bsn_Test() {
            Debug.Log("NBsnEditor.Menu.Bsn_Test()");

            Assembly assembly = Assembly.Load("Assembly-CSharp");
            Type[] types = assembly.GetExportedTypes();
			foreach (Type t in types) {
				if (t.GetCustomAttributes(typeof(NBsn.Reg2LuaAttribute), false).Length > 0) {
					Debug.LogFormat("t={0}", t);
				}
			}
        }

        #region AssertBundle one
        [MenuItem("Bsn/AssertBundleScene/Win32", false, 1)]
        public static void Bsn_ABSceneWin32() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABSceneWin32()");
            AssetBuddleBuilder.Scene(BuildTarget.StandaloneWindows);
        }
        #endregion

        #region AssertBundle one
        [MenuItem("Bsn/AssertBundleOne/Win32", false, 1)]
        public static void Bsn_ABOneWin32() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABOneWin32()");
            AssetBuddleBuilder.One(BuildTarget.StandaloneWindows);
        }

        [MenuItem("Bsn/AssertBundleOne/Win64", false, 2)]
        public static void Bsn_ABOneWin64() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABOneWin64()");
            AssetBuddleBuilder.One(BuildTarget.StandaloneWindows64);
        }

        [MenuItem("Bsn/AssertBundleOne/Android", false, 3)]
        public static void Bsn_ABOneAndroid() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABOneAndroid()");
            AssetBuddleBuilder.One(BuildTarget.Android);
        }
        #endregion

        #region AssertBundle all
        [MenuItem("Bsn/AssertBundleAll/Win32", false, 1)]
        public static void Bsn_ABAllWin32() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABAllWin32()");
            AssetBuddleBuilder.All(BuildTarget.StandaloneWindows);
        }

        [MenuItem("Bsn/AssertBundleAll/Win64", false, 2)]
        public static void Bsn_ABAllWin64() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABAllWin64()");
            AssetBuddleBuilder.All(BuildTarget.StandaloneWindows64);
        }

        [MenuItem("Bsn/AssertBundleAll/Android", false, 3)]
        public static void Bsn_ABAllAndroid() {
            Debug.Log("NBsnEditor.Menu.Bsn_ABAllAndroid()");
            AssetBuddleBuilder.All(BuildTarget.Android);
        }
        #endregion

        #region build
        static string[] strSrcPath = new string[] {
            Application.dataPath + "/Bsn/ThirdPart/tolua/Assets/Plugins/x86/tolua.dll", 
            Application.dataPath + "/Bsn/ThirdPart/tolua/Assets/Plugins/Android/libs/x86/libtolua.so", 
        };
        static string[] strAndriodPath = new string[] {
            Application.dataPath + "/Bsn/ThirdPart/tolua/Assets/Plugins/x86/tolua_back.dll",
            Application.dataPath + "/Bsn/ThirdPart/tolua/Assets/Plugins/Android/libs/x86/libtolua_back.so",
        };

        [MenuItem("Bsn/Build/Win32", false, 1)]
        public static void Bsn_BuildWin32() {
            Debug.Log("NBsnEditor.Menu.Bsn_BuildWin32()");
            for (int i = 0; i < strAndriodPath.Length; i++) {
                FileInfo fInfo = new FileInfo(strAndriodPath[i]);
                if (fInfo.Exists) {
                    fInfo.MoveTo(strSrcPath[i]);
                }
            }
            AssetDatabase.Refresh();

            Builder.Bsn_Build(BuildTarget.StandaloneWindows);
        }

        [MenuItem("Bsn/Build/Win64", false, 2)]
        public static void Bsn_BuildWin64() {
            Debug.Log("NBsnEditor.Menu.Bsn_BuildWin64()");
            Builder.Bsn_Build(BuildTarget.StandaloneWindows64);
        }

        [MenuItem("Bsn/Build/Android", false, 3)]
        public static void Bsn_Android() {
            Debug.Log("NBsnEditor.Menu.Bsn_Android()");

            for (int i = 0; i < strAndriodPath.Length; i++) {
                FileInfo fInfo = new FileInfo(strSrcPath[i]);
                if (fInfo.Exists) {
                    fInfo.MoveTo(strAndriodPath[i]);
                }
            }
            AssetDatabase.Refresh();

            Builder.Bsn_Build(BuildTarget.Android);

            for (int i = 0; i < strAndriodPath.Length; i++) {
                FileInfo fInfo = new FileInfo(strAndriodPath[i]);
                if (fInfo.Exists) {
                    fInfo.MoveTo(strSrcPath[i]);
                }
            }
        }
        #endregion

        [MenuItem("Bsn/All", false, 101)]
        public static void Bsn_All() {
            Debug.Log("NBsnEditor.Menu Bsn_All()");

            AssetDatabase.Refresh();

            ToLuaMenu.beAutoGen = true;
            ToLuaMenu.ClearLuaWraps();
            ToLuaMenu.ClearBaseTypeLuaWrap();
            AssetDatabase.Refresh();

            var staticClassTypes_back = CustomSettings.staticClassTypes;
            var staticClassTypes_new = new List<Type>();
            staticClassTypes_new.AddRange(staticClassTypes_back);
            staticClassTypes_new.AddRange(NBsn.Config.m_reg2LuaStaticType);

            HashSet<Type> set = new HashSet<Type>();
            var customTypeList_back = CustomSettings.customTypeList;
            List<Type> reg2LuaType = new List<Type>();
            reg2LuaType.AddRange(NBsn.Config.m_reg2LuaType);
            GetUnityEngine(ref reg2LuaType);
            GetCustom(ref reg2LuaType);
            GetUGUI(ref reg2LuaType);
            for (int i = 0; i < reg2LuaType.Count; i++) {
                set.Add(reg2LuaType[i]);
            }
            for (int i = 0; i < customTypeList_back.Length; i++) {
                set.Add(reg2LuaType[i]);
            }
            foreach (var item in staticClassTypes_new) {
                set.Add(item);
            }
            foreach (var item in CustomSettings.dynamicList) {
                set.Add(item);
            }
            foreach (var item in ms_reg2LuaType) {
                set.Add(item);
            }
            foreach (var item in ToLuaMenu.dropType) {
                set.Remove(item);
            }
            foreach (var item in ToLuaMenu.baseType) {
                set.Remove(item);
            }

            var temp = new List<BindType>();
            foreach  (var t in set) {
                if (t.GetCustomAttributes(typeof(ObsoleteAttribute), false).Length > 0) { // 废弃类型
                    continue;
                }
                if (t.GetCustomAttributes(typeof(NBsn.NotReg2LuaAttribute), false).Length > 0) { // 不需要注册的类型
                    continue;
                }
                temp.Add(new BindType(t));
            }
            var customTypeList_new = new BindType[temp.Count];
            temp.CopyTo(customTypeList_new);

            CustomSettings.customTypeList   = customTypeList_new;
            CustomSettings.staticClassTypes = staticClassTypes_new;

            ToLuaMenu.GenBaseTypeLuaWrap();
            ToLuaMenu.GenLuaDelegates();
            ToLuaMenu.GenerateClassWraps();
            ToLuaMenu.GenLuaBinder();
            ToLuaMenu.beAutoGen = false;

            CustomSettings.customTypeList   = customTypeList_back;
            CustomSettings.staticClassTypes = staticClassTypes_back;
        }

        static List<Type> ms_reg2LuaType = new List<Type>{ // 没有自动导出 需要手动导出
            typeof(System.Attribute),
        };

        static List<Type> ms_reg2LuaType_UnityEngine = new List<Type>{ // UnityEngine 没有自动导出 需要手动导出
            typeof(UnityEngine.TrackedReference),
            typeof(UnityEngine.Experimental.Director.DirectorPlayer),
            typeof(UnityEngine.Events.UnityEvent),
            typeof(UnityEngine.Events.UnityEventBase),
            typeof(UnityEngine.Events.UnityEvent<int>),
            typeof(UnityEngine.Events.UnityEvent<string>),
            typeof(UnityEngine.Events.UnityEvent<bool>),
            typeof(UnityEngine.Events.UnityEvent<float>),
            typeof(UnityEngine.Events.UnityEvent<UnityEngine.Vector2>),
            typeof(UnityEngine.EventSystems.BaseEventData),
            typeof(UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.BaseEventData>),
        };
        static List<string> ms_noUseNameList_UnityEngine = new List<string> { // UnityEngine 不需要导出的
            "HideInInspector",
            "ExecuteInEditMode",
            "AddComponentMenu",
            "ContextMenu",
            "RequireComponent",
            "DisallowMultipleComponent",
            "SerializeField",
            "AssemblyIsEditorAssembly",
            "Attribute", 
            "Types",
            "UnitySurrogateSelector",
            "TrackedReference",
            "TypeInferenceRules",
            "FFTWindow",
            "RPC",
            "MasterServer",
            "BitStream",
            "HostData",
            "ConnectionTesterStatus",
            "EventType",
            "EventModifiers",
            "FontStyle",
            "TextAlignment",
            "TextEditor",
            "TextEditorDblClickSnapping",
            "TextGenerator",
            "TextClipping",
            "Gizmos",
            "ADBannerView",
            "ADInterstitialAd",            
            "Android",
            "jvalue",
            "iPhone",
            "iOS",
            "CalendarIdentifier",
            "CalendarUnit",
            "CalendarUnit",
            "FullScreenMovieControlMode",
            "FullScreenMovieScalingMode",
            "Handheld",
            "LocalNotification",
            "NotificationServices",
            "RemoteNotificationType",      
            "RemoteNotification",
            "SamsungTV",
            "TextureCompressionQuality",
            "TouchScreenKeyboardType",
            "TouchScreenKeyboard",
            //"MovieTexture",
            "UnityEngineInternal",
            "Terrain",                            
            "Tree",
            "SplatPrototype",
            "DetailPrototype",
            "DetailRenderMode",
            "MeshSubsetCombineUtility",
            "AOT",
            "Social",
            "Enumerator",       
            "SendMouseEvents",               
            "Cursor",
            "Flash",
            "ActionScript",
            "OnRequestRebuild",
			"Ping",
            "ShaderVariantCollection",
			"SimpleJson.Reflection",
            "Advertisements",
            "ClusterInput",
            "ClusterInputType",
            "Tizen",
            "JetBrains",
            "AccelerationEvent",
            //"AnchoredJoint2D",
            //"AreaEffector2D",
            "Assertions",
            "Audio",
            "Compute",
            "Constant",
            "Driven",
            "DynamicGI",
            "Experimental",
            "Gradient",
            "HingeJoint",
            //"ImageEffect",
            "IMECompositionMode",
            "Joint",
            "NPOTSupport",
            //"OffMeshLink",
            //"Particle",
            "Procedural",
            //"Rigidbody",
            //"SurfaceEffector2D",
            //"TargetJoint2D",
            "TexGenMode",
            "VR.VR",
            "Wheel",
            "WindZone",
            "AnimationBlendMode",
            "AnimationClipPair",
            "AnimationCullingType",
            "AnimationCurve",
            "AnimationEvent",
            "AnimationPlayMode",
            "AnimatorClipInfo",
            "AnimatorControllerParameter",
            "AnimatorControllerParameterType",
            "AnimatorCullingMode",
            "AnimatorRecorderMode",
            "AnimatorStateInfo",
            "AnimatorTransitionInfo",
            "AnimatorUpdateMode",
            "AnisotropicFiltering",
            "ApplicationInstallMode",
            "ApplicationSandboxType",
            "Avatar",
            "Billboard",
            "BlendWeights",
            "BoneWeight",
            "BoundingSphere",
            "BuoyancyEffector2D",
            "CharacterJoint",
            "Cloth",
            "CullingGroup",
            "CustomYieldInstruction",
            "Flare",
            "ForceMode",
            "Gyroscope",
            "HideFlags",
            "HorizontalWrapMode",
            "Human",
            "LensFlare",
            "Location",
            "MatchTargetWeightMask",
            "Microphone",
            "Exception",
            "Occlusion",
            "PhysicMaterial",
            //"PhysicsUpdateBehaviour2D",
            //"PlatformEffector2D",
            //"PointEffector2D",
            //"PolygonCollider2D",
            "QualitySettings",
            "QueryTriggerInteraction",
            "ReflectionProbe",
            "RenderBufferLoadAction",
            "RenderBufferStoreAction",
            "RenderTargetIdentifier",
            "ShadowSamplingMode",
            "SphericalHarmonicsL2",
            "ReflectionProbe",
            "RotationDriveMod",
            "RuntimeInitializeLoadType",
            "SparseTexture",
            "TransparencySortMode",
            "VerticalWrapMode",
            "Caching",
            "ColorSpace",
            "CrashReport",
            "Display",
            //"EdgeCollider2D",
            "Effector",
            "Keyframe",
            "LightmapsMode",
            "LightProbe",
            "PlayMode",
            "RenderingPath",
            "StackTrace",
            "Texture3D",
            "ThreadPriority",
            "UserAuthorization",
            "WaitUntil",
            "WaitWhile",
            "WebCam",
            // bsn
            "UnityEvent", // 会报错
            "Coroutine", // ToLuaMenu.ClearBaseTypeLuaWrap 已包含
            "ClusterNetwork", // error CS0234: The type or namespace name `ClusterNetwork' does not exist in the namespace `UnityEngine'. Are you missing an assembly reference?
            "MovieTexture", // error CS0234: 
            "WSA", // error CS0234: 
            "Apple", // error CS0234: 
            "EventProvider", // error CS0234: 
        };
        public static void GetUnityEngine(ref List<Type> reg2LuaType) {       
            Assembly assembly = Assembly.Load("UnityEngine");
            Type[] types = assembly.GetExportedTypes();
            foreach (Type t in types) {
                if (typeof(System.MulticastDelegate).IsAssignableFrom(t)){
                    continue;
                }

                if (t.IsInterface) {
                    continue;
                }

                bool bExport = true;
                foreach (string str in ms_noUseNameList_UnityEngine) {
                    if (t.FullName.Contains(str)) {
                        bExport = false;
                        break;
                    }                         
                }

                if (bExport) {
                    reg2LuaType.Add(t);
                }
            }
            reg2LuaType.AddRange(ms_reg2LuaType_UnityEngine);
        }

        static List<string> ms_noUseNameList_UnityEngineUI = new List<string> {
            "CoroutineTween",
            "BaseVertexEffect", // use BaseMeshEffect
            "GraphicRebuildTracker", // error CS0234: 
        };
        public static void GetUGUI(ref List<Type> reg2LuaType) {        
            Assembly assembly = Assembly.Load("UnityEngine.UI");
            Type[] types = assembly.GetExportedTypes();
            foreach (Type t in types) {
                if (typeof(System.MulticastDelegate).IsAssignableFrom(t)){
                    continue;
                }
                if (t.IsInterface) {
                    continue;
                }

                bool bExport = true;
                foreach (string str in ms_noUseNameList_UnityEngineUI) {
                    if (t.FullName.Contains(str)) {
                        bExport = false;
                        break;
                    }                         
                }

                if (bExport) {
                    reg2LuaType.Add(t);
                }
            }
        }

        public static void GetCustom(ref List<Type> reg2LuaType) {            
            Assembly assembly = Assembly.Load("Assembly-CSharp");
            Type[] types = assembly.GetExportedTypes();
			foreach (Type t in types) {
				if (t.GetCustomAttributes(typeof(NBsn.Reg2LuaAttribute), false).Length > 0) {
                    reg2LuaType.Add(t);
				}
			}
        }
    }
}
