namespace Yosoft.Flujo.Editor.EditorUI
{
    public interface IToggleGroup : IToggle
    {
        void RegisterToggle(IToggle toggle);
        void UnregisterToggle(IToggle toggle);
        void ToggleChangedValue(IToggle toggle, bool animateChange);
    }
}
