namespace Yosoft.Flujo.Editor.EditorUI.Events
{
    public class FluidBoolEvent : FluidEventBase<bool>
    {
        public FluidBoolEvent(bool previousValue, bool newValue, bool animateChange) : base(previousValue, newValue, animateChange)
        {
        }
    }
}
