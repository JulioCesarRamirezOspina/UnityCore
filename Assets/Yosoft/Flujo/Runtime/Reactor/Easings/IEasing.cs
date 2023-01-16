namespace Yosoft.Flujo.Runtime.Reactor.Easings
{
    public interface IEasing
    {
        /// <summary> Evaluate the easing function at the given progress </summary>
        /// <param name="progress"> Value clamped between 0 and 1 </param>
        float Evaluate(float progress);
    }
}
