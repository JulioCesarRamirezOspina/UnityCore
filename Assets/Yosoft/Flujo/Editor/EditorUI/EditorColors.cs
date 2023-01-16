//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System;
using System.Diagnostics.CodeAnalysis;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.Colors;
using UnityEngine;

namespace Yosoft.Flujo.Editor.EditorUI
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Local")]
    public static class EditorColors
    {
        public static class Unity
        {
            public static Color GetColor(ColorName colorName)
            {
                switch (colorName)
                {
                    case ColorName.Dark:
                        return new Color().From256(56, 56, 56);
                    case ColorName.Light:
                        return new Color().From256(194, 194, 194);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(colorName), colorName, null);
                }
            }

            public enum ColorName
            {
                Dark,
                Light
            }

            private static Color? s_Dark;
            private static Color Dark => (Color)(s_Dark = s_Dark ?? GetColor(ColorName.Dark));
            private static Color? s_Light;
            private static Color Light => (Color)(s_Light = s_Light ?? GetColor(ColorName.Light));
        }
    
        public static class Default
        {
            private static EditorDataColorPalette s_colorPalette;
            private static EditorDataColorPalette colorPalette =>
                s_colorPalette != null
                    ? s_colorPalette
                    : s_colorPalette = EditorDataColorDatabase.GetColorPalette("Default");
            
            public static Color GetColor(ColorName colorName) =>
                colorPalette.GetColor(colorName.ToString());
                
            public enum ColorName
            {
                Action,
                Add,
                Background,
                BoxBackground,
                ButtonIdleColor,
                EditorStatusError,
                EditorStatusInfo,
                EditorStatusOk,
                EditorStatusWarning,
                FieldBackground,
                FieldIcon,
                Icon,
                MenuBackgroundLevel0,
                MenuBackgroundLevel1,
                MenuBackgroundLevel2,
                Placeholder,
                Remove,
                Selection,
                TextDescription,
                TextSubtitle,
                TextTitle,
                UnityTheme,
                UnityThemeInversed,
                WindowHeaderBackground,
                WindowHeaderIcon,
                WindowHeaderSubtitle,
                WindowHeaderTitle
            }
            

            private static Color? s_Action;
            public static Color Action => (Color) (s_Action ?? (s_Action = GetColor(ColorName.Action)));
            private static Color? s_Add;
            public static Color Add => (Color) (s_Add ?? (s_Add = GetColor(ColorName.Add)));
            private static Color? s_Background;
            public static Color Background => (Color) (s_Background ?? (s_Background = GetColor(ColorName.Background)));
            private static Color? s_BoxBackground;
            public static Color BoxBackground => (Color) (s_BoxBackground ?? (s_BoxBackground = GetColor(ColorName.BoxBackground)));
            private static Color? s_ButtonIdleColor;
            public static Color ButtonIdleColor => (Color) (s_ButtonIdleColor ?? (s_ButtonIdleColor = GetColor(ColorName.ButtonIdleColor)));
            private static Color? s_EditorStatusError;
            public static Color EditorStatusError => (Color) (s_EditorStatusError ?? (s_EditorStatusError = GetColor(ColorName.EditorStatusError)));
            private static Color? s_EditorStatusInfo;
            public static Color EditorStatusInfo => (Color) (s_EditorStatusInfo ?? (s_EditorStatusInfo = GetColor(ColorName.EditorStatusInfo)));
            private static Color? s_EditorStatusOk;
            public static Color EditorStatusOk => (Color) (s_EditorStatusOk ?? (s_EditorStatusOk = GetColor(ColorName.EditorStatusOk)));
            private static Color? s_EditorStatusWarning;
            public static Color EditorStatusWarning => (Color) (s_EditorStatusWarning ?? (s_EditorStatusWarning = GetColor(ColorName.EditorStatusWarning)));
            private static Color? s_FieldBackground;
            public static Color FieldBackground => (Color) (s_FieldBackground ?? (s_FieldBackground = GetColor(ColorName.FieldBackground)));
            private static Color? s_FieldIcon;
            public static Color FieldIcon => (Color) (s_FieldIcon ?? (s_FieldIcon = GetColor(ColorName.FieldIcon)));
            private static Color? s_Icon;
            public static Color Icon => (Color) (s_Icon ?? (s_Icon = GetColor(ColorName.Icon)));
            private static Color? s_MenuBackgroundLevel0;
            public static Color MenuBackgroundLevel0 => (Color) (s_MenuBackgroundLevel0 ?? (s_MenuBackgroundLevel0 = GetColor(ColorName.MenuBackgroundLevel0)));
            private static Color? s_MenuBackgroundLevel1;
            public static Color MenuBackgroundLevel1 => (Color) (s_MenuBackgroundLevel1 ?? (s_MenuBackgroundLevel1 = GetColor(ColorName.MenuBackgroundLevel1)));
            private static Color? s_MenuBackgroundLevel2;
            public static Color MenuBackgroundLevel2 => (Color) (s_MenuBackgroundLevel2 ?? (s_MenuBackgroundLevel2 = GetColor(ColorName.MenuBackgroundLevel2)));
            private static Color? s_Placeholder;
            public static Color Placeholder => (Color) (s_Placeholder ?? (s_Placeholder = GetColor(ColorName.Placeholder)));
            private static Color? s_Remove;
            public static Color Remove => (Color) (s_Remove ?? (s_Remove = GetColor(ColorName.Remove)));
            private static Color? s_Selection;
            public static Color Selection => (Color) (s_Selection ?? (s_Selection = GetColor(ColorName.Selection)));
            private static Color? s_TextDescription;
            public static Color TextDescription => (Color) (s_TextDescription ?? (s_TextDescription = GetColor(ColorName.TextDescription)));
            private static Color? s_TextSubtitle;
            public static Color TextSubtitle => (Color) (s_TextSubtitle ?? (s_TextSubtitle = GetColor(ColorName.TextSubtitle)));
            private static Color? s_TextTitle;
            public static Color TextTitle => (Color) (s_TextTitle ?? (s_TextTitle = GetColor(ColorName.TextTitle)));
            private static Color? s_UnityTheme;
            public static Color UnityTheme => (Color) (s_UnityTheme ?? (s_UnityTheme = GetColor(ColorName.UnityTheme)));
            private static Color? s_UnityThemeInversed;
            public static Color UnityThemeInversed => (Color) (s_UnityThemeInversed ?? (s_UnityThemeInversed = GetColor(ColorName.UnityThemeInversed)));
            private static Color? s_WindowHeaderBackground;
            public static Color WindowHeaderBackground => (Color) (s_WindowHeaderBackground ?? (s_WindowHeaderBackground = GetColor(ColorName.WindowHeaderBackground)));
            private static Color? s_WindowHeaderIcon;
            public static Color WindowHeaderIcon => (Color) (s_WindowHeaderIcon ?? (s_WindowHeaderIcon = GetColor(ColorName.WindowHeaderIcon)));
            private static Color? s_WindowHeaderSubtitle;
            public static Color WindowHeaderSubtitle => (Color) (s_WindowHeaderSubtitle ?? (s_WindowHeaderSubtitle = GetColor(ColorName.WindowHeaderSubtitle)));
            private static Color? s_WindowHeaderTitle;
            public static Color WindowHeaderTitle => (Color) (s_WindowHeaderTitle ?? (s_WindowHeaderTitle = GetColor(ColorName.WindowHeaderTitle)));
          
        }

        public static class EditorUI
        {
            private static EditorDataColorPalette s_colorPalette;
            private static EditorDataColorPalette colorPalette =>
                s_colorPalette != null
                    ? s_colorPalette
                    : s_colorPalette = EditorDataColorDatabase.GetColorPalette("EditorUI");
            
            public static Color GetColor(ColorName colorName) =>
                colorPalette.GetColor(colorName.ToString());
                
            public enum ColorName
            {
                Amber,
                Black,
                Blue,
                Cyan,
                DeepOrange,
                DeepPurple,
                Gray,
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
                White,
                Yellow
            }
            

            private static Color? s_Amber;
            public static Color Amber => (Color) (s_Amber ?? (s_Amber = GetColor(ColorName.Amber)));
            private static Color? s_Black;
            public static Color Black => (Color) (s_Black ?? (s_Black = GetColor(ColorName.Black)));
            private static Color? s_Blue;
            public static Color Blue => (Color) (s_Blue ?? (s_Blue = GetColor(ColorName.Blue)));
            private static Color? s_Cyan;
            public static Color Cyan => (Color) (s_Cyan ?? (s_Cyan = GetColor(ColorName.Cyan)));
            private static Color? s_DeepOrange;
            public static Color DeepOrange => (Color) (s_DeepOrange ?? (s_DeepOrange = GetColor(ColorName.DeepOrange)));
            private static Color? s_DeepPurple;
            public static Color DeepPurple => (Color) (s_DeepPurple ?? (s_DeepPurple = GetColor(ColorName.DeepPurple)));
            private static Color? s_Gray;
            public static Color Gray => (Color) (s_Gray ?? (s_Gray = GetColor(ColorName.Gray)));
            private static Color? s_Green;
            public static Color Green => (Color) (s_Green ?? (s_Green = GetColor(ColorName.Green)));
            private static Color? s_Indigo;
            public static Color Indigo => (Color) (s_Indigo ?? (s_Indigo = GetColor(ColorName.Indigo)));
            private static Color? s_LightBlue;
            public static Color LightBlue => (Color) (s_LightBlue ?? (s_LightBlue = GetColor(ColorName.LightBlue)));
            private static Color? s_LightGreen;
            public static Color LightGreen => (Color) (s_LightGreen ?? (s_LightGreen = GetColor(ColorName.LightGreen)));
            private static Color? s_Lime;
            public static Color Lime => (Color) (s_Lime ?? (s_Lime = GetColor(ColorName.Lime)));
            private static Color? s_Orange;
            public static Color Orange => (Color) (s_Orange ?? (s_Orange = GetColor(ColorName.Orange)));
            private static Color? s_Pink;
            public static Color Pink => (Color) (s_Pink ?? (s_Pink = GetColor(ColorName.Pink)));
            private static Color? s_Purple;
            public static Color Purple => (Color) (s_Purple ?? (s_Purple = GetColor(ColorName.Purple)));
            private static Color? s_Red;
            public static Color Red => (Color) (s_Red ?? (s_Red = GetColor(ColorName.Red)));
            private static Color? s_Teal;
            public static Color Teal => (Color) (s_Teal ?? (s_Teal = GetColor(ColorName.Teal)));
            private static Color? s_White;
            public static Color White => (Color) (s_White ?? (s_White = GetColor(ColorName.White)));
            private static Color? s_Yellow;
            public static Color Yellow => (Color) (s_Yellow ?? (s_Yellow = GetColor(ColorName.Yellow)));
          
        }

        public static class PruebaColor
        {
            private static EditorDataColorPalette s_colorPalette;
            private static EditorDataColorPalette colorPalette =>
                s_colorPalette != null
                    ? s_colorPalette
                    : s_colorPalette = EditorDataColorDatabase.GetColorPalette("PruebaColor");
            
            public static Color GetColor(ColorName colorName) =>
                colorPalette.GetColor(colorName.ToString());
                
            public enum ColorName
            {
                Primary
            }
            

            private static Color? s_Primary;
            public static Color Primary => (Color) (s_Primary ?? (s_Primary = GetColor(ColorName.Primary)));
          
        }

        public static class Reactor
        {
            private static EditorDataColorPalette s_colorPalette;
            private static EditorDataColorPalette colorPalette =>
                s_colorPalette != null
                    ? s_colorPalette
                    : s_colorPalette = EditorDataColorDatabase.GetColorPalette("Reactor");
            
            public static Color GetColor(ColorName colorName) =>
                colorPalette.GetColor(colorName.ToString());
                
            public enum ColorName
            {
                Fade,
                Gray,
                Green,
                Move,
                Red,
                Rotate,
                Scale
            }
            

            private static Color? s_Fade;
            public static Color Fade => (Color) (s_Fade ?? (s_Fade = GetColor(ColorName.Fade)));
            private static Color? s_Gray;
            public static Color Gray => (Color) (s_Gray ?? (s_Gray = GetColor(ColorName.Gray)));
            private static Color? s_Green;
            public static Color Green => (Color) (s_Green ?? (s_Green = GetColor(ColorName.Green)));
            private static Color? s_Move;
            public static Color Move => (Color) (s_Move ?? (s_Move = GetColor(ColorName.Move)));
            private static Color? s_Red;
            public static Color Red => (Color) (s_Red ?? (s_Red = GetColor(ColorName.Red)));
            private static Color? s_Rotate;
            public static Color Rotate => (Color) (s_Rotate ?? (s_Rotate = GetColor(ColorName.Rotate)));
            private static Color? s_Scale;
            public static Color Scale => (Color) (s_Scale ?? (s_Scale = GetColor(ColorName.Scale)));
          
        }

        public static class UIManager
        {
            private static EditorDataColorPalette s_colorPalette;
            private static EditorDataColorPalette colorPalette =>
                s_colorPalette != null
                    ? s_colorPalette
                    : s_colorPalette = EditorDataColorDatabase.GetColorPalette("UIManager");
            
            public static Color GetColor(ColorName colorName) =>
                colorPalette.GetColor(colorName.ToString());
                
            public enum ColorName
            {
                AudioComponent,
                InputComponent,
                LayoutComponent,
                ListenerComponent,
                Settings,
                UIComponent,
                UIMenuItemBackground,
                VisualComponent
            }
            

            private static Color? s_AudioComponent;
            public static Color AudioComponent => (Color) (s_AudioComponent ?? (s_AudioComponent = GetColor(ColorName.AudioComponent)));
            private static Color? s_InputComponent;
            public static Color InputComponent => (Color) (s_InputComponent ?? (s_InputComponent = GetColor(ColorName.InputComponent)));
            private static Color? s_LayoutComponent;
            public static Color LayoutComponent => (Color) (s_LayoutComponent ?? (s_LayoutComponent = GetColor(ColorName.LayoutComponent)));
            private static Color? s_ListenerComponent;
            public static Color ListenerComponent => (Color) (s_ListenerComponent ?? (s_ListenerComponent = GetColor(ColorName.ListenerComponent)));
            private static Color? s_Settings;
            public static Color Settings => (Color) (s_Settings ?? (s_Settings = GetColor(ColorName.Settings)));
            private static Color? s_UIComponent;
            public static Color UIComponent => (Color) (s_UIComponent ?? (s_UIComponent = GetColor(ColorName.UIComponent)));
            private static Color? s_UIMenuItemBackground;
            public static Color UIMenuItemBackground => (Color) (s_UIMenuItemBackground ?? (s_UIMenuItemBackground = GetColor(ColorName.UIMenuItemBackground)));
            private static Color? s_VisualComponent;
            public static Color VisualComponent => (Color) (s_VisualComponent ?? (s_VisualComponent = GetColor(ColorName.VisualComponent)));
          
        }
    }
}