namespace Yosoft.Flujo.Editor.EditorUI.Events
{
    public interface IFluidEvent<out T>
    {
        T previousValue { get; }
        T newValue { get; }
        bool animateChange { get; }
        bool used { get; set; }
        float timestamp { get; }
    }
}
