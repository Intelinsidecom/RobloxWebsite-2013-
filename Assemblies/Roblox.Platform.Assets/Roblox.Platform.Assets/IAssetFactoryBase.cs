using System;
using System.Collections.Generic;
using Roblox.Assets.Client;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

/// <summary>
/// A base class for the factory producing types of <see cref="T:Roblox.Platform.Assets.IAsset" />s.
/// </summary>
/// <typeparam name="T">The type of <see cref="T:Roblox.Platform.Assets.IAsset" /> the factory produces</typeparam>
public interface IAssetFactoryBase<T> where T : IAsset
{
	/// <summary>
	/// Gets the <typeparamref name="T" /> of the specified id.
	/// </summary>
	T Get(long id);

	/// <summary>
	/// Gets the <typeparamref name="T" /> for the specified ids.
	/// </summary>
	/// <param name="ids">The ids of the assets we are interested in.</param>
	/// <param name="filterNulls">Whether or not to filter nulls out of the response.</param>
	/// <returns>The requested <typeparamref name="T" />s.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="ids" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="ids" /> is empty.</exception>
	IEnumerable<T> Get(IReadOnlyCollection<long> ids, bool filterNulls = false);

	/// <summary>
	/// Gets the <typeparamref name="T" /> of the specified id.
	/// </summary>
	/// <returns>The <typeparamref name="T" /> of the specified id.  Never returns null.</returns>
	/// <exception cref="T:Roblox.Platform.Assets.UnknownAssetException">If no asset exists corresponding to the specified id</exception>
	[Obsolete("Should use Get(long) and handle null explicitly.")]
	T CheckedGet(long id);

	/// <summary>
	/// Creates an <typeparamref name="T" /> with the specified info.
	/// </summary>
	T Create(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, StreamCreatorInfo stream, IUserIdentifier actorUserIdentifier);

	/// <summary>
	/// Creates an <typeparamref name="T" /> with the specified info.
	/// </summary>
	T Create(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentifier);

	/// <summary>
	/// Creates an <typeparamref name="T" /> with the specified info, and creates a dependency in the AssetDependencies service.
	/// </summary>
	T CreateWithDependency(IAssetNameAndDescription assetNameAndDescription, AssetCreatorInfo assetCreatorInfo, IRawContent rawContent, IUserIdentifier actorUserIdentifier, IImage image, AssetType dependsAssetType);
}
