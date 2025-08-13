using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.Assets.IAssetVersionCreationEventPublisher" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Assets.IAssetVersionCreationEventPublisher" />.
internal class AssetVersionCreationEventPublisher : IAssetVersionCreationEventPublisher
{
	private SnsPublisher _SnsPublisher;

	private readonly ISettings _Settings;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Assets.AssetVersionCreationEventPublisher" /> class.
	/// </summary>
	public AssetVersionCreationEventPublisher(ISettings settings, ICounterRegistry counterRegistry)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		_Settings.MonitorChanges((ISettings s) => s.AssetVersionCreationEventsSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		_Settings.MonitorChanges((ISettings s) => s.AssetVersionCreationEventsSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = _Settings.AssetVersionCreationEventsSnsAwsAccessKeyAndSecretCSV.Split(',');
		if (awsKeys.Length == 2)
		{
			_SnsPublisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, _Settings.AssetVersionCreationEventsSnsTopicArn, "Roblox.AssetVersionCreationEventPublisher", _CounterRegistry);
		}
	}

	public void Publish(IAssetVersion assetVersion, string localeCodeOverride = null)
	{
		if (assetVersion != null)
		{
			AssetVersionCreationEvent assetVersionCreationEvent = new AssetVersionCreationEvent
			{
				AssetVersionId = assetVersion.Id,
				LocaleCodeOverride = localeCodeOverride
			};
			_SnsPublisher.Publish(assetVersionCreationEvent);
		}
	}
}
