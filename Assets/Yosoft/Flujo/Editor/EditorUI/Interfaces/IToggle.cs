using Doozy.Editor.EditorUI;

namespace Yosoft.Flujo.Editor.EditorUI
{
    public interface IToggle
    {
        bool isOn { get; set; }
        IToggleGroup toggleGroup { get; set; }
        void AddToToggleGroup(IToggleGroup value);
        void RemoveFromToggleGroup();
        void UpdateValueFromGroup(bool newValue, bool animateChange, bool silent = false);
    }
}
