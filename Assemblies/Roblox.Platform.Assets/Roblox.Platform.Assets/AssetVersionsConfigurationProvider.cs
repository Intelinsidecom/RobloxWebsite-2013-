using System;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

/// <summary>
/// Provides configuration for AssetsVersions
/// </summary>
internal class AssetVersionsConfigurationProvider : IAssetVersionsConfigurationProvider
{
	private readonly ISettings _Settings;

	/// <summary>
	/// Default constructor.
	/// </summary>
	internal AssetVersionsConfigurationProvider()
		: this(Settings.Default)
	{
	}

	/// <summary>
	/// Unit test friendly constructor.
	/// </summary>
	/// <param name="settings"></param>
	internal AssetVersionsConfigurationProvider(ISettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException(string.Format("{0}", "settings"));
	}

	/// <inheritdoc />
	public bool IsPublishToAssetPublishedVersionsEnabledForAssetType(AssetType assetType)
	{
		if (assetType == AssetType.Place)
		{
			return _Settings.IsPublishToAssetPublishedVersionEnabled;
		}
		return false;
	}

	/// <inheritdoc />
	public bool IsServeFromAssetPublishedVersionsEnabledForAssetType(AssetType assetType, long assetId)
	{
		if (assetType == AssetType.Place)
		{
			return Math.Abs(assetId % 100) < _Settings.DeliveryFromAssetPublishedVersionRolloutPercentage;
		}
		return false;
	}
}
