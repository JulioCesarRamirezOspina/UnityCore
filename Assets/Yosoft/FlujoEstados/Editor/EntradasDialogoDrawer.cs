using FlujoEstados.Runtime;
using UnityEditor;
using UnityEngine;

namespace FlujoEstados.Editor
{
    [CustomPropertyDrawer(typeof(EntradasDialogo))]
    public class EntradasDialogoDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight * 2;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            // Core GUI code here
            var characterRect = new Rect(position.x, position.y, 100, position.height);
            var contentRect = new Rect(characterRect.xMax, position.y, position.width - characterRect.width, position.height);
            EditorGUI.PropertyField(characterRect, property.FindPropertyRelative("caracter"), GUIContent.none);
            EditorGUI.PropertyField(contentRect, property.FindPropertyRelative("contenido"), GUIContent.none);
            EditorGUI.EndProperty();
        }
    }
}