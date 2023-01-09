using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Pruebas.UIToolkit
{
    [CreateAssetMenu(fileName = "enemigoSO", menuName = "enemigoSO", order = 0)]
    public class EnemigoSO : ScriptableObject
    {
        public float salud;
        public float ataque;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(EnemigoSO)), CanEditMultipleObjects]
    public class EnemigoSOEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            var health = serializedObject.FindProperty("salud");
            var attackPt = serializedObject.FindProperty("ataque");
            
            var warningHelpBox = new HelpBox("The health cannot be less than 0!", HelpBoxMessageType.Warning);
            ShowWarningIfNeeded(health, warningHelpBox);
            
            var healthPropField = new PropertyField(health);
            healthPropField.RegisterValueChangeCallback((e) =>
            {
                ShowWarningIfNeeded(e.changedProperty, warningHelpBox);
            });
            
            var attackPtPropField = new PropertyField(attackPt);

            var container = new VisualElement();
            container.Add(healthPropField);
            // Code to create VisualElement and add to the container.
            container.Add(new Button(() => { Debug.Log("Click"); })
            {
                text = "Button in UI SO Toolkit!",
                style =
                {
                    height = 60,
                    fontSize = 20,
                    unityTextAlign = TextAnchor.MiddleLeft,
                    unityFontStyleAndWeight = FontStyle.Bold
                }
            });
            var column = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Column
                }
            };
            var row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
                style = { flexGrow = 1 }
            });
            row.Add(new Button()
            {
                text = "Clear selection",
                style = { flexGrow = 1 }
            });
            column.Add(row);

            row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
                style = { flexGrow = 2 }
            });
            row.Add(new Button()
            {
                text = "Clear selection",
                style = { flexGrow = 1 }
            });
            column.Add(row);

            // centrar
            row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                    justifyContent = Justify.Center
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
            });
            row.Add(new Button()
            {
                text = "Clear selection",
            });
            column.Add(row);

            // SpaceAround
            row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                    justifyContent = Justify.SpaceAround
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
            });
            row.Add(new Button()
            {
                text = "Clear selection",
            });
            column.Add(row);


            column.Add(attackPtPropField);
            
            column.Add(warningHelpBox);

            // SpaceBetween
            row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                    justifyContent = Justify.SpaceBetween
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
            });
            row.Add(new Button()
            {
                text = "Clear selection",
            });
            column.Add(row);

            // SpaceBetween
            row = new VisualElement()
            {
                style =
                {
                    flexDirection = FlexDirection.Row,
                    justifyContent = Justify.FlexEnd
                }
            };
            row.Add(new Button()
            {
                text = "Select all enemies",
            });
            row.Add(new Button()
            {
                text = "Clear selection",
            });
            column.Add(row);


            container.Add(column);
            return container;
        }

        private void ShowWarningIfNeeded(SerializedProperty property, HelpBox helpBox)
        {
            helpBox.style.display = property.floatValue < 0 ? DisplayStyle.Flex : DisplayStyle.None;
        }
    }
#endif
}