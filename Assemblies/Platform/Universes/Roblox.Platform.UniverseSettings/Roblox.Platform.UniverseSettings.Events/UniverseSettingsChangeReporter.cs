using System;

namespace Roblox.Platform.UniverseSettings.Events;

internal class UniverseSettingsChangeReporter : IObservable<UniverseSettingsEvent>
{
	private class Unsubscriber : IDisposable
	{
		private readonly UniverseSettingsChangeReporter _Reporter;

		private readonly IObserver<UniverseSettingsEvent> _Observer;

		public Unsubscriber(UniverseSettingsChangeReporter reporter, IObserver<UniverseSettingsEvent> observer)
		{
			_Reporter = reporter;
			_Observer = observer;
		}

		public void Dispose()
		{
			_Reporter.ObserverActions -= _Observer.OnNext;
		}
	}

	private event Action<UniverseSettingsEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<UniverseSettingsEvent> observer)
	{
		ObserverActions += observer.OnNext;
		return new Unsubscriber(this, observer);
	}

	public virtual void EntityChanged(long universeId)
	{
		UniverseSettingsEvent entityEvent = new UniverseSettingsEvent(universeId);
		this.ObserverActions?.Invoke(entityEvent);
	}
}
