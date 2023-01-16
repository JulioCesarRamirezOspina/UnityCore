namespace Yosoft.Flujo.Editor.EditorUI
{
    public enum InfoDotState
    {
        /// <summary>
        /// An invisible states makes the dot not visible in the UI layout
        /// </summary>
        Invisible = 0,
        
        /// <summary>
        /// An info state communicates a description or usage message
        /// </summary>
        Info = 1,
        
        /// <summary>
        /// A correct state communicates that current system settings are ok 
        /// </summary>
        Correct = 2,
        
        /// <summary>
        /// A warning state communicates system possible issue
        /// </summary>
        Warning = 3,
        
        /// <summary>
        /// An error state communicates a user or system mistake
        /// </summary>
        Error = 4
    }
}
