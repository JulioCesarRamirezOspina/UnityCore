// ReSharper disable UnusedMember.Global

namespace Yosoft.Flujo.Runtime.Reactor.Easings
{
    public static class Extensions
    {
        /// <summary>
        /// Evaluate the easing at the given time
        /// </summary>
        /// <param name="easing"> Target easing </param>
        /// <param name="startValue"> Start value </param>
        /// <param name="targetValue"> Target value </param>
        /// <param name="time"> Time in seconds </param>
        public static float Evaluate(this IEasing easing, float startValue, float targetValue, float time) =>
            startValue + (targetValue - startValue) * easing.Evaluate(time);

    }
}
