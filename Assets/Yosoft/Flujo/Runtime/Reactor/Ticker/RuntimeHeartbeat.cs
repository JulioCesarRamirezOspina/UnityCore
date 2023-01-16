using Yosoft.Flujo.Runtime.Reactor.Internal;

// ReSharper disable UnusedMember.Global

namespace Yosoft.Flujo.Runtime.Reactor.Ticker
{
    /// <summary> Registers to the Runtime Ticker Service and ticks a target callback (when registered) </summary>
    public class RuntimeHeartbeat : Heartbeat
    {
        /// <summary> Construct a runtime Heartbeat with no target callback </summary>
        public RuntimeHeartbeat() : base(null) {}
        
        /// <summary> Construct a runtime Heartbeat with a target callback </summary>
        /// <param name="onTickCallback"> Target callback </param>
        public RuntimeHeartbeat(ReactionCallback onTickCallback) : base(onTickCallback) {}
        
        /// <summary> Time.realtimeSinceStartup </summary>
        public override double timeSinceStartup => RuntimeTicker.timeSinceStartup;
        
        /// <summary> Register to the Runtime Ticker Service <para/> Start ticking the callback </summary>
        public override void RegisterToTickService()
        {
            base.RegisterToTickService();
            RuntimeTicker.service?.Register(this);
        }

        /// <summary> Unregister from the Runtime Ticker Service <para/> Stop ticking the callback </summary>
        public override void UnregisterFromTickService()
        {
            base.UnregisterFromTickService();
            RuntimeTicker.service?.Unregister(this);
        }
    }
}
