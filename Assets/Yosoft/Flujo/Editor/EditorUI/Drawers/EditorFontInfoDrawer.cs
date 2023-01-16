using Doozy.Editor.EditorUI.ScriptableObjects.Fonts;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.EditorUI.Utils;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(EditorFontInfo))]
    public class EditorFontInfoDrawer : PropertyDrawer
    {
        #region Cache

        private static Color backgroundColor => EditorColors.Default.FieldBackground;
        private static Color borderColor => EditorColors.Default.Selection;

        #endregion

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            Debug.Assert(backgroundColor != null, nameof(backgroundColor) + " != null");
            Debug.Assert(borderColor != null, nameof(borderColor) + " != null");

            VisualElement drawer =
                new VisualElement()
                    .SetStyleBackgroundColor((Color)backgroundColor)
                    .SetStyleBorderWidth(1)
                    .SetStyleBorderColor((Color)borderColor)
                    .SetStyleBorderRadius(DesignUtils.k_FieldBorderRadius)
                    .SetStylePadding(DesignUtils.k_Spacing)
                    .SetStyleMarginTop(DesignUtils.k_Spacing)
                    .SetStyleMarginBottom(DesignUtils.k_Spacing);

            ObjectField fontReferenceObjectField = DesignUtils.NewObjectField("FontReference", typeof(Font), false);
            EnumField weightEnumField =
                DesignUtils.NewEnumField("Weight").DisableElement()
                    .SetStyleFlexGrow(0).SetStyleMinWidth(120).SetStyleMarginLeft(DesignUtils.k_Spacing);

            drawer
                .AddChild
                (
                    DesignUtils.row
                        .AddChild(fontReferenceObjectField)
                        .AddChild(weightEnumField)
                )
                .AddChild(GetFontExampleComponentField(property));

            drawer.RegisterCallback<DetachFromPanelEvent>(evt =>
            {

            });

            return drawer;
        }



        private static ComponentField GetFontReferenceComponentField() =>
            new ComponentField
                (
                    ComponentField.Size.Small,
                    string.Empty,
                    new ObjectField { bindingPath = "FontReference" }
                )
                .SetStyleFlexGrow(1);

        private static ComponentField GetWeightComponentField() =>
            new ComponentField
                (
                    ComponentField.Size.Small,
                    string.Empty,
                    new EnumField { bindingPath = "Weight" }
                )
                .SetStyleMinWidth(120)
                .DisableElement();

        private static ComponentField GetFontExampleComponentField(SerializedProperty property)
        {
            SerializedProperty referenceProperty = property.FindPropertyRelative("FontReference");
            bool hasReference = referenceProperty?.objectReferenceValue != null;

            // var fontExampleLabel = new Label(hasReference
            // ? referenceProperty.objectReferenceValue.name
            // : "---");

            var fontExampleLabel = new Label(hasReference
                ? "The quick brown fox jumps over the lazy dog"
                : "---");

            fontExampleLabel
                .SetStyleColor(EditorColors.Default.TextDescription)
                .SetStyleFontSize(12);

            if (hasReference)
                fontExampleLabel.SetStyleUnityFont((Font)referenceProperty.objectReferenceValue);

            return new ComponentField
            (
                ComponentField.Size.Small,
                string.Empty,
                fontExampleLabel
            );
        }
    }
}
