using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.Events;
using Yosoft.Flujo.Editor.EditorUI.Components.Internal;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components
{
    public class ObjectFluidListViewItem : FluidListViewItem
    {
        public ObjectField objectField { get; }
        public UnityAction<SerializedProperty> OnRemoveButtonClick;

        public ObjectFluidListViewItem(FluidListView listView, Type objectType)
            : base(listView)
        {
            itemContentContainer.Clear();
            objectField = new ObjectField { objectType = objectType };
            itemContentContainer.Add
            (
                new ComponentField
                    (
                        ComponentField.Size.Small,
                        string.Empty,
                        objectField
                    )
                    .SetStyleMargins(0, 2, 0, 2)
            );
        }

        public void Update(int index, SerializedProperty property)
        {
            //UPDATE INDEX
            showItemIndex = listView.showItemIndex;
            UpdateItemIndex(index);

            //UPDATE PROPERTY
            objectField.BindProperty(property);

            //UPDATE REMOVE BUTTON
            itemRemoveButton.SetOnClick(() => OnRemoveButtonClick?.Invoke(property));
        }
    }
}
