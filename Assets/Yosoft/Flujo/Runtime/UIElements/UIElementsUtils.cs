using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;
using Yosoft.Flujo.Runtime.Common.Extensions;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Runtime.UIElements
{
    public static class UIElementsUtils
    {
        public static void AddClass(string className, IEnumerable<VisualElement> elements, bool removeNulls = true)
        {
            if (className.IsNullOrEmpty())
                return;

            if (elements == null)
                return;

            if (removeNulls)
                elements = elements.Where(item => item != null);

            foreach (VisualElement element in elements)
                element.AddClass(className);
        }

        public static void RemoveClass(string className, IEnumerable<VisualElement> elements, bool removeNulls = true)
        {
            if (className.IsNullOrEmpty())
                return;

            if (elements == null)
                return;

            if (removeNulls)
                elements = elements.Where(item => item != null);

            foreach (VisualElement element in elements)
                element.RemoveClass(className);
        }
    }
}
