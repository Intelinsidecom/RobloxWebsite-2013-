using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Assets;
using Roblox.Platform.AudioRightsManagement.Properties;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightCheckerTaskPublisher" />.
/// </summary>
public class AudioCopyrightCheckerTaskPublisher : IAudioCopyrightCheckerTaskPublisher
{
	private SnsPublisher _SnsPublisher;

	private readonly ILogger _Logger;

	private readonly int _AudioAssetTypeId = AssetType.Audio.ToId();

	private readonly ISettings _Settings;

	private ICounterRegistry _CounterRegistry;

	public AudioCopyrightCheckerTaskPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: this(logger, Settings.Default, counterRegistry)
	{
	}

	internal AudioCopyrightCheckerTaskPublisher(ILogger logger, ISettings settings, ICounterRegistry counterRegistry)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry;
		_Settings.MonitorChanges((ISettings s) => s.AudioReviewEventsSnsTopicArn, RebuildSnsPublisher);
		_Settings.MonitorChanges((ISettings s) => s.AudioReviewEventsPublisherAwsAccessKeyAndSecretKey, RebuildSnsPublisher);
		RebuildSnsPublisher();
	}

	/// <inheritdoc />
	public void PublishTaskForAudioAssetVersion(IAssetVersion assetVersion)
	{
		if (_SnsPublisher == null)
		{
			throw new InvalidOperationException("SnsPublisher not properly configured.");
		}
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		if (assetVersion.GetAsset().TypeId != _AudioAssetTypeId)
		{
			throw new ArgumentException("IAssetVersion does not belong to an audio asset.", "assetVersion");
		}
		AudioReviewEventsMessage message = new AudioReviewEventsMessage
		{
			AssetVersionId = assetVersion.Id
		};
		_SnsPublisher.Publish(message);
	}

	private void RebuildSnsPublisher()
	{
		string[] awsKeys = Settings.Default.AudioReviewEventsPublisherAwsAccessKeyAndSecretKey.Split(',');
		if (awsKeys.Length == 2)
		{
			_SnsPublisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.AudioReviewEventsSnsTopicArn, "Roblox.AudioReviewEventsPublisher", _CounterRegistry);
			_SnsPublisher.SnsError += delegate(Exception e, string _)
			{
				_Logger.Error(e);
			};
			_SnsPublisher.ErrorOnPublishersRebuildOccurred += delegate(Exception e)
			{
				_Logger.Error(e);
			};
		}
	}
}
