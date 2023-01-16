using UnityEngine.UIElements;

namespace Yosoft.Flujo.Editor.EditorUI
{
    public interface ISearchable
    {
        bool isSearching { get; }
        string searchPattern { get; }
        bool hasSearchResults { get; }
        VisualElement searchResults { get; }
        
        void ClearSearch();
        void Search(string pattern);
        void UpdateSearchResults();
    }
}
