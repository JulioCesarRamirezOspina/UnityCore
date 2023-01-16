using System;
using UnityEngine;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.SpriteTargets
{
    /// <summary>
    /// Connects a SpriteRenderer component with a Reactor animator.
    /// </summary>
    [Serializable]
    [RequireComponent(typeof(SpriteRenderer))]
    [AddComponentMenu("Reactor/Targets/SpriteRenderer Sprite Target")]
    public class SpriteRendererSpriteTarget : ReactorMetaSpriteTarget<SpriteRenderer>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<SpriteRenderer>();
        }
        #endif

        public override Type targetType => typeof(SpriteRenderer);
        
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
