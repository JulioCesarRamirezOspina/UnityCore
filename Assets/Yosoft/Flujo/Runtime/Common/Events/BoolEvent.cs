using System;
using UnityEngine.Events;

namespace Yosoft.Flujo.Runtime.Common.Events
{
    /// <summary> UnityEvent with a bool parameter </summary>
    [Serializable]
    public class BoolEvent : UnityEvent<bool>
    {
    }
}
