using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.EditorUI.Components;
using Yosoft.Flujo.Editor.UIElements;
using Yosoft.Flujo.Runtime.Common.Extensions;
using Yosoft.Flujo.Runtime.Common.Utils;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Editor.EditorUI.Windows.Internal
{
    public class EditorUIDatabaseWindow<T> : FluidWindow<T> where T : EditorWindow
    {
        protected override void CreateGUI()
        {
            windowLayout = GetFluidWindowLayout($"{GetType().Name}");
            if (windowLayout == null)
                return;
            windowLayout.SetStyleFlexGrow(1);
            root
                .RecycleAndClear() 
                .AddChild(windowLayout);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            ((FluidWindowLayout) windowLayout).Dispose();
        }

        private static VisualElement GetFluidWindowLayout(string layoutName)
        {
            if (layoutName.IsNullOrEmpty()) return null;
            IEnumerable<Type> results = ReflectionUtils.GetTypesThatImplementInterface<IEditorUIDatabaseWindowLayout>();
            var layoutTypes = results.Where(result => result.Name.Contains(layoutName)).ToList();
            if (!layoutTypes.Any()) return null;
            return (VisualElement)Activator.CreateInstance(layoutTypes[0]);
        }
    }
}
