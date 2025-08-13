using Roblox.Agents;
using Roblox.Platform.Assets.Entities.AssetHash;
using Roblox.Platform.Assets.Entities.Audit;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets.Entities;

internal interface IAssetEntityFactory
{
	/// <summary>
	/// Get an <see cref="T:Roblox.Platform.Assets.Entities.IAssetEntity" /> based on its id.
	/// </summary>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Assets.Entities.IAssetEntity" />, or null if data is not found.</returns>
	IAssetEntity Get(long id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Assets.Entities.IAssetEntity" /> based on its id, and check that it is not null.
	/// </summary>
	/// <returns>The corresponding <see cref="T:Roblox.Platform.Assets.Entities.IAssetEntity" /></returns>
	/// <exception cref="T:System.InvalidOperationException">If the data is not found.</exception>
	IAssetEntity MustGet(long id);

	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.Assets.Entities.IAssetEntity" /> based on the provided information.
	/// </summary>
	/// <returns><see cref="T:Roblox.Platform.Core.DataUpdateResult`2" /></returns>
	DataUpdateResult<IAssetEntity, IAssetsAuditEntryEntity> Create(Roblox.AssetType assetTypeEntity, IAssetHashEntity assetHash, ITrustedAssetTextInfo trustedAssetTextInfo, IAgent creatorAgent);
}
