// Copyright (c) 2023 Yosoft Creativo Todos los derechos reservados.

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Diagnostics.CodeAnalysis;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.Colors;
using UnityEngine;

namespace Yosoft.Flujo.Editor.EditorUI
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class EditorSelectableColors
    {
        public static class Default
        {
            private static EditorDataSelectableColorPalette s_selectableColorPalette;
            private static EditorDataSelectableColorPalette selectableColorPalette =>
                s_selectableColorPalette != null
                    ? s_selectableColorPalette
                    : s_selectableColorPalette = EditorDataSelectableColorDatabase.GetSelectableColorPalette("Default");

            public static Color GetColor(ColorName colorName, SelectionState state) =>
                selectableColorPalette.GetColor(colorName.ToString(), state);

            public static EditorThemeColor GetThemeColor(ColorName colorName, SelectionState state) =>
                selectableColorPalette.GetThemeColor(colorName.ToString(), state);

            public static EditorSelectableColorInfo GetSelectableColorInfo(ColorName colorName) =>
                selectableColorPalette.GetSelectableColorInfo(colorName.ToString());
            
            public enum ColorName
            {
                Action,
                Add,
                ButtonContainer,
                ButtonIcon,
                ButtonText,
                MenuButtonBackgroundLevel0,
                MenuButtonBackgroundLevel1,
                MenuButtonBackgroundLevel2,
                Remove,
                ToggleOffIcon,
                ToggleOffText,
                UnityTheme,
                UnityThemeInversed
            }
            

            private static EditorSelectableColorInfo s_Action;
            public static EditorSelectableColorInfo Action => s_Action ?? (s_Action = GetSelectableColorInfo(ColorName.Action));
            private static EditorSelectableColorInfo s_Add;
            public static EditorSelectableColorInfo Add => s_Add ?? (s_Add = GetSelectableColorInfo(ColorName.Add));
            private static EditorSelectableColorInfo s_ButtonContainer;
            public static EditorSelectableColorInfo ButtonContainer => s_ButtonContainer ?? (s_ButtonContainer = GetSelectableColorInfo(ColorName.ButtonContainer));
            private static EditorSelectableColorInfo s_ButtonIcon;
            public static EditorSelectableColorInfo ButtonIcon => s_ButtonIcon ?? (s_ButtonIcon = GetSelectableColorInfo(ColorName.ButtonIcon));
            private static EditorSelectableColorInfo s_ButtonText;
            public static EditorSelectableColorInfo ButtonText => s_ButtonText ?? (s_ButtonText = GetSelectableColorInfo(ColorName.ButtonText));
            private static EditorSelectableColorInfo s_MenuButtonBackgroundLevel0;
            public static EditorSelectableColorInfo MenuButtonBackgroundLevel0 => s_MenuButtonBackgroundLevel0 ?? (s_MenuButtonBackgroundLevel0 = GetSelectableColorInfo(ColorName.MenuButtonBackgroundLevel0));
            private static EditorSelectableColorInfo s_MenuButtonBackgroundLevel1;
            public static EditorSelectableColorInfo MenuButtonBackgroundLevel1 => s_MenuButtonBackgroundLevel1 ?? (s_MenuButtonBackgroundLevel1 = GetSelectableColorInfo(ColorName.MenuButtonBackgroundLevel1));
            private static EditorSelectableColorInfo s_MenuButtonBackgroundLevel2;
            public static EditorSelectableColorInfo MenuButtonBackgroundLevel2 => s_MenuButtonBackgroundLevel2 ?? (s_MenuButtonBackgroundLevel2 = GetSelectableColorInfo(ColorName.MenuButtonBackgroundLevel2));
            private static EditorSelectableColorInfo s_Remove;
            public static EditorSelectableColorInfo Remove => s_Remove ?? (s_Remove = GetSelectableColorInfo(ColorName.Remove));
            private static EditorSelectableColorInfo s_ToggleOffIcon;
            public static EditorSelectableColorInfo ToggleOffIcon => s_ToggleOffIcon ?? (s_ToggleOffIcon = GetSelectableColorInfo(ColorName.ToggleOffIcon));
            private static EditorSelectableColorInfo s_ToggleOffText;
            public static EditorSelectableColorInfo ToggleOffText => s_ToggleOffText ?? (s_ToggleOffText = GetSelectableColorInfo(ColorName.ToggleOffText));
            private static EditorSelectableColorInfo s_UnityTheme;
            public static EditorSelectableColorInfo UnityTheme => s_UnityTheme ?? (s_UnityTheme = GetSelectableColorInfo(ColorName.UnityTheme));
            private static EditorSelectableColorInfo s_UnityThemeInversed;
            public static EditorSelectableColorInfo UnityThemeInversed => s_UnityThemeInversed ?? (s_UnityThemeInversed = GetSelectableColorInfo(ColorName.UnityThemeInversed));
            
        }

        public static class EditorUI
        {
            private static EditorDataSelectableColorPalette s_selectableColorPalette;
            private static EditorDataSelectableColorPalette selectableColorPalette =>
                s_selectableColorPalette != null
                    ? s_selectableColorPalette
                    : s_selectableColorPalette = EditorDataSelectableColorDatabase.GetSelectableColorPalette("EditorUI");

            public static Color GetColor(ColorName colorName, SelectionState state) =>
                selectableColorPalette.GetColor(colorName.ToString(), state);

            public static EditorThemeColor GetThemeColor(ColorName colorName, SelectionState state) =>
                selectableColorPalette.GetThemeColor(colorName.ToString(), state);

            public static EditorSelectableColorInfo GetSelectableColorInfo(ColorName colorName) =>
                selectableColorPalette.GetSelectableColorInfo(colorName.ToString());
            
            public enum ColorName
            {
                Amber,
                Blue,
                Cyan,
                DeepOrange,
                DeepPurple,
                Green,
                Indigo,
                LightBlue,
                LightGreen,
                Lime,
                Orange,
                Pink,
                Purple,
                Red,
                Teal,
                Yellow
            }
            

            private static EditorSelectableColorInfo s_Amber;
            public static EditorSelectableColorInfo Amber => s_Amber ?? (s_Amber = GetSelectableColorInfo(ColorName.Amber));
            private static EditorSelectableColorInfo s_Blue;
            public static EditorSelectableColorInfo Blue => s_Blue ?? (s_Blue = GetSelectableColorInfo(ColorName.Blue));
            private static EditorSelectableColorInfo s_Cyan;
            public static EditorSelectableColorInfo Cyan => s_Cyan ?? (s_Cyan = GetSelectableColorInfo(ColorName.Cyan));
            private static EditorSelectableColorInfo s_DeepOrange;
            public static EditorSelectableColorInfo DeepOrange => s_DeepOrange ?? (s_DeepOrange = GetSelectableColorInfo(ColorName.DeepOrange));
            private static EditorSelectableColorInfo s_DeepPurple;
            public static EditorSelectableColorInfo DeepPurple => s_DeepPurple ?? (s_DeepPurple = GetSelectableColorInfo(ColorName.DeepPurple));
            private static EditorSelectableColorInfo s_Green;
            public static EditorSelectableColorInfo Green => s_Green ?? (s_Green = GetSelectableColorInfo(ColorName.Green));
            private static EditorSelectableColorInfo s_Indigo;
            public static EditorSelectableColorInfo Indigo => s_Indigo ?? (s_Indigo = GetSelectableColorInfo(ColorName.Indigo));
            private static EditorSelectableColorInfo s_LightBlue;
            public static EditorSelectableColorInfo LightBlue => s_LightBlue ?? (s_LightBlue = GetSelectableColorInfo(ColorName.LightBlue));
            private static EditorSelectableColorInfo s_LightGreen;
            public static EditorSelectableColorInfo LightGreen => s_LightGreen ?? (s_LightGreen = GetSelectableColorInfo(ColorName.LightGreen));
            private static EditorSelectableColorInfo s_Lime;
            public static EditorSelectableColorInfo Lime => s_Lime ?? (s_Lime = GetSelectableColorInfo(ColorName.Lime));
            private static EditorSelectableColorInfo s_Orange;
            public static EditorSelectableColorInfo Orange => s_Orange ?? (s_Orange = GetSelectableColorInfo(ColorName.Orange));
            private static EditorSelectableColorInfo s_Pink;
            public static EditorSelectableColorInfo Pink => s_Pink ?? (s_Pink = GetSelectableColorInfo(ColorName.Pink));
            private static EditorSelectableColorInfo s_Purple;
            public static EditorSelectableColorInfo Purple => s_Purple ?? (s_Purple = GetSelectableColorInfo(ColorName.Purple));
            private static EditorSelectableColorInfo s_Red;
            public static EditorSelectableColorInfo Red => s_Red ?? (s_Red = GetSelectableColorInfo(ColorName.Red));
            private static EditorSelectableColorInfo s_Teal;
            public static EditorSelectableColorInfo Teal => s_Teal ?? (s_Teal = GetSelectableColorInfo(ColorName.Teal));
            private static EditorSelectableColorInfo s_Yellow;
            public static EditorSelectableColorInfo Yellow => s_Yellow ?? (s_Yellow = GetSelectableColorInfo(ColorName.Yellow));
            
        }
    }
}