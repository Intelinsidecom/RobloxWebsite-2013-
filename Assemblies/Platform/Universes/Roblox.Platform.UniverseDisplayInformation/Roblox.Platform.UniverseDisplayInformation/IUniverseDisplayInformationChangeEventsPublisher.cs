using System;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
/// <summary>
/// An interface for publishing <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayInformationChangeEvent" />.
/// </summary>
internal interface IUniverseDisplayInformationChangeEventsPublisher : IObserver<UniverseDisplayInformationChangeEvent>
{
	/// <summary>
	/// Subscribe to <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayInformationChangeEvent" />
	/// </summary>
	/// <param name="observable">An <see cref="T:System.IObservable`1" />.</param>
	void Subscribe(IObservable<UniverseDisplayInformationChangeEvent> observable);

	/// <summary>
	/// Un-subscribe from the <see cref="T:System.IObservable`1" />.
	/// </summary>
	void Unsubscribe();
}
