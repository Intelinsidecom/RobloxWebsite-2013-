using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets.Events;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

/// <summary>
/// AssetEventsPublisher implements <see cref="T:Roblox.Platform.Assets.Events.IAssetEventsObserver" /> to get notifications of 
/// events and publishes changes to Asset Archival Status
/// </summary>
public class AssetArchivalEventsPublisher : IAssetEventsObserver, IObserver<AssetEntityEvent>
{
	private readonly ILogger _Logger;

	private SnsPublisher _Publisher;

	private string _AccessKeyAndSecretCsv;

	private string _SnsTopicArn;

	private IDisposable _Observable;

	private readonly ICounterRegistry _CounterRegistry;

	private const string Name = "AssetArchivalEventsPublisher";

	public AssetArchivalEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("logger");
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.AwsAssetArchivalChangeTopicAccessIdAndSecretCsv, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.AwsAssetArchivalChangeSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		VerifyAndCreatePublisher(_AccessKeyAndSecretCsv, _SnsTopicArn, Settings.Default.AwsAssetArchivalChangeTopicAccessIdAndSecretCsv, Settings.Default.AwsAssetArchivalChangeSnsTopicArn);
	}

	private void VerifyAndCreatePublisher(string previousKeyAndSecret, string previousTopicArn, string newAccessKeyIdAndSecretCsv, string newSnsTopicArn)
	{
		if (_Publisher != null && previousKeyAndSecret == newAccessKeyIdAndSecretCsv && previousTopicArn == newSnsTopicArn)
		{
			return;
		}
		string initOrReinit = ((_Publisher == null) ? "Initializing" : "Re-initializing");
		_Logger.Info(string.Format("{0} {1}", initOrReinit, "AssetArchivalEventsPublisher"));
		string[] keyAndSecret = newAccessKeyIdAndSecretCsv.Split(',');
		if (keyAndSecret.Length != 2)
		{
			_Logger.Error(string.Format("{0} {1}, invalid AWS Key ID & Secret CSV.", initOrReinit, "AssetArchivalEventsPublisher"));
			return;
		}
		string keyId = keyAndSecret[0];
		string secretKey = keyAndSecret[1];
		try
		{
			_Publisher = new SnsPublisher(keyId, secretKey, RegionEndpoint.USEast1, newSnsTopicArn, string.Format("Roblox.{0}", "AssetArchivalEventsPublisher"), _CounterRegistry);
			_Publisher.SnsError += OnSnsError;
		}
		catch (ArgumentException ex)
		{
			_Logger.Error(string.Format("{0} {1} failed: {2}", initOrReinit, "AssetArchivalEventsPublisher", ex));
		}
		_AccessKeyAndSecretCsv = newAccessKeyIdAndSecretCsv;
		_SnsTopicArn = newSnsTopicArn;
	}

	public void OnNext(AssetEntityEvent value)
	{
		if (Settings.Default.IsAwsAssetArchivalChangePublishingEnabled && value != null)
		{
			if (_Publisher == null)
			{
				_Logger.Error(string.Format("{0} has a null SNS publisher! assetId:{1}", "AssetArchivalEventsPublisher", value.AssetId));
			}
			else if (value.AssetChangeType.Equals(AssetChangeType.Archived.ToString(), StringComparison.InvariantCultureIgnoreCase) || value.AssetChangeType.Equals(AssetChangeType.Unarchived.ToString(), StringComparison.InvariantCultureIgnoreCase))
			{
				_Publisher.Publish(value);
			}
		}
	}

	/// <inheritdoc />
	public void Subscribe(IObservable<AssetEntityEvent> observable)
	{
		if (observable != null)
		{
			_Observable = observable.Subscribe(this);
		}
	}

	/// <inheritdoc />
	public void Unsubscribe()
	{
		_Observable?.Dispose();
	}

	private void OnSnsError(Exception e, string message)
	{
		_Logger.Error(string.Format("Error sending {0} SNS: {1}.\nMessage: {2}", "AssetArchivalEventsPublisher", e, message));
	}

	public void OnCompleted()
	{
		Unsubscribe();
	}

	public void OnError(Exception error)
	{
		throw new NotImplementedException();
	}
}
