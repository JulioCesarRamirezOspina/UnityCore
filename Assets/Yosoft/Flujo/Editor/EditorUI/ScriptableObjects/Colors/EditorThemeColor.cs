using System;
using UnityEditor;
using Yosoft.Flujo.Runtime.Colors;

namespace Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors
{
    [Serializable]
    public class EditorThemeColor : ThemeColor
    {
        public override bool isDarkTheme => EditorGUIUtility.isProSkin;
    }
}
