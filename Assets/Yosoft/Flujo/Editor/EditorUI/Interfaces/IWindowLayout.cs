using System.Collections.Generic;
using UnityEngine;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;

namespace Yosoft.Flujo.Editor.EditorUI
{
    public interface IWindowLayout
    {
        string layoutName { get; }
        Texture2D staticIconTexture { get; }
        List<Texture2D> animatedIconTextures { get; }
        Color accentColor { get; }
        EditorSelectableColorInfo selectableAccentColor { get; }
    }
}
