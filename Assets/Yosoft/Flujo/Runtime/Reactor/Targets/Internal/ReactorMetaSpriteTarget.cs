using System;

namespace Yosoft.Flujo.Runtime.Reactor.Targets.Internal
{
    [Serializable]
    public abstract class ReactorMetaSpriteTarget<T> : ReactorSpriteTarget
    {
        public T Target;
    }
}
