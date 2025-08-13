using System;

namespace Roblox.Platform.Universes.Events;

/// <summary>
/// Universe events observer.
/// </summary>
public interface IUniverseEventsObserver : IObserver<UniverseEntityEvent>
{
	/// <summary>
	/// Subscribe to receive change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.Universes.Events.UniverseEntityEvent" /></param>
	void Subscribe(IObservable<UniverseEntityEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
