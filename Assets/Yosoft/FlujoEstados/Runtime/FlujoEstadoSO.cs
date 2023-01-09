using System;
using UnityEngine;
using UnityEngine.Events;

namespace FlujoEstados.Runtime
{
    [CreateAssetMenu(menuName =  Constantes.YosoftFlujoEstado + "FlujoEstado", fileName ="FlujoEstado", order = 0)]
    public class FlujoEstadoSO : ScriptableObject
    {
        public TipoFlujoEstado TipoFlujoEstadoE;
        // public Condicion CondicionVerificar;
        public PuntoDeControl PuntoDeControlE;
        public string Codigo;
        
        [FloatPicker(options = new float[] { 10, 20, 30 })]
        public float someFloat;
        
        [NonSerialized] private bool m_CondicionDirty;
        [NonSerialized] protected UnityAction m_OnDirtyCondicionCallback;
        
        
        /// <summary>
        /// Property tracking if any of the text properties have changed. Flag is set before the text is regenerated.
        /// </summary>
        public bool havePropertiesChanged
        {
            get { return m_havePropertiesChanged; }
            set { if (m_havePropertiesChanged == value) return; m_havePropertiesChanged = value; SetAllDirty(); }
        }
        [SerializeField]
        protected bool m_havePropertiesChanged;  // Use
        
        /// <summary>
        /// Set the vertex colors of the 4 vertices of each character quads.
        /// </summary>
        public Condicion condicionPreset
        {
            get { return m_condicionPreset; }
            set { m_havePropertiesChanged = true; m_condicionPreset = value; SetCondicionDirty(); }
        }
        [SerializeField]
        protected Condicion m_condicionPreset;
        
        /// <summary>
        /// Mark the vertices as dirty and needing rebuilt.
        /// </summary>
        /// <remarks>
        /// Send a OnDirtyVertsCallback notification if any elements are registered. See RegisterDirtyVerticesCallback
        /// </remarks>
        public virtual void SetCondicionDirty()
        {
            // if (!IsActive())
            //     return;

            m_CondicionDirty = true;
            // CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);

            if (m_OnDirtyCondicionCallback != null)
                m_OnDirtyCondicionCallback();
        }       
        
        public virtual void SetAllDirty()
        {
            SetCondicionDirty();
        }
        
        
        [System.Serializable]
        public class PuntoDeControl
        {
            public TipoPuntoDeControl TipoPuntoDeControl;
        }

        [System.Serializable]
        public enum TipoFlujoEstado
        {
            VerificacionCondicion,
            PuntoDeControl,
        }
        
       
        [System.Serializable]
        public enum TipoPuntoDeControl
        {
            Login,
            PostHttp,
            GetHttp,
        }
    }
}