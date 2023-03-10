// Copyright (c) 2023 Yosoft Creativo Todos los derechos reservados.

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Diagnostics.CodeAnalysis;
using Yosoft.Flujo.Editor.EditorUI.ScriptableObjects.Layouts;
using UnityEngine.UIElements;

namespace Yosoft.Flujo.Editor.EditorUI
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class EditorLayouts
    {
        public static class Common
        {
            private static EditorDataLayoutGroup s_layoutGroup;
            private static EditorDataLayoutGroup layoutGroup =>
                s_layoutGroup != null
                    ? s_layoutGroup
                    : s_layoutGroup = EditorDataLayoutDatabase.GetLayoutGroup("Common");

            public static VisualTreeAsset GetVisualTreeAsset(LayoutName layoutName) =>
                layoutGroup.GetVisualTreeAsset(layoutName.ToString());

            public enum LayoutName
            {
                CategoryNameItemCategoryRow,
                CategoryNameItemNameRow                     
            }
            

            private static VisualTreeAsset s_CategoryNameItemCategoryRow;
            public static VisualTreeAsset CategoryNameItemCategoryRow => s_CategoryNameItemCategoryRow ? s_CategoryNameItemCategoryRow : s_CategoryNameItemCategoryRow = GetVisualTreeAsset(LayoutName.CategoryNameItemCategoryRow);
            private static VisualTreeAsset s_CategoryNameItemNameRow;
            public static VisualTreeAsset CategoryNameItemNameRow => s_CategoryNameItemNameRow ? s_CategoryNameItemNameRow : s_CategoryNameItemNameRow = GetVisualTreeAsset(LayoutName.CategoryNameItemNameRow);

        }


        public static class EditorUI
        {
            private static EditorDataLayoutGroup s_layoutGroup;
            private static EditorDataLayoutGroup layoutGroup =>
                s_layoutGroup != null
                    ? s_layoutGroup
                    : s_layoutGroup = EditorDataLayoutDatabase.GetLayoutGroup("EditorUI");

            public static VisualTreeAsset GetVisualTreeAsset(LayoutName layoutName) =>
                layoutGroup.GetVisualTreeAsset(layoutName.ToString());

            public enum LayoutName
            {
                ComponentField,
                EditorColorInfo,
                EditorMicroAnimationInfo,
                EditorSelectableColorInfo,
                EditorSpriteSheetInfo,
                EditorTextureInfo,
                EditorUIWindow,
                FluidAnimatedContainer,
                FluidButton,
                FluidCircularGauge,
                FluidComponentHeader,
                FluidContainer,
                FluidField,
                FluidFoldout,
                FluidListView,
                FluidListViewItem,
                FluidPlaceholder,
                FluidSearchBox,
                FluidSideMenu,
                FluidSystemWindow,
                FluidToggle,
                FluidToggleButton,
                FluidToggleIconButton,
                FluidWindowLayout,
                ListView,
                ListViewItem,
                ThemeColor,
                WindowHeader                     
            }
            

            private static VisualTreeAsset s_ComponentField;
            public static VisualTreeAsset ComponentField => s_ComponentField ? s_ComponentField : s_ComponentField = GetVisualTreeAsset(LayoutName.ComponentField);
            private static VisualTreeAsset s_EditorColorInfo;
            public static VisualTreeAsset EditorColorInfo => s_EditorColorInfo ? s_EditorColorInfo : s_EditorColorInfo = GetVisualTreeAsset(LayoutName.EditorColorInfo);
            private static VisualTreeAsset s_EditorMicroAnimationInfo;
            public static VisualTreeAsset EditorMicroAnimationInfo => s_EditorMicroAnimationInfo ? s_EditorMicroAnimationInfo : s_EditorMicroAnimationInfo = GetVisualTreeAsset(LayoutName.EditorMicroAnimationInfo);
            private static VisualTreeAsset s_EditorSelectableColorInfo;
            public static VisualTreeAsset EditorSelectableColorInfo => s_EditorSelectableColorInfo ? s_EditorSelectableColorInfo : s_EditorSelectableColorInfo = GetVisualTreeAsset(LayoutName.EditorSelectableColorInfo);
            private static VisualTreeAsset s_EditorSpriteSheetInfo;
            public static VisualTreeAsset EditorSpriteSheetInfo => s_EditorSpriteSheetInfo ? s_EditorSpriteSheetInfo : s_EditorSpriteSheetInfo = GetVisualTreeAsset(LayoutName.EditorSpriteSheetInfo);
            private static VisualTreeAsset s_EditorTextureInfo;
            public static VisualTreeAsset EditorTextureInfo => s_EditorTextureInfo ? s_EditorTextureInfo : s_EditorTextureInfo = GetVisualTreeAsset(LayoutName.EditorTextureInfo);
            private static VisualTreeAsset s_EditorUIWindow;
            public static VisualTreeAsset EditorUIWindow => s_EditorUIWindow ? s_EditorUIWindow : s_EditorUIWindow = GetVisualTreeAsset(LayoutName.EditorUIWindow);
            private static VisualTreeAsset s_FluidAnimatedContainer;
            public static VisualTreeAsset FluidAnimatedContainer => s_FluidAnimatedContainer ? s_FluidAnimatedContainer : s_FluidAnimatedContainer = GetVisualTreeAsset(LayoutName.FluidAnimatedContainer);
            private static VisualTreeAsset s_FluidButton;
            public static VisualTreeAsset FluidButton => s_FluidButton ? s_FluidButton : s_FluidButton = GetVisualTreeAsset(LayoutName.FluidButton);
            private static VisualTreeAsset s_FluidCircularGauge;
            public static VisualTreeAsset FluidCircularGauge => s_FluidCircularGauge ? s_FluidCircularGauge : s_FluidCircularGauge = GetVisualTreeAsset(LayoutName.FluidCircularGauge);
            private static VisualTreeAsset s_FluidComponentHeader;
            public static VisualTreeAsset FluidComponentHeader => s_FluidComponentHeader ? s_FluidComponentHeader : s_FluidComponentHeader = GetVisualTreeAsset(LayoutName.FluidComponentHeader);
            private static VisualTreeAsset s_FluidContainer;
            public static VisualTreeAsset FluidContainer => s_FluidContainer ? s_FluidContainer : s_FluidContainer = GetVisualTreeAsset(LayoutName.FluidContainer);
            private static VisualTreeAsset s_FluidField;
            public static VisualTreeAsset FluidField => s_FluidField ? s_FluidField : s_FluidField = GetVisualTreeAsset(LayoutName.FluidField);
            private static VisualTreeAsset s_FluidFoldout;
            public static VisualTreeAsset FluidFoldout => s_FluidFoldout ? s_FluidFoldout : s_FluidFoldout = GetVisualTreeAsset(LayoutName.FluidFoldout);
            private static VisualTreeAsset s_FluidListView;
            public static VisualTreeAsset FluidListView => s_FluidListView ? s_FluidListView : s_FluidListView = GetVisualTreeAsset(LayoutName.FluidListView);
            private static VisualTreeAsset s_FluidListViewItem;
            public static VisualTreeAsset FluidListViewItem => s_FluidListViewItem ? s_FluidListViewItem : s_FluidListViewItem = GetVisualTreeAsset(LayoutName.FluidListViewItem);
            private static VisualTreeAsset s_FluidPlaceholder;
            public static VisualTreeAsset FluidPlaceholder => s_FluidPlaceholder ? s_FluidPlaceholder : s_FluidPlaceholder = GetVisualTreeAsset(LayoutName.FluidPlaceholder);
            private static VisualTreeAsset s_FluidSearchBox;
            public static VisualTreeAsset FluidSearchBox => s_FluidSearchBox ? s_FluidSearchBox : s_FluidSearchBox = GetVisualTreeAsset(LayoutName.FluidSearchBox);
            private static VisualTreeAsset s_FluidSideMenu;
            public static VisualTreeAsset FluidSideMenu => s_FluidSideMenu ? s_FluidSideMenu : s_FluidSideMenu = GetVisualTreeAsset(LayoutName.FluidSideMenu);
            private static VisualTreeAsset s_FluidSystemWindow;
            public static VisualTreeAsset FluidSystemWindow => s_FluidSystemWindow ? s_FluidSystemWindow : s_FluidSystemWindow = GetVisualTreeAsset(LayoutName.FluidSystemWindow);
            private static VisualTreeAsset s_FluidToggle;
            public static VisualTreeAsset FluidToggle => s_FluidToggle ? s_FluidToggle : s_FluidToggle = GetVisualTreeAsset(LayoutName.FluidToggle);
            private static VisualTreeAsset s_FluidToggleButton;
            public static VisualTreeAsset FluidToggleButton => s_FluidToggleButton ? s_FluidToggleButton : s_FluidToggleButton = GetVisualTreeAsset(LayoutName.FluidToggleButton);
            private static VisualTreeAsset s_FluidToggleIconButton;
            public static VisualTreeAsset FluidToggleIconButton => s_FluidToggleIconButton ? s_FluidToggleIconButton : s_FluidToggleIconButton = GetVisualTreeAsset(LayoutName.FluidToggleIconButton);
            private static VisualTreeAsset s_FluidWindowLayout;
            public static VisualTreeAsset FluidWindowLayout => s_FluidWindowLayout ? s_FluidWindowLayout : s_FluidWindowLayout = GetVisualTreeAsset(LayoutName.FluidWindowLayout);
            private static VisualTreeAsset s_ListView;
            public static VisualTreeAsset ListView => s_ListView ? s_ListView : s_ListView = GetVisualTreeAsset(LayoutName.ListView);
            private static VisualTreeAsset s_ListViewItem;
            public static VisualTreeAsset ListViewItem => s_ListViewItem ? s_ListViewItem : s_ListViewItem = GetVisualTreeAsset(LayoutName.ListViewItem);
            private static VisualTreeAsset s_ThemeColor;
            public static VisualTreeAsset ThemeColor => s_ThemeColor ? s_ThemeColor : s_ThemeColor = GetVisualTreeAsset(LayoutName.ThemeColor);
            private static VisualTreeAsset s_WindowHeader;
            public static VisualTreeAsset WindowHeader => s_WindowHeader ? s_WindowHeader : s_WindowHeader = GetVisualTreeAsset(LayoutName.WindowHeader);

        }


        public static class Reactor
        {
            private static EditorDataLayoutGroup s_layoutGroup;
            private static EditorDataLayoutGroup layoutGroup =>
                s_layoutGroup != null
                    ? s_layoutGroup
                    : s_layoutGroup = EditorDataLayoutDatabase.GetLayoutGroup("Reactor");

            public static VisualTreeAsset GetVisualTreeAsset(LayoutName layoutName) =>
                layoutGroup.GetVisualTreeAsset(layoutName.ToString());

            public enum LayoutName
            {
                AnimationInfo,
                AnimationPreview,
                ReactionControls,
                ReactorWindow,
                TickerVisualizer                     
            }
            

            private static VisualTreeAsset s_AnimationInfo;
            public static VisualTreeAsset AnimationInfo => s_AnimationInfo ? s_AnimationInfo : s_AnimationInfo = GetVisualTreeAsset(LayoutName.AnimationInfo);
            private static VisualTreeAsset s_AnimationPreview;
            public static VisualTreeAsset AnimationPreview => s_AnimationPreview ? s_AnimationPreview : s_AnimationPreview = GetVisualTreeAsset(LayoutName.AnimationPreview);
            private static VisualTreeAsset s_ReactionControls;
            public static VisualTreeAsset ReactionControls => s_ReactionControls ? s_ReactionControls : s_ReactionControls = GetVisualTreeAsset(LayoutName.ReactionControls);
            private static VisualTreeAsset s_ReactorWindow;
            public static VisualTreeAsset ReactorWindow => s_ReactorWindow ? s_ReactorWindow : s_ReactorWindow = GetVisualTreeAsset(LayoutName.ReactorWindow);
            private static VisualTreeAsset s_TickerVisualizer;
            public static VisualTreeAsset TickerVisualizer => s_TickerVisualizer ? s_TickerVisualizer : s_TickerVisualizer = GetVisualTreeAsset(LayoutName.TickerVisualizer);

        }


        public static class UIManager
        {
            private static EditorDataLayoutGroup s_layoutGroup;
            private static EditorDataLayoutGroup layoutGroup =>
                s_layoutGroup != null
                    ? s_layoutGroup
                    : s_layoutGroup = EditorDataLayoutDatabase.GetLayoutGroup("UIManager");

            public static VisualTreeAsset GetVisualTreeAsset(LayoutName layoutName) =>
                layoutGroup.GetVisualTreeAsset(layoutName.ToString());

            public enum LayoutName
            {
                UIManagerWindow,
                UIMenuItemButton,
                UIMenuWindow                     
            }
            

            private static VisualTreeAsset s_UIManagerWindow;
            public static VisualTreeAsset UIManagerWindow => s_UIManagerWindow ? s_UIManagerWindow : s_UIManagerWindow = GetVisualTreeAsset(LayoutName.UIManagerWindow);
            private static VisualTreeAsset s_UIMenuItemButton;
            public static VisualTreeAsset UIMenuItemButton => s_UIMenuItemButton ? s_UIMenuItemButton : s_UIMenuItemButton = GetVisualTreeAsset(LayoutName.UIMenuItemButton);
            private static VisualTreeAsset s_UIMenuWindow;
            public static VisualTreeAsset UIMenuWindow => s_UIMenuWindow ? s_UIMenuWindow : s_UIMenuWindow = GetVisualTreeAsset(LayoutName.UIMenuWindow);

        }

    }
}