using System.Collections.Generic;
using UnityEngine;

namespace FlujoEstados.Runtime
{
    public class GenericGameEvent<T> : ScriptableObject
    {
        public T Data;
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<GenericGameEventListener<T>> eventListeners = new();

        public void Raise(T t)
        {
            for(int i = eventListeners.Count -1; i >= 0; i--)
                eventListeners[i].OnEventRaised(t);
        }

        public void RegisterListener(GenericGameEventListener<T> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(GenericGameEventListener<T> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}