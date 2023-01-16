using System;
using UnityEngine.UIElements;

namespace Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Styles
{
    [Serializable]
    public class EditorStyleInfo
    {
        public StyleSheet UssReference;

        public EditorStyleInfo()
        {
            UssReference = null;
        }
    }
}
