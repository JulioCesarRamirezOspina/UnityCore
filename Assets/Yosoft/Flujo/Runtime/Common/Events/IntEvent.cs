using System;
using UnityEngine.Events;

namespace Yosoft.Flujo.Runtime.Common.Events
{
    /// <summary> UnityEvent with an int parameter </summary>
    [Serializable]
    public class IntEvent : UnityEvent<int>
    {
    }
}
