namespace Yosoft.Flujo.Runtime.Reactor.Internal
{
    public delegate void ReactionCallback();

    public delegate T ReactionCallback<T>(T value);
}
