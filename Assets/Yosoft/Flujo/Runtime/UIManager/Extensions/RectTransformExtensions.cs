using UnityEngine;

namespace Yosoft.Flujo.Runtime.UIManager.Extensions
{
    public static class RectTransformExtensions
    {
        /// <summary> Reset the attached CanvasGroup component (if there is one) </summary>
        /// <param name="target"> Target RectTransform </param>
        /// <param name="interactable"> Is the group interactable (are the elements beneath the group enabled) </param>
        /// <param name="blockRaycasts"> Does this group block raycasting (allow collision) </param>
        /// <param name="addCanvasGroupIfNotFound"> Should a CanvasGroup be attached to the target RectTransform, if one does not exist </param>
        public static RectTransform ResetCanvasGroup(this RectTransform target, bool interactable = true, bool blockRaycasts = true, bool addCanvasGroupIfNotFound = false)
        {
            CanvasGroup canvasGroup = target.GetComponent<CanvasGroup>();
            if (canvasGroup == null)
            {
                if (addCanvasGroupIfNotFound)
                    canvasGroup = target.gameObject.AddComponent<CanvasGroup>();
                else
                    return target;
            }
            canvasGroup.interactable = interactable;
            canvasGroup.blocksRaycasts = blockRaycasts;
            return target;
        }
    }
}
