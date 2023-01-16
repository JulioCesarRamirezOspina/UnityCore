using System;
using UnityEngine;
using UnityEngine.UI;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.ColorTargets
{
    /// <summary>
    /// Connects a Text component with a Reactor animator.
    /// </summary>
    [Serializable]
    [AddComponentMenu("Reactor/Targets/Text Color Target")]
    public class TextColorTarget : ReactorMetaColorTarget<Text>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<Text>();
        }
        #endif
        
        public override Type targetType => typeof(Text);
        
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
