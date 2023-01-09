using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Pruebas.UIToolkit
{
    public class EnemigoUIToolkit : MonoBehaviour
    {
        public float health;
        public float attackPt;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(EnemigoUIToolkit)), CanEditMultipleObjects]
    public class EnemigoUIToolkitEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var container = new VisualElement();
            // Code to create VisualElement and add to the container.
            container.Add(new Button()
            {
                text = "Button in UI Toolkit!"
            });
            return container;
        }
    }
#endif
}