using static UnityEngine.Mathf;

namespace Yosoft.Flujo.Runtime.Reactor.Easings.Eases
{
    public class EasyEaseInEasing : IEasing
    {
        private static float Calculate(float start, float end, float progress) =>
            LerpUnclamped(start, end, Bezier.Evaluate(progress, Ease.InEasy));
        
        public float Evaluate(float progress) =>
            Calculate(0, 1, Clamp01(progress));
    }
}
