using System;
using Roblox.EventLog;
using Roblox.Platform.Assets.Events;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets;

/// <inheritdoc />
/// <seealso cref="T:Roblox.Platform.Assets.IAssetReverter" />
public class AssetReverter : IAssetReverter
{
	private readonly ILogger _Logger;

	private readonly AssetDomainFactories _AssetDomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Assets.AssetReverter" /> class.
	/// </summary>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Assets.AssetDomainFactories" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// logger
	/// or
	/// domainFactories
	/// </exception>
	public AssetReverter(ILogger logger, AssetDomainFactories domainFactories)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AssetDomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	/// <inheritdoc />
	public void Reset(IAsset asset)
	{
		Revert(asset, 1, isSavedVersionOnly: false);
	}

	/// <inheritdoc />
	public void Revert(IAssetVersion previousAssetVersion, bool isSavedVersionOnly)
	{
		previousAssetVersion.VerifyIsNotNull();
		IAsset asset = previousAssetVersion.GetAsset();
		Revert(asset, previousAssetVersion, isSavedVersionOnly);
	}

	/// <inheritdoc />
	public void Revert(IAsset asset, int versionNumberRevertingTo, bool isSavedVersionOnly)
	{
		IAssetVersion assetVersion = _AssetDomainFactories.AssetVersionFactory.GetByAssetAndVersionNumber(asset, versionNumberRevertingTo);
		Revert(asset, assetVersion, isSavedVersionOnly);
	}

	/// <inheritdoc />
	public void Revert(IAsset asset, IAssetVersion previousAssetVersionRevertingTo, bool isSavedVersionOnly)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (previousAssetVersionRevertingTo == null)
		{
			throw new ArgumentNullException("previousAssetVersionRevertingTo");
		}
		if (asset.Id != previousAssetVersionRevertingTo.AssetId)
		{
			string message = $"Attempt revert asset {asset.Id} to an AssetVersion that does not belong to it ({previousAssetVersionRevertingTo.Id}).";
			_Logger.Warning(message);
			throw new ArgumentException("previousAssetVersionRevertingTo");
		}
		IAssetVersion currentAssetVersion = _AssetDomainFactories.AssetVersionFactory.GetCurrentAssetVersion(asset);
		if (previousAssetVersionRevertingTo.Id != currentAssetVersion.Id)
		{
			IAssetVersion previousAssetVersionParent = previousAssetVersionRevertingTo.GetParentAssetVersion();
			IRawContent previousRawContent = previousAssetVersionRevertingTo.GetRawContent();
			_AssetDomainFactories.AssetVersionFactory.Create(asset, previousAssetVersionRevertingTo.CreatorType, previousAssetVersionRevertingTo.CreatorTargetId, previousRawContent, previousAssetVersionParent, previousAssetVersionRevertingTo.CreatingUniverseId, null, isSavedVersionOnly);
			if (Settings.Default.IsAssetChangeOnRevertReportingEnabled)
			{
				_AssetDomainFactories.AssetChangeReporter.EntityChanged(asset.Id, asset.TypeId, Roblox.Platform.Assets.Events.AssetChangeType.Reverted);
			}
		}
	}
}
