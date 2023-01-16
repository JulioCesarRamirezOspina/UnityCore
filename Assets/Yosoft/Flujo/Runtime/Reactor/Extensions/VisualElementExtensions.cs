using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.Reactor.Reactions;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

namespace Yosoft.Flujo.Runtime.Reactor.Extensions
{
    public static class VisualElementExtensions
    {
        public static ColorReaction GetColorReaction(this VisualElement target, PropertySetter<Color> setter) =>
            Reaction
                .Get<ColorReaction>()
                .SetTargetObject(target)
                .SetSetter(setter);

        public static FloatReaction GetFloatReaction(this VisualElement target, PropertySetter<float> setter) =>
            Reaction
                .Get<FloatReaction>()
                .SetTargetObject(target)
                .SetSetter(setter);

        public static Texture2DReaction GetTexture2DReaction(this VisualElement target, IEnumerable<Texture2D> textures = null)
        {
            Texture2DReaction reaction =
                Reaction
                    .Get<Texture2DReaction>()
                    .SetTargetObject(target)
                    .SetSetter(value => target.SetStyleBackgroundImage(value));

            if (textures != null)
                reaction.SetTextures(textures);

            return reaction;
        }

        public static IntReaction GetIntReaction(this VisualElement target, PropertySetter<int> setter) =>
            Reaction
                .Get<IntReaction>()
                .SetTargetObject(target)
                .SetSetter(setter);

        public static Vector2Reaction GetVector2Reaction(this VisualElement target, PropertySetter<Vector2> setter) =>
            Reaction
                .Get<Vector2Reaction>()
                .SetTargetObject(target)
                .SetSetter(setter);

        public static Vector3Reaction GetVector3Reaction(this VisualElement target, PropertySetter<Vector3> setter) =>
            Reaction
                .Get<Vector3Reaction>()
                .SetTargetObject(target)
                .SetSetter(setter);
    }
}
