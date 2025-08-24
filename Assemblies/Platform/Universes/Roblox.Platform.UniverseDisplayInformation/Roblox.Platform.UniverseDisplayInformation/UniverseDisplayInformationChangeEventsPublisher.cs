using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.UniverseDisplayInformation.Properties;

namespace Roblox.Platform.UniverseDisplayInformation;

/// <inheritdoc />
internal class UniverseDisplayInformationChangeEventsPublisher : IUniverseDisplayInformationChangeEventsPublisher, IObserver<UniverseDisplayInformationChangeEvent>
{
	private readonly ISnsEventPublisher<UniverseDisplayInformationChangeEvent> _SnsEventSnsEventPublisher;

	private readonly IUniverseDisplayInformationChangeEventsPublisherSettings _Settings;

	private readonly ILogger _Logger;

	private IDisposable _Disposable;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.UniverseDisplayInformation.UniverseDisplayInformationChangeEventsPublisher" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	public UniverseDisplayInformationChangeEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: this(new SnsEventPublisher(logger, counterRegistry), Settings.Default, logger)
	{
	}

	internal UniverseDisplayInformationChangeEventsPublisher(ISnsEventPublisher<UniverseDisplayInformationChangeEvent> snsEventPublisher, IUniverseDisplayInformationChangeEventsPublisherSettings settings, ILogger logger)
	{
		_SnsEventSnsEventPublisher = snsEventPublisher.AssignOrThrowIfNull("snsEventPublisher");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_Logger = logger.AssignOrThrowIfNull("logger");
	}

	/// <inheritdoc />
	public void OnNext(UniverseDisplayInformationChangeEvent value)
	{
		if (value != null && _Settings.IsPublishToUniverseDisplayInformationChangeTopicEnabled)
		{
			_SnsEventSnsEventPublisher.Publish(value);
		}
	}

	/// <inheritdoc />
	public void OnError(Exception error)
	{
		_Logger.Error(error);
	}

	/// <inheritdoc />
	public void OnCompleted()
	{
		Unsubscribe();
	}

	/// <inheritdoc />
	public void Subscribe(IObservable<UniverseDisplayInformationChangeEvent> observable)
	{
		_Disposable = observable.Subscribe(this);
	}

	/// <inheritdoc />
	public void Unsubscribe()
	{
		_Disposable?.Dispose();
	}
}
