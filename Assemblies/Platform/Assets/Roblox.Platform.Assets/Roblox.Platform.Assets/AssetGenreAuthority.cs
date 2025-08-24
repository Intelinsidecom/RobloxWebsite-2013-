using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.IAssetGenreAuthority" />
public class AssetGenreAuthority : IAssetGenreAuthority
{
	/// <inheritdocs />
	public IEnumerable<string> Read(IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return from g in Roblox.AssetGenre.ConvertBitMaskToGenres(asset.AssetGenres)
			select g.DisplayName;
	}

	/// <inheritdocs />
	public IEnumerable<AssetGenre> ReadAsGenres(IAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return asset.GetAssetGenres();
	}

	/// <inheritdocs />
	public void Write(IAsset asset, IEnumerable<string> genreNames, bool forceUpdate = false)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (genreNames == null)
		{
			throw new ArgumentNullException("genreNames");
		}
		if (genreNames.Any((string n) => string.IsNullOrWhiteSpace(n)))
		{
			throw new ArgumentNullException("Genre name collection contains an null or empty genre name.", "genreNames");
		}
		List<Roblox.AssetGenre> assetGenreEntities = new List<Roblox.AssetGenre>();
		foreach (string genreName in genreNames)
		{
			Roblox.AssetGenre assetGenreEntity = Roblox.AssetGenre.GetByName(genreName);
			if (assetGenreEntity == null)
			{
				throw new ArgumentException($"genreName {genreName} not found.");
			}
			assetGenreEntities.Add(assetGenreEntity);
		}
		ulong genreBitMask = Roblox.AssetGenre.CoalesceAssetGenres(assetGenreEntities);
		Write(asset, genreBitMask, forceUpdate);
	}

	/// <inheritdocs />
	public void Write(IAsset asset, string genreName, bool forceUpdate = false)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (string.IsNullOrWhiteSpace(genreName))
		{
			throw new ArgumentNullException("genreName");
		}
		Roblox.AssetGenre assetGenreEntity = Roblox.AssetGenre.GetByName(genreName);
		if (assetGenreEntity == null)
		{
			throw new ArgumentException($"genreName {genreName} not found.");
		}
		Write(asset, assetGenreEntity.BitMask, forceUpdate);
	}

	/// <inheritdocs />
	public void Write(IAsset asset, byte genreId, bool forceUpdate = false)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		Roblox.AssetGenre assetGenreEntity = Roblox.AssetGenre.Get(genreId);
		if (assetGenreEntity == null)
		{
			throw new ArgumentException($"genreId {genreId} not found.");
		}
		Write(asset, assetGenreEntity.BitMask, forceUpdate);
	}

	/// <inheritdocs />
	public void Write(IAsset asset, IEnumerable<AssetGenre> genres, bool forceUpdate = false)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (genres == null)
		{
			throw new ArgumentNullException("genres");
		}
		List<Roblox.AssetGenre> assetGenreEntities = new List<Roblox.AssetGenre>();
		foreach (AssetGenre genre in genres)
		{
			Roblox.AssetGenre assetGenreEntity = ConvertAssetGenreToAssetGenreEntity(genre);
			if (assetGenreEntity == null)
			{
				throw new ArgumentException($"genre id {genre} not found.");
			}
			assetGenreEntities.Add(assetGenreEntity);
		}
		ulong genreBitMask = Roblox.AssetGenre.CoalesceAssetGenres(assetGenreEntities);
		Write(asset, genreBitMask, forceUpdate);
	}

	private Roblox.AssetGenre ConvertAssetGenreToAssetGenreEntity(AssetGenre genre)
	{
		return genre switch
		{
			AssetGenre.All => Roblox.AssetGenre.GetAll(), 
			AssetGenre.Tutorial => Roblox.AssetGenre.GetBuilding(), 
			AssetGenre.Scary => Roblox.AssetGenre.GetHorror(), 
			AssetGenre.TownAndCity => Roblox.AssetGenre.GetTownAndCity(), 
			AssetGenre.War => Roblox.AssetGenre.GetMilitary(), 
			AssetGenre.Funny => Roblox.AssetGenre.GetComedy(), 
			AssetGenre.Fantasy => Roblox.AssetGenre.GetMedieval(), 
			AssetGenre.Adventure => Roblox.AssetGenre.GetAdventure(), 
			AssetGenre.SciFi => Roblox.AssetGenre.GetSciFi(), 
			AssetGenre.Pirate => Roblox.AssetGenre.GetNaval(), 
			AssetGenre.FPS => Roblox.AssetGenre.GetFPS(), 
			AssetGenre.RPG => Roblox.AssetGenre.GetRPG(), 
			AssetGenre.Sports => Roblox.AssetGenre.GetSports(), 
			AssetGenre.Ninja => Roblox.AssetGenre.GetFighting(), 
			AssetGenre.WildWest => Roblox.AssetGenre.GetWestern(), 
			_ => throw new ArgumentException($"Can't convert to Roblox.AssetGenre: {genre}"), 
		};
	}

	private void Write(IAsset asset, ulong genreBitMask, bool forceUpdate = false)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		asset.UpdateGenres(genreBitMask, forceUpdate);
	}
}
