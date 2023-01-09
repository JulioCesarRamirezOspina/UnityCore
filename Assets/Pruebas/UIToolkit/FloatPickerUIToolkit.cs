namespace Pruebas.UIToolkit
{
    using UnityEngine;
#if UNITY_EDITOR
    using UnityEngine.UIElements;
    using UnityEditor.UIElements;
    using UnityEditor;
#endif

    public class FloatPickerUIToolkit : MonoBehaviour
    {
        [FloatPickerUIToolkit(options = new float[] { 10, 20, 30 })]
        public float someFloat;
    }

    public class FloatPickerUIToolkitAttribute : PropertyAttribute
    {
        public float[] options;
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(FloatPickerUIToolkit))]
    public class FloatPickerUIToolkitEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var container = new VisualElement();
            var property = serializedObject.GetIterator();
            if (property.NextVisible(true))
            {
                do
                {
                    var propertyField = new PropertyField(property.Copy());
                    if (property.propertyPath == "m_Script")
                        propertyField.SetEnabled(false);
                    container.Add(propertyField);
                } while (property.NextVisible(false));
            }

            return container;
        }
    }


    [CustomPropertyDrawer(typeof(FloatPickerUIToolkitAttribute))]
    public class FloatPickerUIToolkitAttributeDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var attr = (FloatPickerUIToolkitAttribute)attribute;
            var container = new VisualElement();
            container.style.flexDirection = FlexDirection.Row;
            var floatField = new FloatField()
            {
                label = property.displayName,
                style =
                {
                    flexGrow = 1,
                },
            };
            floatField.Q<Label>().AddToClassList("unity-propertyfield__label");
            floatField.BindProperty(property);
            container.Add(floatField);
            container.Add(new Button(() =>
            {
                var menu = new GenericMenu();
                foreach (var option in attr.options)
                {
                    menu.AddItem(new GUIContent(option.ToString()),
                        false, () =>
                        {
                            // set the property value to selected
                            property.floatValue = option;
                            // Apply the modified values
                            property.serializedObject.ApplyModifiedProperties();
                        });
                }

                menu.ShowAsContext();
            })
            {
                text = "..."
            });
            return container;
        }
    }
#endif
}