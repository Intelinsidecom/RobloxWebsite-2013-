using System;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class UniverseDisplayInformationChangeReporter : IUniverseDisplayInformationChangeReporter, IObservable<UniverseDisplayInformationChangeEvent>
{
	private event Action<UniverseDisplayInformationChangeEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<UniverseDisplayInformationChangeEvent> observer)
	{
		if (observer == null)
		{
			throw new PlatformArgumentNullException("observer");
		}
		ObserverActions += observer.OnNext;
		return new UniverseDisplayInformationChangeUnsubscriber(this, observer);
	}

	public void DisplayInformationChanged(long universeId, ILanguageFamily language, UniverseDisplayInformationChangeType changeType, UniverseDisplayInformationActionType actionType)
	{
		UniverseDisplayInformationChangeEvent universeDisplayInformationChangeEvent = new UniverseDisplayInformationChangeEvent(universeId, language, changeType, actionType);
		this.ObserverActions?.Invoke(universeDisplayInformationChangeEvent);
	}

	public void Unsubscribe(IObserver<UniverseDisplayInformationChangeEvent> observer)
	{
		if (observer == null)
		{
			throw new PlatformArgumentNullException("observer");
		}
		ObserverActions -= observer.OnNext;
	}
}
