using System;
using UnityEngine;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.SpriteTargets
{
    /// <summary>
    /// Connects a SpriteMask component with a Reactor animator.
    /// </summary>
    [Serializable]
    [RequireComponent(typeof(SpriteMask))]
    [AddComponentMenu("Reactor/Targets/SpriteMask Sprite Target")]
    public class SpriteMaskSpriteTarget : ReactorMetaSpriteTarget<SpriteMask>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<SpriteMask>();
        }
        #endif

        public override Type targetType => typeof(SpriteMask);
        
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
