using System;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.Internal
{
    [Serializable]
    public abstract class ReactorMetaColorTarget<T> : ReactorColorTarget
    {
        public T Target;
    }
}
