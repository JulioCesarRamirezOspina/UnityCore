﻿using static UnityEngine.Mathf;

namespace Yosoft.Flujo.Runtime.Reactor.Easings.Eases
{
    public class QuarticEaseInEasing : IEasing
    {
        private static float Calculate(float start, float end, float progress) =>
            LerpUnclamped(start, end, EasingFunction.QuarticEaseIn(progress));

        public float Evaluate(float progress) =>
            Calculate(0, 1, Clamp01(progress));

    }
}
