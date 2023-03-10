using UnityEngine;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Yosoft.Flujo.Runtime.Common.Extensions
{
    /// <summary> Extension methods for the RectTransform class </summary>
    public static class RectTransformExtensions
    {
        /// <summary> Copies the RectTransform settings </summary>
        /// <param name="target"> Target RectTransform </param>
        /// <param name="from"> Source RectTransform </param>
        public static RectTransform Copy(this RectTransform target, RectTransform from)
        {
            target.localScale = from.localScale;
            target.anchorMin = from.anchorMin;
            target.anchorMax = from.anchorMax;
            target.pivot = from.pivot;
            target.sizeDelta = from.sizeDelta;
            target.anchoredPosition3D = from.anchoredPosition3D;
            return target;
        }
        
        /// <summary> Makes the RectTransform match its parent size </summary>
        /// <param name="target"> Target RectTransform </param>
        /// <param name="resetScaleToOne"> Reset LocalScale to Vector3.one </param>
        public static RectTransform ExpandToParentSize(this RectTransform target, bool resetScaleToOne)
        {
            if(resetScaleToOne) target.ResetLocalScaleToOne();
            target.AnchorMinToZero();
            target.AnchorMaxToOne();
            target.CenterPivot();
            target.SizeDeltaToZero();
            target.ResetAnchoredPosition3D();
            target.ResetLocalPosition();
            return target;
        }

        /// <summary> Moves the RectTransform pivot settings to its center </summary>
        /// <param name="target"> Target RectTransform </param>
        /// <param name="resetScaleToOne"> Reset LocalScale to Vector3.one </param>
        public static RectTransform Center(this RectTransform target, bool resetScaleToOne)
        {
            if(resetScaleToOne) target.ResetLocalScaleToOne();
            target.AnchorMinToCenter();
            target.AnchorMaxToCenter();
            target.CenterPivot();
            target.SizeDeltaToZero();
            return target;
        }

        /// <summary> Resets the target's anchoredPosition3D to Vector3.zero </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform ResetAnchoredPosition3D(this RectTransform target)
        {
            target.anchoredPosition3D = Vector3.zero;
            return target;
        }

        /// <summary> Resets the target's localPosition to Vector3.zero </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform ResetLocalPosition(this RectTransform target)
        {
            target.localPosition = Vector3.zero;
            return target;
        }

        /// <summary> Resets the target's localScale to Vector3.one </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform ResetLocalScaleToOne(this RectTransform target)
        {
            target.localScale = Vector3.one;
            return target;
        }

        /// <summary> Resets the target's anchorMin to Vector2.zero </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform AnchorMinToZero(this RectTransform target)
        {
            target.anchorMin = Vector2.zero;
            return target;
        }

        /// <summary> Sets the target's anchorMin to Vector2(0.5f, 0.5f) </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform AnchorMinToCenter(this RectTransform target)
        {
            target.anchorMin =  new Vector2(0.5f, 0.5f);
            return target;
        }

        /// <summary> Resets the target's anchorMax to Vector2.one </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform AnchorMaxToOne(this RectTransform target)
        {
            target.anchorMax = Vector2.one;
            return target;
        }

        /// <summary> Sets the target's anchorMax to Vector2(0.5f, 0.5f) </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform AnchorMaxToCenter(this RectTransform target)
        {
            target.anchorMax =  new Vector2(0.5f, 0.5f);
            return target;
        }

        /// <summary> Sets the target's pivot to Vector2(0.5f, 0.5f) </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform CenterPivot(this RectTransform target)
        {
            target.pivot = new Vector2(0.5f, 0.5f);
            return target;
        }

        /// <summary> Resets the target's sizeDelta to Vector2.zero </summary>
        /// <param name="target"> Target RectTransform </param>
        public static RectTransform SizeDeltaToZero(this RectTransform target)
        {
            target.sizeDelta = Vector2.zero;
            return target;
        }
    }
}