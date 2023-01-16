namespace Yosoft.Flujo.Runtime.Colors
{
    /// <summary> An enumeration of the possible selections states an UI object can be in </summary>
    public enum SelectionState
    {
        /// <summary> UI object can be selected </summary>
        Normal,

        /// <summary> UI object is highlighted </summary>
        Highlighted,

        /// <summary> UI object is pressed </summary>
        Pressed,

        /// <summary> UI object is selected </summary>
        Selected,

        /// <summary> UI object cannot be selected </summary>
        Disabled,
    }
}
