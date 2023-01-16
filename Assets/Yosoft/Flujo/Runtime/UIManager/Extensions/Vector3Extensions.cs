using UnityEngine;

namespace Yosoft.Flujo.Runtime.UIManager.Extensions
{
    public static class Vector3Extensions
    {
        /// <summary> Get new Vector3(x, y, 1f) </summary>
        /// <param name="target"> Target Vector3 </param>
        public static Vector3 SetZToOne(this Vector3 target) =>
            new Vector3(target.x, target.y, 1f);
        
        /// <summary> Get new Vector3(x, y, 0f) </summary>
        /// <param name="target"> Target Vector3 </param>
        public static Vector3 SetZToZero(this Vector3 target) =>
            new Vector3(target.x, target.y, 0f);
    }
}
