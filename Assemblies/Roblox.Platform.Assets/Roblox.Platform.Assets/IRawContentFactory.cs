using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Roblox.Platform.Assets;

/// <summary>
/// Factory for accesing <see cref="T:Roblox.Platform.Assets.IRawContent" /> objects.
/// These are a thin layer over the underlying AssetHash object in the DB, this is effectively the Platform version.
/// </summary>
public interface IRawContentFactory
{
	/// <summary>
	/// Load the AssetHash for the given Id.
	/// Throws if the item is not found.
	/// </summary>
	/// <param name="id"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given Id</returns>
	/// <exception cref="T:Roblox.Platform.Assets.UnknownRawContentException"></exception>
	IRawContent CheckedGet(long? id);

	/// <summary>
	/// Get the AssetHash for the given AssetType and Hash.
	/// If the item does not exist, it will be created under the given Creator using the given stream and settings.
	/// </summary>
	/// <param name="assetTypeId"></param>
	/// <param name="creatorType"></param>
	/// <param name="creatorTargetId"></param>
	/// <param name="content"></param>
	/// <param name="decompressionMethod"></param>
	/// <param name="expectedContentSize"></param>
	/// <param name="expectedContentHash"></param>
	/// <param name="mimeType"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given values or null if not found.</returns>
	IRawContent GetOrCreate(int assetTypeId, CreatorType creatorType, long creatorTargetId, Stream content, DecompressionMethods decompressionMethod = DecompressionMethods.None, int? expectedContentSize = null, string expectedContentHash = null, string mimeType = null);

	/// <summary>
	/// Get the AssetHash for the given AssetType and Hash.
	/// If the item does not exist, it will be created under the given Creator.
	/// </summary>
	/// <param name="assetTypeId"></param>
	/// <param name="creatorType"></param>
	/// <param name="creatorTargetId"></param>
	/// <param name="contentMd5Hash"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given values or null if not found.</returns>
	IRawContent GetOrCreate(int assetTypeId, CreatorType creatorType, long creatorTargetId, string contentMd5Hash);

	/// <summary>
	/// Load the AssetHash for the given Id.
	/// </summary>
	/// <param name="id"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given Id or null if not found.</returns>
	IRawContent Get(long? id);

	/// <summary>
	/// Load the AssetHash for the given AssetType and Hash value.
	/// </summary>
	/// <param name="assetType"></param>
	/// <param name="md5Hash"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given values or null if not found.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"></exception>
	IRawContent GetByAssetTypeAndMd5hash(AssetType assetType, string md5Hash);

	/// <summary>
	/// Load the AssetHash for the given Hash value.
	/// </summary>
	/// <param name="md5Hash"></param>
	/// <param name="startRowIndex"></param>
	/// <param name="maximumRows"></param>
	/// <returns></returns>
	IEnumerable<IRawContent> GetByMd5HashPaged(string md5Hash, int startRowIndex, int maximumRows);

	/// <summary>
	/// Load the AssetHash for the given AssetType and Hash value.
	/// </summary>
	/// <param name="assetTypeId"></param>
	/// <param name="md5Hash"></param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.IRawContent" /> matching the given values or null if not found.</returns>
	[Obsolete("Use version with AssetType instead.")]
	IRawContent GetByAssetTypeAndMd5hash(int assetTypeId, string md5Hash);
}
