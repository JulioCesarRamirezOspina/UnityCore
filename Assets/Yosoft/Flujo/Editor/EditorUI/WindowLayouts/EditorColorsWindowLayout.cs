using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.EditorUI.Components.Internal;
using Yosoft.Flujo.Editor.EditorUI.Editors;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Colors;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable UnusedType.Global

namespace Yosoft.Flujo.Editor.EditorUI.WindowLayouts
{
    public sealed class EditorColorsWindowLayout : EditorUIDatabaseWindowLayout, IEditorUIDatabaseWindowLayout
    {
        public override string layoutName => "Colors";
        public override Texture2D staticIconTexture => EditorTextures.EditorUI.Icons.EditorColorPalette;
        public override List<Texture2D> animatedIconTextures => EditorSpriteSheets.EditorUI.Components.EditorColorPalette;

        protected override int maximumNumberOfItemsVisibleAtOnce => 10;

        public EditorColorsWindowLayout()
        {
            AddHeader("Editor Colors", "EditorUI registered colors", animatedIconTextures);

            InitializeRefreshDatabaseButton
            (
                "Refresh Database",
                "Search for all registered color palettes",
                selectableAccentColor,
                () => EditorDataColorDatabase.instance.RefreshDatabase()
            );

            //SIDE MENU - ToolbarContainer - Refresh Database button
            sideMenu.toolbarContainer
                .SetStyleDisplay(DisplayStyle.Flex)
                .AddChild(refreshDatabaseButton);

            //SIDE MENU BUTTONS & CONTENT
            foreach (EditorDataColorPalette palette in EditorDataColorDatabase.instance.Database)
            {
                //SIDE MENU BUTTON
                FluidToggleButtonTab sideMenuButton = sideMenu.AddButton($"{palette.paletteName}", selectableAccentColor);

                //TARGET OBJECT CUSTOM EDITOR
                var editor = (EditorDataColorPaletteEditor)UnityEditor.Editor.CreateEditor(palette);

                //CLEAN NAMED REFERENCES
                ISearchable searchable = editor;
                VisualElement visualElement = editor.CreateInspectorGUI(); // <<< EDITOR GETS GENERATED HERE
                FluidListView fluidListView = editor.fluidListView;
                FluidButton selectAssetButton = GetNewSelectAssetButton($"{palette.paletteName}", staticIconTexture, palette);

                //REMOVE ELEMENTS THAT ARE LESS IMPORTANT AND CREATE VISUAL CLUTTER
                editor.nameComponentField.SetStyleDisplay(DisplayStyle.None);
                editor.fluidListView.listTitle.SetStyleDisplay(DisplayStyle.None);
                editor.fluidListView.listDescription.SetStyleDisplay(DisplayStyle.None);

                sideMenuButton.OnValueChanged += evt =>
                {
                    if (!evt.newValue) return;
                    SideMenuButtonClick(fluidListView, visualElement, selectAssetButton);
                };

                //ADD THE SEARCHABLE TO THE SIDE MENU SearchBox
                sideMenu.searchBox.AddSearchable(searchable);

                //ADD ENTRY TO SEARCHABLE ITEMS LIST (this is needed to generate the complex search results)
                searchableItems.Add(searchable, new FluidSearchableItem(searchable, visualElement, fluidListView, selectAssetButton));
            }
        }
    }
}
