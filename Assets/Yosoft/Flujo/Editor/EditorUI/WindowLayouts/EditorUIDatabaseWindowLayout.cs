using UnityEngine.Events;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.WindowLayouts
{
    public abstract class EditorUIDatabaseWindowLayout : FluidWindowLayout
    {
        protected FluidButton refreshDatabaseButton { get; private set; }

        protected void InitializeRefreshDatabaseButton(string labelText, string tooltipText, EditorSelectableColorInfo selectableColor, UnityAction onClickCallback)
        {
            refreshDatabaseButton = GetRefreshDatabaseButton(labelText, tooltipText, selectableColor, onClickCallback);
        }

        private static FluidButton GetRefreshDatabaseButton
        (
            string labelText,
            string tooltipText,
            EditorSelectableColorInfo selectableColor,
            UnityAction onClickCallback
        ) =>
            FluidButton.Get()
                .SetLabelText(labelText)
                .SetTooltip(tooltipText)
                .SetAccentColor(selectableColor)
                .SetOnClick(onClickCallback)
                .SetButtonStyle(ButtonStyle.Contained)
                .SetElementSize(ElementSize.Small)
                .SetIcon(EditorSpriteSheets.EditorUI.Icons.Refresh);
    }
}
