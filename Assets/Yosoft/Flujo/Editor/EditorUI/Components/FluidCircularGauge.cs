using Doozy.Editor.EditorUI;
using Doozy.Editor.EditorUI.Components;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.Reactor.Internal;
using Yosoft.Flujo.Editor.UIElements;
using Yosoft.Flujo.Runtime.Colors;
using Yosoft.Flujo.Runtime.Reactor.Easings;
using Yosoft.Flujo.Runtime.Reactor.Extensions;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.Reactor.Reactions;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeProtected.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components
{
    public class FluidCircularGauge : PoolableElement<FluidCircularGauge>
    {
        public TemplateContainer templateContainer { get; }
        public VisualElement layoutContainer { get; }
        public Image body { get; }
        public Image fillBackground { get; }
        public Image fill { get; }

        public Texture2DReaction fillReaction { get; }

        public sealed override void Reset()
        {
            body.RecycleAndClear();
            SetAccentColor(EditorColors.EditorUI.Amber);
            fillReaction
                .SetTextures(EditorSpriteSheets.EditorUI.Widgets.CircularGauge)
                .SetProgressAtZero();
        }

        public override void Recycle(bool debug = false)
        {
            base.Recycle(debug);
            fillReaction?.Recycle();
        }

        public FluidCircularGauge()
        {
            Add(templateContainer = EditorLayouts.EditorUI.FluidCircularGauge.CloneTree());

            this
                .AddStyle(EditorStyles.EditorUI.FluidCircularGauge);

            layoutContainer = templateContainer.Q<VisualElement>(nameof(layoutContainer));
            body = templateContainer.Q<Image>(nameof(body));
            fillBackground = templateContainer.Q<Image>(nameof(fillBackground));
            fill = templateContainer.Q<Image>(nameof(fill));

            body
                .SetStyleBackgroundImage(EditorTextures.EditorUI.Widgets.CircularGaugeBody)
                .SetStyleBackgroundImageTintColor(EditorColors.Default.BoxBackground);

            fillBackground
                .SetStyleBackgroundImage(EditorTextures.EditorUI.Widgets.CircularGaugeFillBackground);

            fillReaction =
                fill.GetTexture2DReaction()
                    .SetEditorHeartbeat()
                    .SetTextures(EditorSpriteSheets.EditorUI.Widgets.CircularGauge)
                    .SetDuration(0.5f);

            Reset();
        }
        
        public FluidCircularGauge SetAccentColor(Color color) =>
            SetFillBackgroundColor(color.WithAlpha(0.15f))
                .SetFillColor(color);

        public FluidCircularGauge SetBodyColor(Color color)
        {
            body.SetStyleBackgroundImageTintColor(color);
            return this;
        }

        public FluidCircularGauge SetFillBackgroundColor(Color color)
        {
            fillBackground.SetStyleBackgroundImageTintColor(color);
            return this;
        }

        public FluidCircularGauge SetFillColor(Color color)
        {
            fill.SetStyleBackgroundImageTintColor(color);
            return this;
        }

        public FluidCircularGauge SetAnimationDuration(float duration)
        {
            fillReaction.SetDuration(duration);
            return this;
        }

        public FluidCircularGauge SetAnimationEase(Ease ease)
        {
            fillReaction.SetEase(ease);
            return this;
        }

        public FluidCircularGauge PlayToProgress(float progress)
        {
            fillReaction.PlayToProgress(progress);
            return this;
        }
    }
}
