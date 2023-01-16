using System;
using TMPro;
using UnityEngine;
using Yosoft.Flujo.Runtime.Reactor.Targets.Internal;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.ColorTargets
{
    /// <summary>
    /// Connects a TextMeshPro component with a Reactor animator.
    /// </summary>
    [Serializable]
    [AddComponentMenu("Reactor/Targets/TextMeshPro Color Target")]
    public class TextMeshProColorTarget : ReactorMetaColorTarget<TMP_Text>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<TMP_Text>();
        }
        #endif
        
        public override Type targetType => typeof(TMP_Text);
        
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
