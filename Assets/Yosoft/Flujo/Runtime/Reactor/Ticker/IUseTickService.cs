// ReSharper disable UnusedMemberInSuper.Global

namespace Yosoft.Flujo.Runtime.Reactor.Ticker
{
	public interface IUseTickService
	{
		void RegisterToTickService();
		void UnregisterFromTickService();
		void Tick();
	}
}