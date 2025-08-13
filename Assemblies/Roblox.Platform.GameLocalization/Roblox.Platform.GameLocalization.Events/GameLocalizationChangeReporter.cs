using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Events;

internal class GameLocalizationChangeReporter : IGameLocalizationChangeReporter, IObservable<GameLocalizationChangeEvent>
{
	public event Action<GameLocalizationChangeEvent> ObserverActions;

	public void OnGameLocalizationSettingChanged(long gameId, GameLocalizationChangeType changeType)
	{
		GameLocalizationChangeEvent entityEvent = new GameLocalizationChangeEvent(gameId, changeType);
		this.ObserverActions?.Invoke(entityEvent);
	}

	public IDisposable Subscribe(IObserver<GameLocalizationChangeEvent> observer)
	{
		if (observer == null)
		{
			throw new PlatformArgumentNullException("observer");
		}
		ObserverActions += observer.OnNext;
		return new GameLocalizationChangeUnsubscriber(this, observer);
	}
}
