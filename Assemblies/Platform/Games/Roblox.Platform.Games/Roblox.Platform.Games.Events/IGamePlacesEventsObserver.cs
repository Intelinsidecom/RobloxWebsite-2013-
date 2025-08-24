using System;

namespace Roblox.Platform.Games.Events;

/// <summary>
/// Universe events observer.
/// </summary>
public interface IGamePlacesEventsObserver : IObserver<GamePlacesChangeEvent>
{
	/// <summary>
	/// Subscribe to receive change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.Games.Events.GamePlacesChangeEvent" /></param>
	void Subscribe(IObservable<GamePlacesChangeEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
