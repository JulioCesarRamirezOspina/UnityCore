using UnityEngine;

namespace FlujoEstados.Runtime
{
    public class Dialogo : MonoBehaviour
    {
        public EntradasDialogo[] entradas;
    }

    [System.Serializable]
    public class EntradasDialogo
    {
        public string caracter;
        public string contenido;
    }
}