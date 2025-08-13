using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.GameLocalization.Events;

internal class GameLocalizationChangeUnsubscriber : IDisposable
{
	private readonly GameLocalizationChangeReporter _Reporter;

	private readonly IObserver<GameLocalizationChangeEvent> _Observer;

	public GameLocalizationChangeUnsubscriber(GameLocalizationChangeReporter reporter, IObserver<GameLocalizationChangeEvent> observer)
	{
		_Reporter = reporter ?? throw new PlatformArgumentNullException("reporter");
		_Observer = observer ?? throw new PlatformArgumentNullException("observer");
	}

	public void Dispose()
	{
		_Reporter.ObserverActions -= _Observer.OnNext;
	}
}
