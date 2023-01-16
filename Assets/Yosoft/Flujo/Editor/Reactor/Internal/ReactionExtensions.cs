using Yosoft.Flujo.Editor.Reactor.Ticker;
using Yosoft.Flujo.Runtime.Reactor.Internal;

namespace Yosoft.Flujo.Editor.Reactor.Internal
{
    public static class ReactionExtensions
    {
        public static T SetEditorHeartbeat<T>(this T target) where T : Reaction
        {
            target.SetHeartbeat(new EditorHeartbeat());
            return target;
        }
    }
}
