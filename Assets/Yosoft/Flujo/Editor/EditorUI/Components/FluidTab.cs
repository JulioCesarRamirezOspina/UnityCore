using Yosoft.Flujo.Editor.EditorUI.Components.Internal;
using Yosoft.Flujo.Editor.EditorUI.Utils;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components
{
    /// <summary> A tab button with an enabled indicator attached </summary>
    public class FluidTab : FluidTabBase<FluidTab>
    {
        public FluidTab()
        {
            Reset();
            
        }

        public override void Reset()
        {
            base.Reset();

            this
                .ResetStyleSize()
                .ResetTabPosition()
                .SetElementSize(ElementSize.Small)
                .ButtonSetContainerColorOff(DesignUtils.tabButtonColorOff);
        }
    }
}
