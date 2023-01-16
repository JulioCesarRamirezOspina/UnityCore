namespace Yosoft.Flujo.Runtime.Reactor
{
    /// <summary> Describes the types of references available when computing reaction's 'From' and/or 'To' values </summary>
    public enum ReferenceValue
    {
        /// <summary> Initial value (semi-relative value as it gets updated on start or on demand) </summary>
        StartValue = 0,
        /// <summary> Current value (relative value) </summary>
        CurrentValue = 1,
        /// <summary> Custom value (absolute value) </summary>
        CustomValue = 2
    }
}
