using UnityEngine;

namespace Yosoft.Flujo.Runtime.Reactor
{
    public abstract class MetaProgressTarget<T> : ProgressTarget
    {
        [SerializeField] protected T Target;
        public T target => Target;
    }
}
