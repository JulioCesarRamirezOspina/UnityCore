using System;
using UnityEngine;
using UnityEngine.Events;

namespace Yosoft.Flujo.Runtime.Common.Events
{
    /// <summary> UnityEvent with a Vector3 parameter </summary>
    [Serializable]
    public class Vector3Event : UnityEvent<Vector3> 
    {
    }
}
