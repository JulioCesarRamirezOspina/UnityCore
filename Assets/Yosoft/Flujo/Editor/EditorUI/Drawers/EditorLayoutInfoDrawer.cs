using Doozy.Editor.EditorUI.ScriptableObjects.Layouts;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(EditorLayoutInfo))]
    public class EditorLayoutInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            ComponentField root =
                new ComponentField
                    (
                        ComponentField.Size.Small,
                        string.Empty,
                        new ObjectField { bindingPath = "UxmlReference", objectType = typeof(VisualTreeAsset) }
                    )
                    .SetStyleMargins(0, 2, 0, 2);
            return root;
        }
    }
}
