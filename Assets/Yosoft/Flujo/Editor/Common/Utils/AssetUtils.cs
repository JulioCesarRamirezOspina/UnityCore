using UnityEditor;
using UnityEngine;

namespace Yosoft.Flujo.Editor.Common.Utils
{
    public static class AssetUtils
    {
        /// <summary> Delete any sub objects inside a main asset </summary>
        /// <param name="mainAsset"> Target asset </param>
        public static void RemoveSubAssets(Object mainAsset)
        {
            Object[] assets = AssetDatabase.LoadAllAssetRepresentationsAtPath(AssetDatabase.GetAssetPath(mainAsset));
            foreach (Object asset in assets)
            {
                if (asset == null) continue;
                if (asset.Equals(mainAsset)) continue;
                UnityEngine.Object.DestroyImmediate(asset, true);
            }
        }
    }
}
