using FlujoEstados.Runtime;
using UnityEditor;
using UnityEngine;

namespace FlujoEstados.Editor.Attributes
{
    [CustomPropertyDrawer(typeof(FloatPickerAttribute))]
    public class FloatPickerAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attr = (FloatPickerAttribute)attribute;
            EditorGUI.BeginProperty(position, label, property);
            // Core GUI code here
            var propertyRect = new Rect(position.x, position.y, position.width - 20, position.height);
            var dropdownButtonRect = new Rect(propertyRect.xMax, position.y, 20, position.height);
            EditorGUI.PropertyField(propertyRect, property);
            if (GUI.Button(dropdownButtonRect, "..."))
            {
                var menu = new GenericMenu();
                foreach (var option in attr.options)
                {
                    menu.AddItem(new GUIContent(option.ToString()), false,
                        () =>
                        {
                            // set the property value to selected
                            property.floatValue = option;
                            // Apply the modified values
                            property.serializedObject.ApplyModifiedProperties();
                        });
                }
                menu.ShowAsContext();
            }
            EditorGUI.EndProperty();
        }
    }
}
// Ahora para la parte GUI real. Al hacer una GUI en el PropertyDrawer,
//     debe manejar el cálculo del diseño usted mismo, por lo tanto, no puede usar
// EditorGUILayout. En su lugar, utiliza EditorGUI. Sin embargo, no es tan difícil.
//     Primero, calcula el tamaño Rect de la propiedad principal desde la posición (que
// es el tamaño y la posición rect de la propiedad de dibujo actual), menos su
// ancho por 20 unidades para hacer espacio para el botón desplegable. A continuación, usted
// calcule el dropdownButtonRect estableciendo la posición de inicio en xMax
// de la propiedadRect directamente y su ancho a 20 unidades. Ver listado
//
// Después del tamaño Rect, puede comenzar a dibujar la GUI del campo flotante llamando
//     el EditorGUI.PropertyField (Listado 3-18), en lugar de EditorGUILayout,
//     ya que está calculando el tamaño de la GUI usted mismo, y necesita pasar
// propertyRect y la propiedad (que es la propiedad de dibujo actual) a él.


// Para crear cajones decorativos personalizados que
// no anula la GUI original de la propiedad, se extiende desde
// DecoratorDrawer en lugar de PropertyDrawer, como Space
//     o atributo de encabezado, son solo para fines de decoración. Útil
//     la situación dibujará un separador personalizado.