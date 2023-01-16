using System;
using UnityEngine;
using UnityEngine.UI;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.ColorTargets
{
    /// <summary>
    /// Connects a Image component with a Reactor animator.
    /// </summary>
    [Serializable]
    [RequireComponent(typeof(Image))]
    [AddComponentMenu("Reactor/Targets/Image Color Target")]
    public class ImageColorTarget : ReactorMetaColorTarget<Image>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<Image>();
        }
        #endif
        
        public override Type targetType => typeof(Image);
        
        public override Color GetColor() =>
            Target == null ? Color.magenta : Target.color;
        
        public override void SetColor(Color value)
        {
            if(Target == null)
                 return;
            
            Target.color = value;
        }
    }
}
