using UnityEngine;

namespace Yosoft.Flujo.Editor.EditorUI.Events
{
    public abstract class FluidEventBase<T> : IFluidEvent<T>
    {
        public T previousValue { get; }
        public T newValue { get; }
        public bool animateChange { get; }
        
        public bool used { get; set; }
        public float timestamp { get; }

        protected FluidEventBase(T previousValue, T newValue, bool animateChange)
        {
            this.previousValue = previousValue;
            this.newValue = newValue;
            this.animateChange = animateChange;
            
            used = false;
            timestamp = Time.time;
        }
    }
}
