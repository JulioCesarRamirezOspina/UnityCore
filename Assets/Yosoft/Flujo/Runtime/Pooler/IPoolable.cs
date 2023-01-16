using System;

namespace Yosoft.Flujo.Runtime.Pooler
{
    /// <summary> Interface for an object that can be pooled </summary>
    public interface IPoolable : IDisposable
    {
        /// <summary> Check if is in the pool or not </summary>
        bool inPool { get; set; }
        /// <summary> Reset to default values or settings </summary>
        void Reset();
        /// <summary> Return to the pool </summary>
        /// <param name="debug"> Print relevant messages to the console </param>
        void Recycle(bool debug = false);
    }
}
