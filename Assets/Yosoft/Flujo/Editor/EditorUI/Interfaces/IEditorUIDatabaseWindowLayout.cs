using System.Collections.Generic;
using UnityEngine;

namespace Yosoft.Flujo.Editor.EditorUI
{
    public interface IEditorUIDatabaseWindowLayout //: ISearchable
    {
        string layoutName { get; }
        Texture2D staticIconTexture { get; }
        List<Texture2D> animatedIconTextures { get; }
    }
}
