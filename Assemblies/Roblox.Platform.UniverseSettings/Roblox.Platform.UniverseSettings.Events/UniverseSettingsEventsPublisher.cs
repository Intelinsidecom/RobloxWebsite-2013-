using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings.Events;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.UniverseSettings.Events.IUniverseSettingsEventsObserver" /> to get notifications of 
/// events and publishes them to a Universe settings entity changed SNS topic.
/// </summary>
internal class UniverseSettingsEventsPublisher : IUniverseSettingsEventsObserver, IObserver<UniverseSettingsEvent>
{
	private readonly ILogger _Logger;

	private SnsPublisher _Publisher;

	private string _AccessKeyAndSecretCsv;

	private string _SnsTopicArn;

	private IDisposable _Observable;

	private readonly ICounterRegistry _CounterRegistry;

	private string Name => "UniverseSettingsEventsPublisher";

	public UniverseSettingsEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.AwsUniverseSettingsChangeTopicAccessKeyIdAndSecretCsv, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.AwsUniverseSettingsChangeSnsTopicArn, InitializePublisher);
	}

	/// <inheritdoc />
	public void Subscribe(IObservable<UniverseSettingsEvent> observable)
	{
		_Observable = observable.Subscribe(this);
	}

	/// <inheritdoc />
	public void Unsubscribe()
	{
		_Observable.Dispose();
	}

	/// <inheritdoc />
	public void OnNext(UniverseSettingsEvent value)
	{
		if (Settings.Default.IsPublishToUniverseSettingsChangeTopicEnabled && value != null)
		{
			if (_Publisher == null)
			{
				_Logger.Error($"{Name} has a null SNS publisher! universeId:{value.UniverseId}");
			}
			else
			{
				_Publisher.Publish(value);
			}
		}
	}

	/// <summary>
	/// This is not implemented.
	/// </summary>
	/// <param name="error"></param>
	/// <exception cref="T:System.NotImplementedException"></exception>
	public void OnError(Exception error)
	{
		throw new NotImplementedException();
	}

	/// <inheritdoc />
	public void OnCompleted()
	{
		Unsubscribe();
	}

	private void InitializePublisher()
	{
		VerifyAndCreatePublisher(_AccessKeyAndSecretCsv, _SnsTopicArn, Settings.Default.AwsUniverseSettingsChangeTopicAccessKeyIdAndSecretCsv, Settings.Default.AwsUniverseSettingsChangeSnsTopicArn);
	}

	private void VerifyAndCreatePublisher(string previousKeyAndSecret, string previousTopicArn, string newAccessKeyIdAndSecretCsv, string newSnsTopicArn)
	{
		if (_Publisher != null && previousKeyAndSecret == newAccessKeyIdAndSecretCsv && previousTopicArn == newSnsTopicArn)
		{
			return;
		}
		string initOrReinit = ((_Publisher == null) ? "Initializing" : "Re-initializing");
		_Logger.Info($"{initOrReinit} {Name}");
		string[] keyAndSecret = newAccessKeyIdAndSecretCsv.Split(',');
		if (keyAndSecret.Length != 2)
		{
			_Logger.Error($"{initOrReinit} {Name}, invalid AWS Key ID & Secret CSV.");
			return;
		}
		string keyId = keyAndSecret[0];
		string secretKey = keyAndSecret[1];
		try
		{
			_Publisher = new SnsPublisher(keyId, secretKey, RegionEndpoint.USEast1, newSnsTopicArn, $"Roblox.{Name}", _CounterRegistry);
			_Publisher.SnsError += OnSnsError;
		}
		catch (ArgumentException ex)
		{
			_Logger.Error($"{initOrReinit} {Name} failed: {ex}");
		}
		_AccessKeyAndSecretCsv = newAccessKeyIdAndSecretCsv;
		_SnsTopicArn = newSnsTopicArn;
	}

	private void OnSnsError(Exception e, string message)
	{
		_Logger.Error($"Error sending {Name} SNS: {e}.\nMessage: {message}");
	}
}
