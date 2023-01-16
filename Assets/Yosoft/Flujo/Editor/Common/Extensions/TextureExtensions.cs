using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Yosoft.Flujo.Editor.Common.Extensions
{
    public static class TextureExtensions
    {
        public static List<Texture2D> GetTextures(this Texture2D spriteSheet)
        {
            if (!spriteSheet.IsSpriteSheet()) return new List<Texture2D> { spriteSheet };
            string assetPath = AssetDatabase.GetAssetPath(spriteSheet);
            var sprites = new List<Sprite>(AssetDatabase.LoadAllAssetRepresentationsAtPath(assetPath).OfType<Sprite>());
            return sprites.ToTexture2D().ToList();
        }
        
        /// <summary> Returns TRUE if the SpriteMode is set to Multiple </summary>
        /// <param name="target"> Target Texture </param>
        public static bool IsSpriteSheet(this Texture target)
        {
            string assetPath = AssetDatabase.GetAssetPath(target);
            var textureImporter = AssetImporter.GetAtPath(assetPath) as TextureImporter;
            if (textureImporter == null) throw new NullReferenceException($"Could not load TextureImporter for '{assetPath}'");
            return textureImporter.spriteImportMode == SpriteImportMode.Multiple;
        }
    }
}
