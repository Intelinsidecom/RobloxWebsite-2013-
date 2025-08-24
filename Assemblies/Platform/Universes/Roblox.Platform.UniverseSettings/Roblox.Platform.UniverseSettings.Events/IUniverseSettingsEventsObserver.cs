using System;

namespace Roblox.Platform.UniverseSettings.Events;

/// <summary>
/// Universe events publisher.
///
/// The publisher doesn't define a publishing interface. It should be invoked via the 
/// <see cref="T:System.IObserver`1" /> methods that are the responsibility of the 
/// implementation.
/// </summary>
public interface IUniverseSettingsEventsObserver : IObserver<UniverseSettingsEvent>
{
	/// <summary>
	/// Subscribe to receive Universe Settings change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.UniverseSettings.Events.UniverseSettingsEvent" /></param>
	void Subscribe(IObservable<UniverseSettingsEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
