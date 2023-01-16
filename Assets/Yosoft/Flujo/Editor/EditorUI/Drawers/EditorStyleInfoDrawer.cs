using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Styles;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(EditorStyleInfo))]
    public class EditorStyleInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            SerializedProperty value = property.FindPropertyRelative("UssReference");
            
            var root = new ComponentField
            (
                ComponentField.Size.Small,
                string.Empty,
                new ObjectField {bindingPath = "UssReference", objectType = typeof(StyleSheet)}
            );
            return root;
        }
    }
}
