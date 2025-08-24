using System;

namespace Roblox.Platform.Games.Events;

internal class GamePlacesChangeReporter : IObservable<GamePlacesChangeEvent>
{
	private class Unsubscriber : IDisposable
	{
		private readonly GamePlacesChangeReporter _Reporter;

		private readonly IObserver<GamePlacesChangeEvent> _Observer;

		public Unsubscriber(GamePlacesChangeReporter reporter, IObserver<GamePlacesChangeEvent> observer)
		{
			_Reporter = reporter;
			_Observer = observer;
		}

		public void Dispose()
		{
			_Reporter.ObserverActions -= _Observer.OnNext;
		}
	}

	private event Action<GamePlacesChangeEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<GamePlacesChangeEvent> observer)
	{
		ObserverActions += observer.OnNext;
		return new Unsubscriber(this, observer);
	}

	public virtual void EntityChanged(long universeId, GamePlacesChangeType changeType, long placeId)
	{
		GamePlacesChangeEvent entityEvent = new GamePlacesChangeEvent(universeId, changeType, placeId);
		this.ObserverActions?.Invoke(entityEvent);
	}
}
