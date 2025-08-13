using System;
using System.Collections.Generic;

namespace Roblox.Platform.Assets;

/// <summary>
/// Interface of authority to handle asset genre reads and writes.
/// </summary>
public interface IAssetGenreAuthority
{
	/// <summary>
	/// Reads asset genres associated with a given <paramref name="asset" /> instance.
	/// </summary>
	/// <param name="asset">An instance of IAsset</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <returns>A collection of asset genre names</returns>
	IEnumerable<string> Read(IAsset asset);

	/// <summary>
	/// Reads asset genres associated with a given <paramref name="asset" /> instance.
	/// </summary>
	/// <param name="asset">An instance of IAsset</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <returns>A collection of asset genres</returns>
	IEnumerable<AssetGenre> ReadAsGenres(IAsset asset);

	/// <summary>
	/// Updates asset genres on the given <paramref name="asset" /> with the given genre names.
	/// </summary>
	/// <param name="asset">An instance of <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="genreNames">A collection of string genre names</param>
	/// <param name="forceUpdate">Perform an update whether or not the genres have changed</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="genreNames" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when one of the given <paramref name="genreName" />'s is invalid /&gt;</exception>
	void Write(IAsset asset, IEnumerable<string> genreNames, bool forceUpdate = false);

	/// <summary>
	/// Updates an asset genre with the given genre name.
	/// </summary>
	/// <param name="asset">An instance of <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="genreName">A string genre name</param>
	/// <param name="forceUpdate">Perform an update whether or not the genres have changed</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="genreName" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="genreName" /> is invalid /&gt;</exception>
	void Write(IAsset asset, string genreName, bool forceUpdate = false);

	/// <summary>
	/// Updates an asset genre with the given genre ID.
	/// </summary>
	/// <param name="asset">An instance of <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="genreId">An ID representing a unique <see cref="T:Roblox.AssetGenre" /></param>
	/// <param name="forceUpdate">Perform an update whether or not the genres have changed</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when <paramref name="genreId" /> is invalid /&gt;</exception>
	[Obsolete("Shouldn't be updating genres by ID as this exposes low level DB details.")]
	void Write(IAsset asset, byte genreId, bool forceUpdate = false);

	/// <summary>
	/// Updates asset genres on the given <paramref name="asset" /> with the given list of <see cref="T:Roblox.Platform.Assets.AssetGenre" />.
	/// </summary>
	/// <param name="asset">An instance of <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="genres">A collection of <see cref="T:Roblox.Platform.Assets.AssetGenre" /></param>
	/// <param name="forceUpdate">Perform an update whether or not the genres have changed</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="genreNames" /> is <see langword="null" /></exception>
	/// <exception cref="T:System.ArgumentException">Thrown when one of the given <paramref name="genreName" />'s is invalid /&gt;</exception>
	void Write(IAsset asset, IEnumerable<AssetGenre> genres, bool forceUpdate = false);
}
