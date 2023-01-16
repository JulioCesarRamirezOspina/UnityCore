using System;
using UnityEngine;
using Yosoft.Flujo.Runtime.Common.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors
{
    [Serializable]
    public class EditorColorInfo
    {
        public string ColorName;
        
        public EditorThemeColor ThemeColor;
        public Color color => ThemeColor.color;

        public EditorColorInfo(string colorName, Color colorOnDark, Color colorOnLight)
        {
            ColorName = colorName;
            ValidateName();
            ThemeColor = new EditorThemeColor
            {
                ColorOnDark = colorOnDark,
                ColorOnLight = colorOnLight
            };
        }
        
        public EditorColorInfo()
        {
            ColorName = string.Empty;
            ThemeColor = new EditorThemeColor();
        }

        public void ValidateName() =>
            ColorName = ColorName.RemoveWhitespaces().RemoveAllSpecialCharacters();
    }
}
