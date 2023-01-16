namespace Yosoft.Flujo.Editor.EditorUI
{
    /// <summary>
    /// States communicate the status of UI elements to the user
    /// </summary>
    public enum InteractableState
    {
        /// <summary>
        /// A disabled state communicates a noninteractive component or element
        /// </summary>
        Disabled = 0,
        
        /// <summary>
        /// An enabled state communicates an interactive component or element
        /// </summary>
        Enabled = 1,
        
        
        /// <summary>
        /// A hover state communicates when a user has placed a cursor above an interactive element
        /// </summary>
        Hover = 2,
        
        /// <summary>
        /// A focused state communicates when a user has highlighted an element, using an input method such as a keyboard or voice
        /// </summary>
        Focused = 3,
        
        /// <summary>
        /// A selected state communicates a user choice
        /// </summary>
        Selected = 4,
        
        /// <summary>
        /// An activated state communicates a highlighted destination, whether initiated by the user or by default
        /// </summary>
        Activated = 5,
        
        /// <summary>
        /// A pressed state communicates a user tap
        /// </summary>
        Pressed = 6,
        
        /// <summary>
        /// A dragged state communicates when a user presses and moves an element
        /// </summary>
        Dragged
    }
}
