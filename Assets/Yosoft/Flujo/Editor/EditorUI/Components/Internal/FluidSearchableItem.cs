using Doozy.Editor.EditorUI.Components;
using UnityEngine.UIElements;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components.Internal
{
    public class FluidSearchableItem
    {
        public ISearchable searchable { get; }
        public VisualElement visualElement { get; }
        public FluidListView fluidListView { get; }
        public FluidButton selectAssetButton { get; }
            
        public FluidSearchableItem(ISearchable searchable, VisualElement visualElement, FluidListView fluidListView, FluidButton selectAssetButton)
        {
            this.searchable = searchable;
            this.visualElement = visualElement;
            this.fluidListView = fluidListView;
            this.selectAssetButton = selectAssetButton;
        }
    }
}
