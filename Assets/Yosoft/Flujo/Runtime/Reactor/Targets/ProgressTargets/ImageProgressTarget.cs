using System;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Mathf;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.ProgressTargets
{
    [AddComponentMenu("Reactor/Targets/Image Progress Target")]
    public class ImageProgressTarget : MetaProgressTarget<Image>
    {
        #if UNITY_EDITOR
        private void Reset()
        {
            Target = Target ? Target : GetComponent<Image>();
            if (!Enum.IsDefined(typeof(Mode), targetMode))
                targetMode = Mode.Value;
        }

        private void OnValidate()
        {
            if (!Enum.IsDefined(typeof(Mode), targetMode))
                targetMode = Mode.Value;
        }
        #endif
        
        public override void UpdateTarget(Progressor progressor)
        {
            if(target == null) return;
            if (!Enum.IsDefined(typeof(Mode), targetMode))
                targetMode = Mode.Value;
            switch (targetMode)
            {
                case Mode.Progress:
                    target.fillAmount = Clamp01(progressor.progress);
                    break;
                case Mode.Value:
                    target.fillAmount = Clamp01(progressor.currentValue);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
