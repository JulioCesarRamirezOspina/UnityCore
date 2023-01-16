namespace Yosoft.Flujo.Runtime.Reactor
{
    /// <summary> Reset options for the value of a Progressor </summary>
    public enum ResetValue
    {
        /// <summary> Value does not reset </summary>
        Disabled,
        
        /// <summary> Value resets to the From value </summary>
        FromValue,
        
        /// <summary> Value resets to the To value </summary>
        EndValue,
        
        /// <summary> Value resets to a Custom value </summary>
        CustomValue
    }
}
