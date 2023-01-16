using System;
using UnityEngine;
using UnityEngine.UI;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.SpriteTargets
{
    /// <summary>
    /// Connects a Image component with a Reactor animator.
    /// </summary>
    [Serializable]
    [RequireComponent(typeof(Image))]
    [AddComponentMenu("Reactor/Targets/Image Sprite Target")]
    public class ImageSpriteTarget : ReactorMetaSpriteTarget<Image>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<Image>();
        }
        #endif

        public override Type targetType => typeof(Image);

        public override Sprite GetSprite() =>
            Target == null ? null : Target.sprite;

        public override void SetSprite(Sprite value)
        {
            if (Target == null)
                return;

            Target.sprite = value;
        }
    }
}
