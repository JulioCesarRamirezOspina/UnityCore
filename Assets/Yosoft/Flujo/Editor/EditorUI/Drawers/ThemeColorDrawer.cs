using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Runtime.Colors;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(ThemeColor), true)]
    public class ThemeColorDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            TemplateContainer container = EditorLayouts.EditorUI.ThemeColor.CloneTree();
            container.AddStyle(EditorStyles.EditorUI.ThemeColor);
            return container;
        }
    }
}
