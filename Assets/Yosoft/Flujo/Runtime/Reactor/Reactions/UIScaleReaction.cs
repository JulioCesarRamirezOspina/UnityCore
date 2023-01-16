using System;
using UnityEngine;
using Yosoft.Flujo.Runtime.Reactor.Internal;
using Yosoft.Flujo.Runtime.UIManager.Extensions;

namespace Yosoft.Flujo.Runtime.Reactor.Reactions
{
    [Serializable]
    public class UIScaleReaction : Vector3Reaction
    {
        public RectTransform rectTransform { get; private set; }

        [SerializeField] private bool Enabled;
        public bool enabled
        {
            get => Enabled;
            set => Enabled = value;
        }

        [SerializeField] private Vector3 StartScale;
        public Vector3 startScale
        {
            get => StartScale;
            set
            {
                StartScale = value;
                if (isActive) UpdateValues();
            }
        }

        [SerializeField] private ReferenceValue FromReferenceValue = ReferenceValue.StartValue;
        public ReferenceValue fromReferenceValue
        {
            get => FromReferenceValue;
            set => FromReferenceValue = value;
        }

        [SerializeField] private ReferenceValue ToReferenceValue = ReferenceValue.StartValue;
        public ReferenceValue toReferenceValue
        {
            get => ToReferenceValue;
            set => ToReferenceValue = value;
        }

        [SerializeField] private Vector3 FromCustomValue;
        public Vector3 fromCustomValue
        {
            get => FromCustomValue;
            set => FromCustomValue = value;
        }

        [SerializeField] private Vector3 ToCustomValue;
        public Vector3 toCustomValue
        {
            get => ToCustomValue;
            set => ToCustomValue = value;
        }

        [SerializeField] private Vector3 FromOffset;
        public Vector3 fromOffset
        {
            get => FromOffset;
            set => FromOffset = value;
        }

        [SerializeField] private Vector3 ToOffset;
        public Vector3 toOffset
        {
            get => ToOffset;
            set => ToOffset = value;
        }

        public Vector3 currentScale
        {
            get => rectTransform.localScale.SetZToOne();
            set => rectTransform.localScale = value.SetZToOne();
        }

        public override void Reset()
        {
            base.Reset();

            rectTransform = null;

            FromReferenceValue = ReferenceValue.StartValue;
            FromCustomValue = Vector3.one;
            FromOffset = Vector3.zero;

            ToReferenceValue = ReferenceValue.StartValue;
            ToCustomValue = Vector3.one;
            ToOffset = Vector3.zero;
        }

        public UIScaleReaction SetTarget(RectTransform target)
        {
            this.SetTargetObject(target);
            rectTransform = target;
            StartScale = currentScale;
            getter = () => currentScale;
            setter = value => currentScale = value;
            return this;
        }

        public override void Play(bool inReverse = false)
        {
            if (!isActive)
            {
                UpdateValues();
                SetValue(inReverse ? ToValue : FromValue);
            }
            base.Play(inReverse);
        }

        public override void PlayFromProgress(float fromProgress)
        {
            UpdateValues();
            base.PlayFromProgress(fromProgress);
        }

        public override void SetProgressAt(float targetProgress)
        {
            UpdateValues();
            base.SetProgressAt(targetProgress);
        }

        public void UpdateValues()
        {
            SetFrom(GetValue(FromReferenceValue, FromOffset, FromCustomValue));
            SetTo(GetValue(ToReferenceValue, ToOffset, ToCustomValue));
        }

        private Vector3 GetValue(ReferenceValue referenceValue, Vector3 offset, Vector3 customValue)
        {
            return referenceValue switch
                   {
                       ReferenceValue.StartValue   => StartScale + offset,
                       ReferenceValue.CurrentValue => currentScale + offset,
                       ReferenceValue.CustomValue  => customValue,
                       _                           => throw new ArgumentOutOfRangeException()
                   };
        }
    }
}
