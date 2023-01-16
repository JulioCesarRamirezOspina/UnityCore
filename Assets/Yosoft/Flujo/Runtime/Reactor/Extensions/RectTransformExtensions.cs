using UnityEngine;
using Yosoft.Flujo.Runtime.Reactor.Reactions;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

namespace Yosoft.Flujo.Runtime.Reactor.Extensions
{
    public static class RectTransformExtensions
    {
        public static Vector3Reaction AnchorPosition3DReaction(this RectTransform target, Vector3 targetValue, float duration, bool relative) =>
            Reactor.To
            (
                () => target.anchoredPosition3D,
                value => target.anchoredPosition3D = value,
                targetValue,
                duration,
                relative
            );

        public static Vector3Reaction RotationReaction(this RectTransform target, Vector3 targetValue, float duration, bool relative) =>
            Reactor.To
            (
                () => target.localEulerAngles,
                value => target.localRotation = Quaternion.Euler(value),
                targetValue,
                duration,
                relative
            );
    }
}
