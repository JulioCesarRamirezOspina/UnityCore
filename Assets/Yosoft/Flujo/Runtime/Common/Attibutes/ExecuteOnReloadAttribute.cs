﻿using System;

// ReSharper disable ClassNeverInstantiated.Global

namespace Yosoft.Flujo.Runtime.Common.Attibutes
{
    /// <summary>
    /// Attribute used by the <see cref="Doozy.Editor.Common.Utils.DomainReloadHandler"/> to execute a method on reload
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ExecuteOnReloadAttribute : Attribute
    {
        /// <summary> On reload, execute method </summary>
        public ExecuteOnReloadAttribute() {}
    }
}
