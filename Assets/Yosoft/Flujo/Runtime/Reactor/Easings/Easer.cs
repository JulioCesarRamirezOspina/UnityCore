using System;
using UnityEngine;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace Yosoft.Flujo.Runtime.Reactor.Easings
{
    public class Easer
    {
        public EaseMode easeMode { get; private set; }
        public IEasing easing { get; private set; }
        public AnimationCurve animationCurve { get; private set; }

        public Easer() =>
            SetEase(Ease.Linear);

        public float Evaluate(float time)
        {
            return easeMode switch
                   {
                       EaseMode.Ease           => easing.Evaluate(time),
                       EaseMode.AnimationCurve => animationCurve.Evaluate(time),
                       _                       => throw new ArgumentOutOfRangeException()
                   };
        }

        public void SetEase(Ease ease)
        {
            easing = EaseFactory.GetEase(ease);
            easeMode = EaseMode.Ease;
        }

        public void SetAnimationCurve(AnimationCurve curve)
        {
            animationCurve = curve;
            easeMode = EaseMode.AnimationCurve;
        }
    }
}
