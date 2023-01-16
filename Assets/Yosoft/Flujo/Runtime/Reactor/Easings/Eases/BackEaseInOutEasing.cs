using static UnityEngine.Mathf;

namespace Yosoft.Flujo.Runtime.Reactor.Easings.Eases
{
    public class BackEaseInOutEasing : IEasing
    {
        private static float Calculate(float start, float end, float progress) =>
            LerpUnclamped(start, end, EasingFunction.BackEaseInOut(progress));

        public float Evaluate(float progress) =>
            Calculate(0, 1, Clamp01(progress));
    }
}
