using System;
using Roblox.Assets.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.Assets.IAssetVersionPublisher" />
/// </summary>
public class AssetVersionPublisher : IAssetVersionPublisher
{
	private IAssetsClient _AssetsClient;

	private IAssetTypeFactory _AssetTypeFactory;

	private IAssetFactory _AssetFactory;

	private IAssetVersionsConfigurationProvider _AssetVersionsConfig;

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="assetsClient">Client to Assets service.</param>
	/// <param name="assetFactory"></param>
	/// <exception cref="T:System.ArgumentNullException">All parameters are required.</exception>
	public AssetVersionPublisher(IAssetsClient assetsClient, IAssetFactory assetFactory)
		: this(assetsClient, assetFactory, AssetTypeFactory.Singleton, new AssetVersionsConfigurationProvider())
	{
	}

	/// <summary>
	/// Unit test friendly constructor.
	/// </summary>
	/// <param name="assetsClient">Client to Assets service.</param>
	/// <param name="assetFactory">Asset factory.</param>
	/// <param name="assetTypeFactory">Instance of <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" /></param>
	/// <param name="assetVersionsConfig">Configuration for publishing and serving asset versions.</param>
	/// <exception cref="T:System.ArgumentNullException">All parameters are required.</exception>
	internal AssetVersionPublisher(IAssetsClient assetsClient, IAssetFactory assetFactory, IAssetTypeFactory assetTypeFactory, IAssetVersionsConfigurationProvider assetVersionsConfig)
	{
		_AssetsClient = assetsClient ?? throw new ArgumentNullException("assetsClient");
		_AssetTypeFactory = assetTypeFactory ?? throw new ArgumentNullException("assetTypeFactory");
		_AssetFactory = assetFactory ?? throw new ArgumentNullException("assetFactory");
		_AssetVersionsConfig = assetVersionsConfig ?? throw new ArgumentNullException("assetVersionsConfig");
	}

	/// <inheritdoc />
	public bool IsAssetTypeSupported(int assetTypeId)
	{
		AssetType? assetType = _AssetTypeFactory.GetAssetType(assetTypeId);
		if (!assetType.HasValue)
		{
			throw new ApplicationException($"Asset type ID {assetTypeId} cannot be translated to platform AssetType enum");
		}
		return _AssetVersionsConfig.IsPublishToAssetPublishedVersionsEnabledForAssetType(assetType.Value);
	}

	/// <inheritdoc />
	public bool IsAssetTypeSupported(AssetType assetType)
	{
		return _AssetVersionsConfig.IsPublishToAssetPublishedVersionsEnabledForAssetType(assetType);
	}

	/// <inheritdoc />
	public void PublishAssetVersion(IAssetVersion assetVersion, CreatorType actorType, string actorTargetId)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		if (string.IsNullOrEmpty(actorTargetId))
		{
			throw new ArgumentException(string.Format("{0} is null or empty.", "actorTargetId"), "actorTargetId");
		}
		IAsset asset = _AssetFactory.GetAsset(assetVersion.AssetId);
		if (asset == null)
		{
			throw new ApplicationException($"Asset not found. Asset ID: {assetVersion.AssetId}.");
		}
		AssetType? assetType = _AssetTypeFactory.GetAssetType(asset.TypeId);
		if (!assetType.HasValue)
		{
			throw new ApplicationException($"Cannot get platform asset type for asset type ID {asset.TypeId}.");
		}
		if (!IsAssetTypeSupported(assetType.Value))
		{
			throw new NotSupportedException($"Asset type is not supported. Asset type ID: {asset.TypeId}.");
		}
		AssetType clientAssetType = _AssetTypeFactory.ToAssetsClientAssetType(assetType.Value);
		_AssetsClient.CreateAssetPublishedVersion(clientAssetType, asset.Id.ToString(), (long)assetVersion.VersionNumber, actorTargetId, actorType.ToString());
	}
}
