using FlujoEstados.Runtime;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;

namespace FlujoEstados.Editor
{
    [CustomEditor(typeof(FlujoEstadoSO))]
    public class FlujoEstadoEventEditor: UnityEditor.Editor
    {
        // protected bool m_HavePropertiesChanged;
        
        private SerializedProperty m_TipoFlujoEstado;
        AnimBool customizeValues;
        
        
        GameObject enemyPrefab;
        float enemyScale = 1f;
        int baseHP = 100;
        float baseSpeed = 5f;
        private void OnEnable()
        {
            m_TipoFlujoEstado = serializedObject.FindProperty("TipoFlujoEstadoE");
            // Register to receive events when style sheets are modified.
            Flujo_EventManager.TEXT_STYLE_PROPERTY_EVENT.Add(ON_TEXT_STYLE_CHANGED);
            Debug.Log($"Habilitado {m_TipoFlujoEstado}");
            customizeValues = new AnimBool(false);
            customizeValues.valueChanged.AddListener(Repaint);
        }
        // Event received when Text Styles are changed.
        void ON_TEXT_STYLE_CHANGED(bool isChanged)
        {
            Debug.Log($"Cambio {m_TipoFlujoEstado}");
        }

        private void OnDisable()
        {
            // Unregister from style sheet related events.
            Flujo_EventManager.TEXT_STYLE_PROPERTY_EVENT.Remove(ON_TEXT_STYLE_CHANGED);
        }


        public override void OnInspectorGUI()
        {
            FlujoEstadoSO so = target as FlujoEstadoSO;
            
            GUILayout.Label($"Configurar Estado para flujo {so.name}", EditorStyles.boldLabel);

            EditorGUI.BeginChangeCheck();
            EditorGUILayout.PropertyField(m_TipoFlujoEstado, GUIContent.none);
            if (EditorGUI.EndChangeCheck())
            {
               Debug.Log(m_TipoFlujoEstado.enumValueFlag);
            }
            
            base.OnInspectorGUI();

            EditorGUILayout.Space();

            enemyPrefab = EditorGUILayout.ObjectField("Enemy Prefab", enemyPrefab, typeof(GameObject), false) as GameObject;

            customizeValues.target = EditorGUILayout.ToggleLeft("Customize Values", customizeValues.target);

            // customizeValues.target = GUILayout.Toggle(customizeValues.target, "Personalizar");
            
            if (EditorGUILayout.BeginFadeGroup(customizeValues.faded))
            {
                EditorGUI.indentLevel++;

                enemyScale = EditorGUILayout.FloatField("Size Scale", enemyScale);
                baseHP = EditorGUILayout.IntField("Base Health", baseHP);
                baseSpeed = EditorGUILayout.FloatField("Base Speed", baseSpeed);

                EditorGUI.indentLevel--;
            }
            else
            {
                // When toggle gets unchecked, revert to default vaules.
                baseHP = 100;
                enemyScale = 1f;
                baseSpeed = 5f;
                baseSpeed = EditorGUILayout.FloatField("Base Speed", baseSpeed);
            }
            
            EditorGUILayout.EndFadeGroup();
            EditorGUI.BeginDisabledGroup(enemyPrefab == null);
            
            
            // GUI.enabled = Application.isPlaying;


            if (GUILayout.Button("Notificar"))
            {
                // Debug.Log(so.Data);
                // so.Raise(so.Data);
            }
            EditorGUI.EndDisabledGroup();
            
            // if (serializedObject.ApplyModifiedProperties() || m_HavePropertiesChanged)
            // {
            //     m_TextComponent.havePropertiesChanged = true;
            //     m_HavePropertiesChanged = false;
            //     EditorUtility.SetDirty(target);
            // }
        }
    }
}