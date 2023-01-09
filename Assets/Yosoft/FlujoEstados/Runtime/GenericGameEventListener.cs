using UnityEngine;
using UnityEngine.Events;

namespace FlujoEstados.Runtime
{
    public class GenericGameEventListener<T> : MonoBehaviour
    {
        [Tooltip("Evento para registrarse.")]
        public GenericGameEvent<T> Event;

        [Tooltip("Respuesta para invocar cuando se genera un evento")]
        public UnityEvent<T> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T t)
        {
            Response.Invoke(t);
        }
    }
}