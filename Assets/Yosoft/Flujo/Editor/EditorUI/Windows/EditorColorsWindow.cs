using UnityEditor;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Editor.EditorUI.Windows.Internal;

namespace Yosoft.Flujo.Editor.EditorUI.Windows
{
    public class EditorColorsWindow : EditorUIDatabaseWindow<EditorColorsWindow>
    {
        private const string WINDOW_TITLE = "Editor Colors";

        [MenuItem(EditorUIWindow.k_WindowMenuPath + WINDOW_TITLE + "/Window", priority = -550)]
        private static void Open() => InternalOpenWindow(WINDOW_TITLE);

        [MenuItem(EditorUIWindow.k_WindowMenuPath + WINDOW_TITLE + "/Refresh", priority = -500)]
        private static void RefreshDatabase() => EditorDataColorDatabase.instance.RefreshDatabase();
    }
}