using System;
using UnityEngine;
using UnityEngine.Events;

namespace Yosoft.Flujo.Runtime.Common.Events
{
    /// <summary> UnityEvent with a Quaternion parameter </summary>
    [Serializable]
    public class QuaternionEvent : UnityEvent<Quaternion>
    {
    }
}
