using System;
using UnityEditor;
using UnityEngine;

// ReSharper disable DelegateSubtraction
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace Yosoft.Flujo.Editor.Common.Utils
{
    /// <summary> Executes a delayed call in the Editor </summary>
    public class DelayedCall
    {
        private readonly float m_Delay;
        private readonly Action m_Callback;
        private readonly float m_StartupTime;

        public DelayedCall(float delay, Action callback)
        {
            m_Delay = delay;
            m_Callback = callback;
            m_StartupTime = Time.realtimeSinceStartup;
            EditorApplication.update += Update;
        }

        private void Update()
        {
            if (EditorApplication.timeSinceStartup - (double) m_StartupTime < m_Delay) return;
            if (EditorApplication.update != null) EditorApplication.update -= Update;
            m_Callback?.Invoke();
        }

        public void Cancel()
        {
            if (EditorApplication.update != null)
                EditorApplication.update -= Update;
        }
        
        public static DelayedCall Run(float delay, Action callback) =>
            new DelayedCall(delay, callback);
    }
}