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
    }
}