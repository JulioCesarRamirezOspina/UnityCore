using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(EditorColorInfo))]
    public class EditorColorInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            TemplateContainer drawer = EditorLayouts.EditorUI.EditorColorInfo.CloneTree();
            drawer.AddStyle(EditorStyles.EditorUI.EditorColorInfo);
            drawer.Q<VisualElement>("LayoutContainer").SetStyleBackgroundColor(EditorColors.Default.FieldBackground);
            return drawer;
        }
    }
}
