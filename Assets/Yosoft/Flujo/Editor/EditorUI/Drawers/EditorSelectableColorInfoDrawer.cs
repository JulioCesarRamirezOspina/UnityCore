using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.Common.Extensions;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.UIElements.Extensions;
using PlayMode = Yosoft.Flujo.Runtime.Reactor.PlayMode;

namespace Yosoft.Flujo.Editor.EditorUI.Drawers
{
    [CustomPropertyDrawer(typeof(EditorSelectableColorInfo))]
    public class EditorSelectableColorInfoDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {}

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var target = property.GetTargetObjectOfProperty() as EditorSelectableColorInfo;

            TemplateContainer root = EditorLayouts.EditorUI.EditorSelectableColorInfo.CloneTree();
            root.AddStyle(EditorStyles.EditorUI.EditorSelectableColorInfo);

            root.Q<VisualElement>("LayoutContainer")
                .SetStyleBackgroundColor(EditorColors.Default.FieldBackground);

            const string onDarkColorGeneratorElementName = "OnDarkColorGeneratorButtonContainer";
            root.Q<VisualElement>(onDarkColorGeneratorElementName)
                .AddChild(
                    GetNewColorGeneratorButton(
                        () => target?.GenerateOnDarkColorVariantsFromNormalColor(),
                        onDarkColorGeneratorElementName,
                        "Generate on dark color variants from the Normal color")
                );

            const string onLightColorGeneratorElementName = "OnDarkColorGeneratorButtonContainer";
            root.Q<VisualElement>(onLightColorGeneratorElementName)
                .AddChild(
                    GetNewColorGeneratorButton(
                        () => target?.GenerateOnLightColorVariantsFromNormalColor(),
                        onLightColorGeneratorElementName,
                        "Generate on light color variants from the Normal color")
                );


            return root;
        }

        private static FluidButton GetNewColorGeneratorButton(UnityAction callback, string elementName, string tooltip)
        {

            FluidButton button = 
                FluidButton.Get()
                .SetIcon(EditorSpriteSheets.UIManager.Icons.BackButton)
                .SetTooltip(tooltip)
                .AddClass("ESColorInfo")
                .SetName(elementName)
                .SetElementSize(ElementSize.Small)
                .SetButtonStyle(ButtonStyle.Clear)
                .SetOnClick(callback);

            button.iconReaction.SetPlayMode(PlayMode.PingPong);

            return button;
        }
    }
}
