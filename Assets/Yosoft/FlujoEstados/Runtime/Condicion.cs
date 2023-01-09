using UnityEngine;

namespace FlujoEstados.Runtime
{
    [CreateAssetMenu(fileName = "condicionFlujo", menuName = Constantes.YosoftFlujoEstado + "Condicion", order = 0)]
    [System.Serializable]
    public class Condicion : ScriptableObject
    {
        public TipoCondicion tipoCondicion = TipoCondicion.Igual;
        public string datoIzquierdo;
        public string datoDerecho;
        public bool resultado;
        

        const TipoCondicion k_DefaultTipoCondicion = TipoCondicion.Igual;

        public Condicion()
        {
            tipoCondicion = k_DefaultTipoCondicion;
            datoIzquierdo = "";
            datoDerecho = "";
            resultado = false;
        }

        public Condicion(TipoCondicion tipoCondicion, string datoIzquierdo, string datoDerecho, bool resultado)
        {
            this.tipoCondicion = tipoCondicion;
            this.datoIzquierdo = datoIzquierdo;
            this.datoDerecho = datoDerecho;
            this.resultado = resultado;
        }
    }
    
    public enum TipoCondicion
    {
        Mayor,
        MayorIgual,
        MenorIgual,
        Igual,
        Contiene,
        IniciaCon,
        FinalizaCon
    } 
}