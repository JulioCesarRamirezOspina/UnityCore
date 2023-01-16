namespace Yosoft.Flujo.Runtime.Reactor
{
    /// <summary> Describes the types of UI animations </summary>
    public enum UIAnimationType
    {
        /// <summary> Show animation (enter view) </summary>
        Show = 0,
        
        /// <summary> Hide animation (exit view) </summary>
        Hide = 1,
        
        /// <summary> Loop animation (forces infinite loops by setting the loops counter to -1) </summary>
        Loop = 2,
        
        /// <summary> Button animation (click animation) </summary>
        Button = 3,
        
        /// <summary> State animation </summary>
        State = 4,
        
        /// <summary> Reset animation (set/animate all reactions to their respective start values) </summary>
        Reset = 5,
        
        /// <summary> Custom animation, allows for all settings to be used </summary>
        Custom = 6,
    }
}
