using System;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

internal class AssetDependenciesConfigurationProvider : IAssetDependenciesConfigurationProvider
{
	private readonly ISettings _Settings;

	/// <summary>
	/// Default constructor.
	/// </summary>
	internal AssetDependenciesConfigurationProvider()
		: this(Settings.Default)
	{
	}

	/// <summary>
	/// Unit test friendly constructor.
	/// </summary>
	/// <param name="settings"></param>
	internal AssetDependenciesConfigurationProvider(ISettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException(string.Format("{0}", "settings"));
	}

	public bool IsCreateAssetDependencyAllowedForAsset(long assetId)
	{
		return Math.Abs(assetId % 100) < Settings.Default.AssetDependenciesServiceWriteRolloutPercentage;
	}
}
