namespace Yosoft.Flujo.Runtime.Reactor
{
    /// <summary> Defines how an Animator can behave without any outside input </summary>
    public enum AnimatorBehaviour
    {
        /// <summary> Do nothing </summary>
        Disabled,

        /// <summary> Play the animation forward (from 0 to 1) </summary>
        PlayForward,

        /// <summary> Play the animation in reverse (from 1 to 0) </summary>
        PlayReverse,

        /// <summary> Set the animation at 'from' value (at the start value of the animation) </summary>
        SetFromValue,

        /// <summary> Set the animation at 'to' value (at the end value of the animation) </summary>
        SetToValue
    }
}
