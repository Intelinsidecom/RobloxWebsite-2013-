using System;
using System.ComponentModel;

namespace Roblox.Platform.Assets.Properties;

public interface ISettings : INotifyPropertyChanged
{
	bool IsAssetWithFullyModeratedTextBlocked { get; }

	bool AreMeshPartsEnabled { get; }

	string AssetVersionCreationEventsSnsAwsAccessKeyAndSecretCSV { get; }

	string AssetVersionCreationEventsSnsTopicArn { get; }

	bool IsCloudSavedGamesEnabled { get; }

	int AssetVersionLookUpParallelizationDegree { get; }

	bool IsPublishToAssetPublishedVersionEnabled { get; }

	bool AssetCreationNoContextEnabled { get; }

	int DeliveryFromAssetPublishedVersionRolloutPercentage { get; }

	bool IsAssetVersionIdSetToZeroLoggingEnabled { get; }

	bool DisableAssetTextFilter { get; }

	/// <summary>
	/// Rollout percentage of using Assets service for <see cref="M:Roblox.Platform.Assets.AssetOptionFactory.Get(System.Int64)" />
	/// </summary>
	int UseAssetsServiceForAssetOptionFactoryGetRolloutPercentage { get; }

	/// <summary>
	/// Rollout percentage of using Assets service for <see cref="M:Roblox.Platform.Assets.AssetOptionFactory.GetOrCreate(System.Int64)" />
	/// </summary>
	int UseAssetsServiceForAssetOptionFactoryGetOrCreateRolloutPercentage { get; }

	/// <summary>
	/// Is delayed place launch for JV requests enabled
	/// </summary>
	bool IsJvDelayedPlaceLaunchEnabled { get; }

	/// <summary>
	/// The time span that JV games need to be delayed for. 
	/// </summary>
	TimeSpan JvPlaceLaunchDelayTimeSpan { get; }

	/// <summary>
	/// JV Delay time span will be rounded up to the closest time span set by this setting.
	/// If this is set to 1 hour. The JvPlaceLaunchDelayTimeSpan will be rounded to the nearest hour. 
	/// </summary>
	TimeSpan JvPlaceLaunchRoundUpToNearestTimeSpan { get; }

	/// <summary>
	/// Rollout percentage of using Assets service for <see cref="M:Roblox.Platform.Assets.AssetOptionFactory.Save(Roblox.Platform.Assets.IAssetOption)" />
	/// </summary>
	int UseAssetsServiceForAssetOptionFactorySaveRolloutPercentage { get; }
}
