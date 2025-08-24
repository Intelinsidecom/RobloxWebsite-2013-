using System;

namespace Roblox.Platform.TeamCreate.Events;

/// <summary>
/// Team create events observer.
/// </summary>
public interface ITeamCreateEventsObserver : IObserver<TeamCreateEvent>
{
	/// <summary>
	/// Subscribe to receive change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.TeamCreate.Events.TeamCreateEvent" /></param>
	void Subscribe(IObservable<TeamCreateEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
