using System;

namespace Roblox.Platform.Assets.Events;

internal class AssetChangeReporter : IObservable<AssetEntityEvent>
{
	private class Unsubscriber : IDisposable
	{
		private readonly AssetChangeReporter _Reporter;

		private readonly IObserver<AssetEntityEvent> _Observer;

		public Unsubscriber(AssetChangeReporter reporter, IObserver<AssetEntityEvent> observer)
		{
			_Reporter = reporter;
			_Observer = observer;
		}

		public void Dispose()
		{
			_Reporter.ObserverActions -= _Observer.OnNext;
		}
	}

	private event Action<AssetEntityEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<AssetEntityEvent> observer)
	{
		ObserverActions += observer.OnNext;
		return new Unsubscriber(this, observer);
	}

	public virtual void EntityChanged(long assetId, int assetTypeId, AssetChangeType assetChangeType, long? authorUserId = null)
	{
		AssetEntityEvent entityEvent = new AssetEntityEvent(assetId, Extensions.GetAssetType(assetTypeId).GetValueOrDefault(), assetChangeType, authorUserId);
		this.ObserverActions?.Invoke(entityEvent);
	}
}
