using System;
using UnityEngine;

namespace Yosoft.Flujo.Runtime.Colors
{
    /// <summary>
    /// A pair of colors, one for a dark theme and one for a light theme
    /// </summary>
    [Serializable]
    public class ThemeColor
    {
        /// <summary> Returns TRUE if the dark theme is active </summary>
        public virtual bool isDarkTheme { get; set; }

        /// <summary> Color for the dark theme </summary>
        public Color ColorOnDark;
        /// <summary> Color for the light theme </summary>
        public Color ColorOnLight;

        /// <summary> If isDarkTheme is TRUE it returns the color on dark, otherwise it returns the color on light </summary>
        public Color color =>
            isDarkTheme
                ? ColorOnDark
                : ColorOnLight;

        /// <summary>
        /// Construct a new <see cref="ThemeColor"/>
        /// </summary>
        public ThemeColor()
        {
            ColorOnDark = ColorOnLight = Color.white;
        }
    }
}
