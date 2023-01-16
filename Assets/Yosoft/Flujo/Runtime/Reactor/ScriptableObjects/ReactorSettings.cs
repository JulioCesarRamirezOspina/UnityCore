using System;
using UnityEngine;
using Yosoft.Flujo.Runtime.Common.ScriptableObjects;

namespace Yosoft.Flujo.Runtime.Reactor.ScriptableObjects
{
    public class ReactorSettings : SingletonRuntimeScriptableObject<ReactorSettings>
    {
        /// <summary>
        /// Constant used to lower the given FPS frequency by 0.1% to avoid the "dot crawl" effect (a display artifact)
        /// <footer>https://en.wikipedia.org/wiki/Frame_rate</footer>
        /// </summary>
        private const float FPS_FREQUENCY_MODIFIER = 1.001f;
        private const int MIN_FPS = 1;

        public FPS EditorFPS = FPS.FPS_120;
        public int CustomEditorFPS = (int)FPS.CustomFPS;

        public FPS RuntimeFPS = FPS.FPS_120;
        public int CustomRuntimeFPS = (int)FPS.CustomFPS;

        public static int editorFPS => GetFPS(instance.EditorFPS, Mathf.Min(MIN_FPS, instance.CustomEditorFPS));
        public static int runtimeFPS => GetFPS(instance.RuntimeFPS, Mathf.Min(MIN_FPS, instance.CustomRuntimeFPS));

        public static float GetTickInterval(int fps) => 1f / (Mathf.Max(MIN_FPS, fps) * FPS_FREQUENCY_MODIFIER);
        private static int GetFPS(FPS fps, int customTickInterval)
        {
            return fps switch
                   {
                       FPS.FPS_120   => (int)fps,
                       FPS.FPS_90    => (int)fps,
                       FPS.FPS_60    => (int)fps,
                       FPS.FPS_30    => (int)fps,
                       FPS.FPS_24    => (int)fps,
                       FPS.CustomFPS => Mathf.Max(MIN_FPS, customTickInterval),
                       FPS.MaxFPS    => (int)fps,
                       _             => throw new ArgumentOutOfRangeException(nameof(fps), fps, null)
                   };
        }

    }
}
