using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Events;
using Roblox.Platform.GameLocalization.Properties;

namespace Roblox.Platform.GameLocalization;

/// <inheritdoc />
public class GameLocalizationChangeEventsPublisher : IGameLocalizationChangeEventsPublisher, IObserver<GameLocalizationChangeEvent>
{
	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	private readonly ISnsEventPublisher<GameLocalizationChangeEvent> _Publisher;

	private IDisposable _Disposable;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.GameLocalization.GameLocalizationChangeEventsPublisher" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry"></param>
	public GameLocalizationChangeEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: this(new SnsEventPublisher(logger, counterRegistry), Settings.Default, logger)
	{
	}

	internal GameLocalizationChangeEventsPublisher(ISnsEventPublisher<GameLocalizationChangeEvent> publisher, ISettings settings, ILogger logger)
	{
		_Publisher = publisher ?? throw new PlatformArgumentNullException("publisher");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	/// <inheritdoc />
	public void OnCompleted()
	{
		Unsubscribe();
	}

	/// <inheritdoc />
	public void OnError(Exception error)
	{
		_Logger.Error(error);
	}

	/// <inheritdoc />
	public void OnNext(GameLocalizationChangeEvent value)
	{
		if (value != null && _Settings.IsPublishToGameLocalizationChangeTopicEnabled)
		{
			_Publisher.Publish(value);
		}
	}

	/// <inheritdoc />
	public void Subscribe(IObservable<GameLocalizationChangeEvent> observable)
	{
		_Disposable = observable.Subscribe(this);
	}

	/// <inheritdoc />
	public void Unsubscribe()
	{
		_Disposable.Dispose();
	}
}
