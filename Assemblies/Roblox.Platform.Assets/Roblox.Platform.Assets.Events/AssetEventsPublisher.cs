using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Events;

/// <summary>
/// AssetEventsPublisher implements <see cref="!:IUniverseEventsObserver" /> to get notifications of 
/// events and publishes them to a Universe entity changed SNS topic.
/// Note: this is not really an Asset Events publisher but a Place Events publisher
/// </summary>
internal class AssetEventsPublisher : IAssetEventsObserver, IObserver<AssetEntityEvent>
{
	private readonly ILogger _Logger;

	private SnsPublisher _Publisher;

	private string _AccessKeyAndSecretCsv;

	private string _SnsTopicArn;

	private IDisposable _Observable;

	private readonly ICounterRegistry _CounterRegistry;

	private string Name => "AssetEventsPublisher";

	public AssetEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.AwsAssetChangeTopicAccessKeyIdAndSecretCsv, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.AwsAssetChangeSnsTopicArn, InitializePublisher);
	}

	/// <inheritdoc />
	public void Subscribe(IObservable<AssetEntityEvent> observable)
	{
		_Observable = observable.Subscribe(this);
	}

	/// <inheritdoc />
	public void Unsubscribe()
	{
		_Observable.Dispose();
	}

	/// <inheritdoc />
	public void OnNext(AssetEntityEvent value)
	{
		if (Settings.Default.IsAwsAssetChangePublishingEnabled && value != null && value.AssetType.Equals(AssetType.Place.ToString()))
		{
			if (_Publisher == null)
			{
				_Logger.Error($"{Name} has a null SNS publisher! assetId:{value.AssetId}");
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
		VerifyAndCreatePublisher(_AccessKeyAndSecretCsv, _SnsTopicArn, Settings.Default.AwsAssetChangeTopicAccessKeyIdAndSecretCsv, Settings.Default.AwsAssetChangeSnsTopicArn);
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
