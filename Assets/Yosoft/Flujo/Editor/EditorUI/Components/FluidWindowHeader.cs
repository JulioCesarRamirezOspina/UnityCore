using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Yosoft.Flujo.Editor.Reactor.Internal;
using Yosoft.Flujo.Runtime.Reactor.Extensions;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.Reactor.Reactions;
using Yosoft.Flujo.Runtime.UIElements.Extensions;

// ReSharper disable MemberCanBePrivate.Global

namespace Yosoft.Flujo.Editor.EditorUI.Components
{
    public class FluidWindowHeader : PoolableElement<FluidWindowHeader>
    {
        public override void Reset()
        {
            this.ResetLayout();
            this.SetTooltip(string.Empty);

            ClearIcon();
            ClearTitle();
            ClearSubtitle();
        }

        public override void Dispose()
        {
            base.Dispose();
            iconReaction?.Recycle();
        }

        public static Color backgroundColor => EditorColors.Default.WindowHeaderBackground;
        public static Color titleColor => EditorColors.Default.WindowHeaderTitle;
        public static Color subtitleColor => EditorColors.Default.WindowHeaderSubtitle;
        public static Color iconColor => EditorColors.Default.WindowHeaderIcon;

        public static Font titleFont => EditorFonts.Ubuntu.Light;
        public static Font subtitleFont => EditorFonts.Inter.Light;

        public TemplateContainer templateContainer { get; }
        public VisualElement layoutContainer { get; }
        public Image icon { get; }
        public Label title { get; }
        public Label subtitle { get; }

        public Texture2DReaction iconReaction { get; set; }

        public static FluidWindowHeader Get(string title, string subtitle, Texture2D iconTexture2D) =>
            Get().SetTitle(title).SetSubtitle(subtitle).SetIcon(iconTexture2D);

        public static FluidWindowHeader Get(string title, string subtitle, IEnumerable<Texture2D> textures) =>
            Get().SetTitle(title).SetSubtitle(subtitle).SetIcon(textures);

        public FluidWindowHeader()
        {
            Add(templateContainer = EditorLayouts.EditorUI.WindowHeader.CloneTree());
            templateContainer
                .AddStyle(EditorStyles.EditorUI.WindowHeader)
                .SetStyleFlexGrow(1)
                .SetStyleBackgroundColor(backgroundColor);

            layoutContainer = templateContainer.Q<VisualElement>("LayoutContainer");
            icon = templateContainer.Q<Image>("Icon");
            title = templateContainer.Q<Label>("Title");
            subtitle = templateContainer.Q<Label>("Subtitle");

            layoutContainer.SetStyleBorderColor(backgroundColor);

            icon.SetStyleBackgroundImageTintColor(iconColor);
            icon.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -15));

            title.SetStyleColor(titleColor).SetStyleUnityFont(titleFont);
            subtitle.SetStyleColor(subtitleColor).SetStyleUnityFont(subtitleFont);


            RegisterCallback<AttachToPanelEvent>(OnAttachToPanel);
            this.AddManipulator(new Clickable(() => iconReaction?.Play()));
        }

        /// <summary> Set title text </summary>
        /// <param name="value"> Title text</param>
        public FluidWindowHeader SetTitle(string value)
        {
            title.SetText(value);
            return this;
        }

        /// <summary> Clear title text </summary>
        public FluidWindowHeader ClearTitle() =>
            SetTitle(string.Empty);

        /// <summary> Set subtitle text </summary>
        /// <param name="value"> Subtitle text </param>
        public FluidWindowHeader SetSubtitle(string value)
        {
            subtitle.SetText(value);
            return this;
        }

        /// <summary> Clear subtitle text </summary>
        public FluidWindowHeader ClearSubtitle() =>
            SetSubtitle(string.Empty);

        /// <summary> Set Animated Icon </summary>
        /// <param name="textures"> Icon textures </param>
        public FluidWindowHeader SetIcon(IEnumerable<Texture2D> textures)
        {
            iconReaction = icon.GetTexture2DReaction(textures).SetEditorHeartbeat().SetDuration(1f);
            return this;
        }

        /// <summary> Set Static Icon </summary>
        /// <param name="iconTexture2D"> Icon texture </param>
        public FluidWindowHeader SetIcon(Texture2D iconTexture2D)
        {
            iconReaction?.Recycle();
            iconReaction = null;
            icon.SetStyleBackgroundImage(iconTexture2D);
            return this;
        }

        /// <summary> Clear icon. If the icon is animated, its reaction will get recycled </summary>
        public FluidWindowHeader ClearIcon()
        {
            iconReaction?.Recycle();
            iconReaction = null;
            icon.SetStyleBackgroundImage((Texture2D)null);
            return this;
        }

        private void OnAttachToPanel(AttachToPanelEvent evt)
        {
            iconReaction?.Play();
        }



    }
}
