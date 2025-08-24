using System;

namespace Roblox.Platform.Universes.Events;

internal class UniverseChangeReporter : IObservable<UniverseEntityEvent>
{
	private class Unsubscriber : IDisposable
	{
		private readonly UniverseChangeReporter _Reporter;

		private readonly IObserver<UniverseEntityEvent> _Observer;

		public Unsubscriber(UniverseChangeReporter reporter, IObserver<UniverseEntityEvent> observer)
		{
			_Reporter = reporter;
			_Observer = observer;
		}

		public void Dispose()
		{
			_Reporter.ObserverActions -= _Observer.OnNext;
		}
	}

	private event Action<UniverseEntityEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<UniverseEntityEvent> observer)
	{
		ObserverActions += observer.OnNext;
		return new Unsubscriber(this, observer);
	}

	public virtual void EntityChanged(long universeId, UniverseChangeType changeType)
	{
		UniverseEntityEvent entityEvent = new UniverseEntityEvent(universeId, changeType);
		this.ObserverActions?.Invoke(entityEvent);
	}
}
