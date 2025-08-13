using System;

namespace Roblox.Platform.GameLocalization;

/// <inheritdoc />
/// <summary>
/// An interface for publishing game localization change events.
/// </summary>
/// <seealso cref="T:Roblox.Platform.GameLocalization.GameLocalizationChangeEvent" />
public interface IGameLocalizationChangeEventsPublisher : IObserver<GameLocalizationChangeEvent>
{
	/// <summary>
	/// Subscribe to receive change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.GameLocalization.GameLocalizationChangeEvent" /></param>
	void Subscribe(IObservable<GameLocalizationChangeEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
