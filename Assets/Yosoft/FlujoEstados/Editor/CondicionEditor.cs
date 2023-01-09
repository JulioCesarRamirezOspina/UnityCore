using FlujoEstados.Runtime;
using UnityEditor;
using UnityEngine;

namespace FlujoEstados.Editor
{
    [CustomEditor(typeof(Condicion))]
    public class CondicionEditor : UnityEditor.Editor
    {
        internal class Styles
        {
            public static readonly GUIContent deVerticalLabel = new GUIContent("Default Vertical label",
                "Una clase interna con constantes");
        }

        SerializedProperty m_TipoCondicion;
        SerializedProperty m_DatoIzquierdo;
        SerializedProperty m_DatoDerecho;
        SerializedProperty m_Resultado;

        void OnEnable()
        {
            m_TipoCondicion = serializedObject.FindProperty("tipoCondicion");
            m_DatoIzquierdo = serializedObject.FindProperty("datoIzquierdo");
            m_DatoDerecho = serializedObject.FindProperty("datoDerecho");
            m_Resultado = serializedObject.FindProperty("resultado");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(m_TipoCondicion, new GUIContent("Tipo Condición"));
            if (EditorGUI.EndChangeCheck())
            {
                switch ((TipoCondicion)m_TipoCondicion.enumValueIndex)
                {
                    case TipoCondicion.Mayor:
                        EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Mayor que"));
                        EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                        break;
                    case TipoCondicion.MayorIgual:
                        EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Menor que"));
                        EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                        break;
                    case TipoCondicion.MenorIgual:
                        break;
                    case TipoCondicion.Igual:
                        EditorGUILayout.PropertyField(m_Resultado, new GUIContent("Valor"));
                        m_Resultado.boolValue = true;
                        break;
                    case TipoCondicion.Contiene:
                        break;
                    case TipoCondicion.IniciaCon:
                        break;
                    case TipoCondicion.FinalizaCon:
                        break;
                }
            }
            Rect rect;
            switch ((TipoCondicion)m_TipoCondicion.enumValueIndex)
            {
                case TipoCondicion.Mayor:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Mayor que"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
                case TipoCondicion.MayorIgual:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Mayor igual que"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
                case TipoCondicion.MenorIgual:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Menor igual que"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
                case TipoCondicion.Igual:
                    EditorGUILayout.PropertyField(m_Resultado, new GUIContent("Valor"));
                    m_Resultado.boolValue = true;
                    break;
                case TipoCondicion.Contiene:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Contiene"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
                case TipoCondicion.IniciaCon:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Inicia con"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
                case TipoCondicion.FinalizaCon:
                    EditorGUILayout.PropertyField(m_DatoIzquierdo, new GUIContent("Propiedad Finaliza con"));
                    EditorGUILayout.PropertyField(m_DatoDerecho, new GUIContent("Valor"));
                    break;
            }
            
            // FONT ASSET
            EditorGUILayout.BeginVertical(EditorStyles.helpBox);
            GUILayout.Label("Editor Vertical", EditorStyles.boldLabel);
            EditorGUI.indentLevel = 1;
            EditorGUILayout.PropertyField(m_Resultado, Styles.deVerticalLabel);

            EditorGUI.indentLevel = 0;

            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
            
            
            if (serializedObject.ApplyModifiedProperties())
                Flujo_EventManager.ON_CONDICION_PROPERTY_CHANGED(target as Condicion);

        }
    }
}