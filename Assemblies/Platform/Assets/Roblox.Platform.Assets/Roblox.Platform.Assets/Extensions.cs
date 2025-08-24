using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Agents;
using Roblox.Platform.Assets.Entities;
using Roblox.Platform.Membership;
using Roblox.Properties;

namespace Roblox.Platform.Assets;

public static class Extensions
{
	/// <summary>
	/// This checks if assetType should be visible to the public 
	/// </summary>
	/// <param name="assetType">The asset type</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.Assets.AssetType" /> provided is open to public</returns>
	public static bool IsPublicAssetType(this AssetType assetType)
	{
		return PublicAssetTypes.GetPublicAssetTypes().Contains(assetType);
	}

	/// <summary>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetType" /> object based off AssetType ID provided 
	/// This method returns null if the AssetType is not found
	/// </summary>
	/// <param name="id">The asset type Id</param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetType" /> or null
	/// </returns>
	public static AssetType? GetAssetType(int id, IAssetTypeFactory assetTypeFactory = null)
	{
		return (assetTypeFactory ?? AssetTypeFactory.Singleton).GetAssetType(id);
	}

	/// <summary>
	/// Return assetType associated ID from DB 
	/// </summary>
	/// <param name="assetType">An <see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>An AssetType Id</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if assetType could not be found.</exception>
	public static int ToId(this AssetType assetType, IAssetTypeFactory assetTypeFactory = null)
	{
		return (assetTypeFactory ?? AssetTypeFactory.Singleton).ToId(assetType);
	}

	/// <summary>
	/// Return the asset type value given the legacy asset type value
	/// </summary>
	/// <param name="assetType">A string representing the legacy asset type value</param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>The asset type</returns>
	public static AssetType? ToAssetType(this string assetTypeValue, IAssetTypeFactory assetTypeFactory = null)
	{
		return (assetTypeFactory ?? AssetTypeFactory.Singleton).GetAssetTypeByValue(assetTypeValue);
	}

	/// <summary>
	/// Return the legacy asset type value given the asset type
	/// </summary>
	/// <param name="assetType">An <see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>The legacy asset type value as string</returns>
	public static string ToLegacyValue(this AssetType assetType, IAssetTypeFactory assetTypeFactory = null)
	{
		return (assetTypeFactory ?? AssetTypeFactory.Singleton).ToLegacyValue(assetType);
	}

	/// <summary>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetCategory" /> based off AssetType provided 
	/// </summary>
	/// <param name="assetType">An <see cref="T:Roblox.Platform.Assets.AssetType" /></param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Assets.AssetCategory" /> associated with provided <see cref="T:Roblox.Platform.Assets.AssetType" />
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformDataIntegrityException">Thrown if assetType could not be found.</exception>
	public static AssetCategory ToAssetCategory(this AssetType assetType, IAssetTypeFactory assetTypeFactory = null)
	{
		return (assetTypeFactory ?? AssetTypeFactory.Singleton).GetAssetTypeCategory(assetType);
	}

	/// <summary>
	/// This method return an <see cref="T:Roblox.Platform.Assets.AssetGenre" /> based off assetGenreId provided
	/// </summary>
	/// <param name="assetGenreId">Asset genre Id</param>
	/// <returns>An <see cref="T:Roblox.Platform.Assets.AssetGenre" /> associated with the asset genre Id provided</returns>
	public static AssetGenre ToAssetGenreEnumValue(byte assetGenreId)
	{
		Roblox.AssetGenre serverClassLibraryAssetGenre = Roblox.AssetGenre.Get(assetGenreId);
		if (serverClassLibraryAssetGenre == null)
		{
			return AssetGenre.All;
		}
		return serverClassLibraryAssetGenre.Name switch
		{
			"All" => AssetGenre.All, 
			"Tutorial" => AssetGenre.Tutorial, 
			"Scary" => AssetGenre.Scary, 
			"Town and City" => AssetGenre.TownAndCity, 
			"War" => AssetGenre.War, 
			"Funny" => AssetGenre.Funny, 
			"Fantasy" => AssetGenre.Fantasy, 
			"Adventure" => AssetGenre.Adventure, 
			"Sci-Fi" => AssetGenre.SciFi, 
			"Pirate" => AssetGenre.Pirate, 
			"FPS" => AssetGenre.FPS, 
			"RPG" => AssetGenre.RPG, 
			"Sports" => AssetGenre.Sports, 
			"Ninja" => AssetGenre.Ninja, 
			"Wild West" => AssetGenre.WildWest, 
			_ => AssetGenre.All, 
		};
	}

	/// <summary>
	/// This returns the display name for a given <see cref="T:Roblox.Platform.Assets.AssetGenre" />
	/// </summary>
	/// <param name="assetGenre">An <see cref="T:Roblox.Platform.Assets.AssetGenre" /></param>
	/// <returns>The display name text for the provided <see cref="T:Roblox.Platform.Assets.AssetGenre" /></returns>
	public static string GetDisplayName(this AssetGenre assetGenre)
	{
		return assetGenre switch
		{
			AssetGenre.TownAndCity => Roblox.AssetGenre.GetTownAndCity().DisplayName, 
			AssetGenre.SciFi => Roblox.AssetGenre.GetSciFi().DisplayName, 
			AssetGenre.WildWest => Roblox.AssetGenre.GetWestern().DisplayName, 
			AssetGenre.Funny => Roblox.AssetGenre.GetComedy().DisplayName, 
			AssetGenre.Fantasy => Roblox.AssetGenre.GetMedieval().DisplayName, 
			AssetGenre.Ninja => Roblox.AssetGenre.GetFighting().DisplayName, 
			AssetGenre.Scary => Roblox.AssetGenre.GetHorror().DisplayName, 
			AssetGenre.Pirate => Roblox.AssetGenre.GetNaval().DisplayName, 
			AssetGenre.War => Roblox.AssetGenre.GetMilitary().DisplayName, 
			AssetGenre.Tutorial => Roblox.AssetGenre.GetBuilding().DisplayName, 
			_ => assetGenre.ToString(), 
		};
	}

	/// <summary>
	/// This returns the asset genre Id for a given <see cref="T:Roblox.Platform.Assets.AssetGenre" />
	/// </summary>
	/// <param name="assetGenre">An <see cref="T:Roblox.Platform.Assets.AssetGenre" /></param>
	/// <returns>The id of the <see cref="T:Roblox.Platform.Assets.AssetGenre" /> provided</returns>
	public static byte GetId(this AssetGenre assetGenre)
	{
		return assetGenre switch
		{
			AssetGenre.All => Roblox.AssetGenre.AllID, 
			AssetGenre.Tutorial => Roblox.AssetGenre.BuildingID, 
			AssetGenre.Scary => Roblox.AssetGenre.HorrorID, 
			AssetGenre.TownAndCity => Roblox.AssetGenre.TownAndCityID, 
			AssetGenre.War => Roblox.AssetGenre.MilitaryID, 
			AssetGenre.Funny => Roblox.AssetGenre.ComedyID, 
			AssetGenre.Fantasy => Roblox.AssetGenre.MedievalID, 
			AssetGenre.Adventure => Roblox.AssetGenre.AdventureID, 
			AssetGenre.SciFi => Roblox.AssetGenre.SciFiID, 
			AssetGenre.Pirate => Roblox.AssetGenre.NavalID, 
			AssetGenre.FPS => Roblox.AssetGenre.FPSID, 
			AssetGenre.RPG => Roblox.AssetGenre.RPGID, 
			AssetGenre.Sports => Roblox.AssetGenre.SportsID, 
			AssetGenre.Ninja => Roblox.AssetGenre.FightingID, 
			AssetGenre.WildWest => Roblox.AssetGenre.WesternID, 
			_ => Roblox.AssetGenre.AllID, 
		};
	}

	public static void VerifyIsNotNull(this IAlias alias)
	{
		if (alias == null)
		{
			throw new UnknownAliasException();
		}
	}

	/// <summary>
	/// This method returns an <see cref="T:Roblox.Platform.Assets.AssetType" /> object based off Asset provided 
	/// This method returns null if the AssetType is not found
	/// </summary>
	/// <param name="asset">An <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <param name="assetTypeFactory">A <see cref="T:Roblox.Platform.Assets.IAssetTypeFactory" />, if none is passed in, the default singleton is used</param>
	/// <returns>The <see cref="T:Roblox.Platform.Assets.AssetType" /> for the provided <see cref="T:Roblox.Platform.Assets.IAsset" /> or null</returns>
	public static AssetType? GetAssetType(this IAsset asset, IAssetTypeFactory assetTypeFactory)
	{
		return assetTypeFactory.GetAssetType(asset.TypeId);
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.GetCurrentAssetVersion() instead")]
	public static IAssetVersion GetCurrentVersion(this IAsset asset)
	{
		return AssetVersionFactory.GetSingleton().GetCurrentAssetVersion(asset);
	}

	public static IEnumerable<byte> GetGenreIDs(this IAsset asset)
	{
		return Roblox.Asset.Get(asset.Id).Genres.Select((Roblox.AssetGenre g) => g.ID);
	}

	public static IEnumerable<byte> GetCategoryIds(this IAsset asset)
	{
		return Roblox.Asset.Get(asset.Id).Categories.Select((Roblox.AssetCategory c) => c.ID);
	}

	public static byte GetMinMembershiptType(this IAsset asset)
	{
		return (byte)(Roblox.AssetOption.GetOrCreate(asset.Id)?.MinMembershipType ?? Roblox.AssetOption.MembershipType.None);
	}

	[Obsolete("Use AssetDomainFactories.AssetVersionFactory.GetVersions() instead")]
	public static IEnumerable<IAssetVersion> GetVersions(this IAsset asset, long offset, long count)
	{
		return AssetVersionFactory.GetSingleton().GetAssetPublishedVersionsPaged(asset, offset, count);
	}

	public static bool IsCopyAllowed(this IAsset asset)
	{
		asset.VerifyIsNotNull();
		return AssetProtectionOption.GetByAssetId(asset.Id)?.IsCopyAllowed ?? false;
	}

	public static bool IsUpdateAllowed(this IAsset asset)
	{
		asset.VerifyIsNotNull();
		return AssetProtectionOption.GetByAssetId(asset.Id)?.IsUpdateAllowed ?? false;
	}

	public static bool IsIOSOnly(this IAsset asset)
	{
		string itemListString = Settings.Default.IOSCatalogItemsCSV;
		if (string.IsNullOrEmpty(itemListString))
		{
			return false;
		}
		return (from id in itemListString.Split(',')
			where !string.IsNullOrWhiteSpace(id)
			select id).Select(long.Parse).Contains(asset.Id);
	}

	public static void SetAssetProtectionOptions(this IAsset asset, bool isCopyAllowed, bool isUpdateAllowed)
	{
		asset.VerifyIsNotNull();
		AssetProtectionOption orCreate = AssetProtectionOption.GetOrCreate(asset.Id);
		orCreate.IsCopyAllowed = isCopyAllowed;
		orCreate.IsUpdateAllowed = isUpdateAllowed;
		orCreate.Save();
	}

	public static void VerifyIsNotNull(this IAsset asset, long? id = null)
	{
		if (asset != null)
		{
			return;
		}
		if (id.HasValue)
		{
			throw new UnknownAssetException(id.Value);
		}
		throw new UnknownAssetException();
	}

	public static void VerifyCreatingUniverseId(this IAsset asset, long? creatingUniverseId)
	{
		asset.VerifyIsNotNull();
		IAssetVersion currentVersion = asset.GetCurrentVersion();
		if (currentVersion != null && (currentVersion.CreatingUniverseId.HasValue || creatingUniverseId.HasValue))
		{
			if (!creatingUniverseId.HasValue)
			{
				throw new InvalidCreatingUniverseException("CreatingUniverseId cannot be null");
			}
			if (currentVersion.CreatingUniverseId != creatingUniverseId)
			{
				throw new InvalidCreatingUniverseException("Asset " + asset.Id + " cannot be updated by universe " + creatingUniverseId);
			}
		}
	}

	public static List<AssetGenre> GetAssetGenres(this IAsset asset)
	{
		IEnumerable<byte> genreIDs = asset.GetGenreIDs();
		List<AssetGenre> assetGenres = new List<AssetGenre>();
		foreach (byte assetGenreId in genreIDs)
		{
			assetGenres.Add(ToAssetGenreEnumValue(assetGenreId));
		}
		if (assetGenres.Count == 0)
		{
			assetGenres.Add(AssetGenre.All);
		}
		return assetGenres;
	}

	/// <summary>
	/// Returns AssetHashID
	/// </summary>
	/// <param name="asset">takes an <see cref="T:Roblox.Platform.Assets.IAsset" /></param>
	/// <returns>AssetHashID</returns>
	public static long GetAssetHashId(this IAsset asset)
	{
		return Roblox.Asset.Get(asset.Id).AssetHashID;
	}

	public static string GetAssetGenreDisplayName(this AssetGenre assetGenre)
	{
		return assetGenre.GetDisplayName();
	}

	public static IAssetVersion CreateNewVersion(this IAssetVersion assetVersion, IRawContentFactory rawContentFactory, CreatorType creatorType, int creatorTargetId, string rawContentMd5Hash, long? creatingUniverseId = null, CreationContextType creationContext = CreationContextType.NonGameCreation)
	{
		assetVersion.VerifyIsNotNull();
		IAsset asset = assetVersion.GetAsset();
		IRawContent rawContent = rawContentFactory.GetOrCreate(asset.TypeId, creatorType, creatorTargetId, rawContentMd5Hash);
		return assetVersion.CreateNewVersion(creatorType, creatorTargetId, rawContent, creatingUniverseId, creationContext);
	}

	public static IAssetVersion CreateNewVersion(this IAssetVersion assetVersion, CreatorType creatorType, int creatorTargetId, IRawContent rawContent, long? creatingUniverseId = null, CreationContextType creationContext = CreationContextType.NonGameCreation)
	{
		assetVersion.VerifyIsNotNull();
		IAsset asset = assetVersion.GetAsset();
		return AssetVersionFactory.Singleton.Create(asset, creatorType, creatorTargetId, rawContent, assetVersion, creatingUniverseId, creationContext);
	}

	public static void VerifyIsNotNull(this IAssetVersion assetVersion, long? id = null)
	{
		if (assetVersion != null)
		{
			return;
		}
		if (id.HasValue)
		{
			throw new UnknownAssetVersionException(id.Value);
		}
		throw new UnknownAssetVersionException();
	}

	/// <summary>
	/// Gets the name of a creator.
	/// </summary>
	/// <param name="creationScope">The <see cref="T:Roblox.Platform.Assets.ICreationScope" /> containing information about the creator.</param>
	/// <param name="userFactory"><see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <returns>
	/// The name of the creator.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if creationScope is null.</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if creationScope contains an invalid target ID.</exception>
	/// <exception cref="T:System.NotImplementedException">Thrown if creationScope contains an unsupported <see cref="T:Roblox.Platform.Assets.CreatorType" />.</exception>
	public static string GetCreatorName(this ICreationScope creationScope, IUserFactory userFactory)
	{
		return CreationScopeFactory.GetCreatorName(creationScope, userFactory);
	}

	public static IEnumerable<IAsset> GetCreatedAssets(this ICreationScope creationScope, long? creatingUniverseId, long offset, long count)
	{
		CreationContext creationContextEntity = CreationContext.GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId((byte)creationScope.CreationContextType, (byte)creationScope.CreatorType, creationScope.CreatorTargetId, creationScope.AssetTypeId, creatingUniverseId);
		if (creationContextEntity == null)
		{
			yield break;
		}
		IEnumerable<IAsset> createdAssets = (from ce in Creation.GetCreationsByCreationContextIdPaged(creationContextEntity.ID, offset, count)
			select ce.AssetId).Select(AssetFactory.Singleton.GetAsset);
		foreach (IAsset item in createdAssets)
		{
			yield return item;
		}
	}

	public static IEnumerable<long?> GetCreatingUniverses(this ICreationScope creationScope, long offset, long count)
	{
		return from cce in CreationContext.GetCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeIdPaged((byte)creationScope.CreationContextType, (byte)creationScope.CreatorType, creationScope.CreatorTargetId, creationScope.AssetTypeId, offset, count)
			select cce.UniverseId;
	}

	public static long GetTotalNumberOfCreatedAssets(this ICreationScope creationScope, long? creatingUniverseId)
	{
		CreationContext creationContextEntity = CreationContext.GetByContextTypeIdCreatorTypeIdCreatorTargetIdAssetTypeIdAndUniverseId((byte)creationScope.CreationContextType, (byte)creationScope.CreatorType, creationScope.CreatorTargetId, creationScope.AssetTypeId, creatingUniverseId);
		if (creationContextEntity == null)
		{
			return 0L;
		}
		return Creation.GetTotalNumberOfCreationsByCreationContextId(creationContextEntity.ID);
	}

	public static long GetTotalNumberOfCreatingUniverses(this ICreationScope creationScope)
	{
		return CreationContext.GetTotalNumberOfCreationContextsByContextTypeIdCreatorTypeIdCreatorTargetIdAndAssetTypeId((byte)creationScope.CreationContextType, (byte)creationScope.CreatorType, creationScope.CreatorTargetId, creationScope.AssetTypeId);
	}

	public static void VerifyIsNotNull(this IRawContent rawContent, long? id = null)
	{
		if (rawContent != null)
		{
			return;
		}
		if (id.HasValue)
		{
			throw new UnknownRawContentException(id.Value);
		}
		throw new UnknownRawContentException();
	}

	public static AgentType ToAgentType(this CreatorType creatorType)
	{
		return creatorType switch
		{
			CreatorType.Group => AgentType.Group, 
			CreatorType.User => AgentType.User, 
			_ => throw new NotSupportedException("Creator Type: " + creatorType), 
		};
	}

	public static CreatorType ToCreatorType(this AgentType agentType)
	{
		return agentType switch
		{
			AgentType.Group => CreatorType.Group, 
			AgentType.User => CreatorType.User, 
			_ => throw new NotSupportedException("Agent Type: " + agentType), 
		};
	}

	public static IReadOnlyCollection<long> GetConstituentAssetIds(this IAsset asset)
	{
		return Roblox.Asset.Get(asset.Id).GetConstituentAssetIds();
	}

	/// <summary>
	/// If an asset is a package, then return a list containing the assetId plus the assetIds of all package items within it.
	/// If it's a normal assetType, just return a list containing the assetId.
	/// </summary>
	public static IReadOnlyCollection<long> GetConstituentAssetIds(this Roblox.Asset asset)
	{
		List<long> assetIds = new List<long>();
		assetIds.Add(asset.ID);
		if (asset.IsPackageAssetType())
		{
			foreach (Roblox.AccoutrementPackageItem item in Roblox.AccoutrementPackageItem.GetAccoutrementPackageItems(asset.ID))
			{
				assetIds.Add(item.AssetID);
			}
		}
		return assetIds;
	}
}
