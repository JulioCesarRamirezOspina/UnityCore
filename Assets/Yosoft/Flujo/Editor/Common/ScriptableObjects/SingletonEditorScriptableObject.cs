using UnityEditor;
using UnityEngine;
using Yosoft.Flujo.Runtime.Common.Utils;

// ReSharper disable MemberCanBeProtected.Global

namespace Yosoft.Flujo.Editor.Common.ScriptableObjects
{
    public abstract class SingletonEditorScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        private static string dataFolderPath => $"{EditorPath.path}/Data";
        private static string dataFileName => $"{typeof(T).Name}.asset";
        private static string dataFilePath => $"{dataFolderPath}/{dataFileName}";

        private static T s_instance;

        public static T instance
        {
            get
            {
                if (s_instance != null) return s_instance;
                s_instance = AssetDatabase.LoadAssetAtPath<T>(dataFilePath);
                if (s_instance != null) return s_instance;
                s_instance = CreateInstance<T>();
                PathUtils.CreatePath(dataFolderPath);
                AssetDatabase.CreateAsset(s_instance, dataFilePath);
                return s_instance;
            }
        }

        public static void Restore()
        {
            EditorUtility.SetDirty(instance);
            AssetDatabase.SaveAssetIfDirty(instance);
        }

        public static void UndoRecord(string message)
        {
            Undo.RecordObject(instance, message);
            EditorUtility.SetDirty(instance);
        }

        public static void Save(bool refreshAssetDatabase = false)
        {
            EditorUtility.SetDirty(instance);
            AssetDatabase.SaveAssetIfDirty(instance);
            if (refreshAssetDatabase) AssetDatabase.Refresh();
        }
    }
}
