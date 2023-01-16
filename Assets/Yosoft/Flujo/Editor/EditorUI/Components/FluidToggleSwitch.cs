using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components.Internal;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.Colors;
using Yosoft.Flujo.Runtime.Common.Extensions;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components
{
    public class FluidToggleSwitch : FluidToggle<FluidToggleSwitch>
    {
        public override void Reset()
        {
            base.Reset();

            SetLabelText(string.Empty);
            iconReaction.SetTextures(EditorSpriteSheets.EditorUI.Components.Switch);
        }

        #region LabelType

        private ToggleLabelType m_LabelType;
        public ToggleLabelType labelType
        {
            get => m_LabelType;
            set
            {
                m_LabelType = value;
                leftLabel.SetStyleDisplay(labelType == ToggleLabelType.LeftLabel ? DisplayStyle.Flex : DisplayStyle.None);
                rightLabel.SetStyleDisplay(labelType == ToggleLabelType.RightLabel ? DisplayStyle.Flex : DisplayStyle.None);
            }
        }

        #endregion

        public TemplateContainer templateContainer { get; }
        public VisualElement layoutContainer { get; }
        public Image iconContainer { get; }
        public Label leftLabel { get; }
        public Label rightLabel { get; }

        public static FluidToggleSwitch Get(string labelText, bool value, EditorSelectableColorInfo accentColor, string tooltip = "") =>
            Get().SetLabelText(labelText).SetToggleAccentColor(accentColor).SetIsOn(value).SetTooltip(tooltip);

        public static FluidToggleSwitch Get(string labelText) =>
            Get(labelText, false, null, string.Empty);

        public static FluidToggleSwitch Get(bool value, EditorSelectableColorInfo accentColor = null, string tooltip = "") =>
            Get(string.Empty, value, accentColor, tooltip);

        public static FluidToggleSwitch Get(EditorSelectableColorInfo accentColor, string tooltip = "") =>
            Get(string.Empty, false, accentColor, tooltip);

        public FluidToggleSwitch()
        {
            this.SetStyleFlexShrink(0);
            
            Add(templateContainer = EditorLayouts.EditorUI.FluidToggle.CloneTree());
            templateContainer
                .AddStyle(EditorStyles.EditorUI.LayoutContainer)
                .AddStyle(EditorStyles.EditorUI.FieldName)
                .AddStyle(EditorStyles.EditorUI.FluidToggle);

            layoutContainer = templateContainer.Q<VisualElement>(nameof(layoutContainer));
            iconContainer = layoutContainer.Q<Image>(nameof(iconContainer));
            icon = iconContainer.Q<Image>(nameof(icon));
            leftLabel = layoutContainer.Q<Label>(nameof(leftLabel));
            rightLabel = layoutContainer.Q<Label>(nameof(rightLabel));

            fluidElement.OnStateChanged = StateChanged;
            
            const string componentClassName = "ToggleSwitch";
            iconContainer.AddClass(componentClassName);
            icon.AddClass(componentClassName);

            iconReaction
                .SetTextures(EditorSpriteSheets.EditorUI.Components.Switch)
                .SetDuration(0.2f);
            
            selectionState = SelectionState.Normal;
        }

        protected override void StateChanged()
        {
            base.StateChanged();
            icon.SetStyleBackgroundImageTintColor(fluidElement.iconColor); //ICON COLOR
            iconContainer.SetStyleBackgroundColor(fluidElement.containerColor); //ICON CONTAINER COLOR
            iconContainer.SetStyleBorderColor(iconContainerBorderColor); //ICON CONTAINER BORDER COLOR
            leftLabel.SetStyleColor(fluidElement.textColor); //TEXT COLOR
            rightLabel.SetStyleColor(fluidElement.textColor); //TEXT COLOR
            
            MarkDirtyRepaint();
        }

        public FluidToggleSwitch SetLabelType(ToggleLabelType toggleLabelType)
        {
            labelType = toggleLabelType;
            return this;
        }

        public FluidToggleSwitch SetLabelText(string text, ToggleLabelType toggleLabelType = ToggleLabelType.RightLabel)
        {
            leftLabel.text = text;
            rightLabel.text = text;
            labelType = text.IsNullOrEmpty() ? ToggleLabelType.NoLabel : toggleLabelType;
            return this;
        }
    }
}
