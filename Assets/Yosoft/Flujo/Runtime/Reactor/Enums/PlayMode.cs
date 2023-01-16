﻿namespace Yosoft.Flujo.Runtime.Reactor
{
    /// <summary> Describes the computation types available for reactions </summary>
    public enum PlayMode
    {
        /// <summary>
        /// Value goes from start value (A) to target value (B).
        /// <para/> A > B
        /// <para/> Animation restarts (from A) when looped.
        /// </summary>
        Normal,
        
        /// <summary>
        /// Value goes between start (A) and target (B) values back and forth
        /// <para/> A > B > A
        /// <para/> If looped, a loop is considered to go from start to target to start
        /// </summary>
        PingPong,
        
        /// <summary>
        /// Value goes between start (A) and target (B) values back and forth and returns to the start value as if connected by a spring.
        /// <para/> A > B(1) > B(2) > ... > B(n) > A
        /// </summary>
        Spring,
        
        /// <summary>
        /// Value randomly 'shakes' between start (A) and target (B) values back and forth and returns to the start value.
        /// <para/> A > Random(A,B) > Random(A,B) > ... > Random(A,B) > A
        /// </summary>
        Shake
    }
}