using System;

namespace Roblox.Platform.Assets.Events;

/// <summary>
/// Asset events observer.
/// </summary>
public interface IAssetEventsObserver : IObserver<AssetEntityEvent>
{
	/// <summary>
	/// Subscribe to receive change events
	/// </summary>
	/// <param name="observable"><see cref="T:System.IObservable`1" /> for <see cref="T:Roblox.Platform.Assets.Events.AssetEntityEvent" /></param>
	void Subscribe(IObservable<AssetEntityEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
