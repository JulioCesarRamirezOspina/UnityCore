namespace Yosoft.Flujo.Editor.Common
{
    public interface IEditorDataDatabase
    {
        string databaseName { get; }
        string databaseDescription { get; }
        
        void RefreshDatabase(bool saveAssets = true, bool refreshAssetDatabase = false);
    }
}
