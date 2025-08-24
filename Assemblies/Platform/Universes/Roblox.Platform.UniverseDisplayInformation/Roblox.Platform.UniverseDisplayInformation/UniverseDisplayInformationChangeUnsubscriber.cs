using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class UniverseDisplayInformationChangeUnsubscriber : IDisposable
{
	private readonly IUniverseDisplayInformationChangeReporter _Reporter;

	private readonly IObserver<UniverseDisplayInformationChangeEvent> _Observer;

	public UniverseDisplayInformationChangeUnsubscriber(IUniverseDisplayInformationChangeReporter reporter, IObserver<UniverseDisplayInformationChangeEvent> observer)
	{
		_Reporter = reporter.AssignOrThrowIfNull("reporter");
		_Observer = observer.AssignOrThrowIfNull("observer");
	}

	public void Dispose()
	{
		_Reporter.Unsubscribe(_Observer);
	}
}
