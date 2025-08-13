using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetGenre : IRobloxEntity<byte, AssetGenreDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AssetGenreDAL _EntityDAL;

	private static readonly ICollection<AssetGenre> _SortedGenres;

	public const string AllName = "All";

	public static readonly byte AllID;

	public static readonly byte AllOrdinal;

	public const string BuildingName = "Tutorial";

	public static readonly byte BuildingID;

	public static readonly byte BuildingOrdinal;

	public const string HorrorName = "Scary";

	public static readonly byte HorrorID;

	public static readonly byte HorrorOrdinal;

	public const string TownAndCityName = "Town and City";

	public static readonly byte TownAndCityID;

	public static readonly byte TownAndCityOrdinal;

	public const string MilitaryName = "War";

	public static readonly byte MilitaryID;

	public static readonly byte MilitaryOrdinal;

	public const string ComedyName = "Funny";

	public static readonly byte ComedyID;

	public static readonly byte ComedyOrdinal;

	public const string MedievalName = "Fantasy";

	public static readonly byte MedievalID;

	public static readonly byte MedievalOrdinal;

	public const string AdventureName = "Adventure";

	public static readonly byte AdventureID;

	public static readonly byte AdventureOrdinal;

	public const string SciFiName = "Sci-Fi";

	public static readonly byte SciFiID;

	public static readonly byte SciFiOrdinal;

	public const string NavalName = "Pirate";

	public static readonly byte NavalID;

	public static readonly byte NavalOrdinal;

	public const string FPSName = "FPS";

	public static readonly byte FPSID;

	public static readonly byte FPSOrdinal;

	public const string RPGName = "RPG";

	public static readonly byte RPGID;

	public static readonly byte RPGOrdinal;

	public const string SportsName = "Sports";

	public static readonly byte SportsID;

	public static readonly byte SportsOrdinal;

	public const string FightingName = "Ninja";

	public static readonly byte FightingID;

	public static readonly byte FightingOrdinal;

	public const string WesternName = "Wild West";

	public static readonly byte WesternID;

	public static readonly byte WesternOrdinal;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public byte BitOrdinal
	{
		get
		{
			return _EntityDAL.BitOrdinal;
		}
		set
		{
			_EntityDAL.BitOrdinal = value;
			if (value > 0)
			{
				_EntityDAL.BitMask = 1L << value - 1;
			}
			else
			{
				_EntityDAL.BitMask = 0L;
			}
		}
	}

	public ulong BitMask => (ulong)_EntityDAL.BitMask;

	/// <summary>
	/// This is a lookup key only - use DisplayName for display purposes
	/// </summary>
	public string Name => _EntityDAL.Name;

	public string DisplayName => _EntityDAL.DisplayName;

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public string Abbreviation
	{
		get
		{
			return _EntityDAL.Abbreviation;
		}
		set
		{
			_EntityDAL.Abbreviation = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetGenre()
	{
		_EntityDAL = new AssetGenreDAL();
	}

	static AssetGenre()
	{
		_SortedGenres = new List<AssetGenre>();
		AllID = 0;
		AllOrdinal = 0;
		BuildingID = 0;
		BuildingOrdinal = 0;
		HorrorID = 0;
		HorrorOrdinal = 0;
		TownAndCityID = 0;
		TownAndCityOrdinal = 0;
		MilitaryID = 0;
		MilitaryOrdinal = 0;
		ComedyID = 0;
		ComedyOrdinal = 0;
		MedievalID = 0;
		MedievalOrdinal = 0;
		AdventureID = 0;
		AdventureOrdinal = 0;
		SciFiID = 0;
		SciFiOrdinal = 0;
		NavalID = 0;
		NavalOrdinal = 0;
		FPSID = 0;
		FPSOrdinal = 0;
		RPGID = 0;
		RPGOrdinal = 0;
		SportsID = 0;
		SportsOrdinal = 0;
		FightingID = 0;
		FightingOrdinal = 0;
		WesternID = 0;
		WesternOrdinal = 0;
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetGenre", isNullCacheable: true);
		AssetGenre all = GetByName("All");
		AllID = all.ID;
		AllOrdinal = all.BitOrdinal;
		_SortedGenres.Add(all);
		AssetGenre building = GetByName("Tutorial");
		BuildingID = building.ID;
		BuildingOrdinal = building.BitOrdinal;
		_SortedGenres.Add(building);
		AssetGenre horror = GetByName("Scary");
		HorrorID = horror.ID;
		HorrorOrdinal = horror.BitOrdinal;
		_SortedGenres.Add(horror);
		AssetGenre townAndCity = GetByName("Town and City");
		TownAndCityID = townAndCity.ID;
		TownAndCityOrdinal = townAndCity.BitOrdinal;
		_SortedGenres.Add(townAndCity);
		AssetGenre military = GetByName("War");
		MilitaryID = military.ID;
		MilitaryOrdinal = military.BitOrdinal;
		_SortedGenres.Add(military);
		AssetGenre comedy = GetByName("Funny");
		ComedyID = comedy.ID;
		ComedyOrdinal = comedy.BitOrdinal;
		_SortedGenres.Add(comedy);
		AssetGenre medieval = GetByName("Fantasy");
		MedievalID = medieval.ID;
		MedievalOrdinal = medieval.BitOrdinal;
		_SortedGenres.Add(medieval);
		AssetGenre adventure = GetByName("Adventure");
		AdventureID = adventure.ID;
		AdventureOrdinal = adventure.BitOrdinal;
		_SortedGenres.Add(adventure);
		AssetGenre sciFi = GetByName("Sci-Fi");
		SciFiID = sciFi.ID;
		SciFiOrdinal = sciFi.BitOrdinal;
		_SortedGenres.Add(sciFi);
		AssetGenre naval = GetByName("Pirate");
		NavalID = naval.ID;
		NavalOrdinal = naval.BitOrdinal;
		_SortedGenres.Add(naval);
		AssetGenre fps = GetByName("FPS");
		FPSID = fps.ID;
		FPSOrdinal = fps.BitOrdinal;
		_SortedGenres.Add(fps);
		AssetGenre rpg = GetByName("RPG");
		RPGID = rpg.ID;
		RPGOrdinal = rpg.BitOrdinal;
		_SortedGenres.Add(rpg);
		AssetGenre sports = GetByName("Sports");
		SportsID = sports.ID;
		SportsOrdinal = sports.BitOrdinal;
		_SortedGenres.Add(sports);
		AssetGenre fighting = GetByName("Ninja");
		FightingID = fighting.ID;
		FightingOrdinal = fighting.BitOrdinal;
		_SortedGenres.Add(fighting);
		AssetGenre western = GetByName("Wild West");
		WesternID = western.ID;
		WesternOrdinal = western.BitOrdinal;
		_SortedGenres.Add(western);
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static ulong CoalesceAssetGenres(ICollection<AssetGenre> genres)
	{
		ulong returnValue = 0uL;
		foreach (AssetGenre genre in genres)
		{
			returnValue |= genre.BitMask;
		}
		return returnValue;
	}

	public static IEnumerable<AssetGenre> ConvertBitMaskToGenres(ulong bitMask)
	{
		foreach (byte ordinal in Converters.DistillOrdinalsFromBitMask(bitMask))
		{
			yield return GetByBitOrdinal(ordinal);
		}
	}

	public static AssetGenre Get(byte id)
	{
		return EntityHelper.GetEntity<byte, AssetGenreDAL, AssetGenre>(EntityCacheInfo, id, () => AssetGenreDAL.Get(id));
	}

	public static AssetGenre Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AssetGenre GetByBitOrdinal(byte bitOrdinal)
	{
		return EntityHelper.GetEntityByLookup<byte, AssetGenreDAL, AssetGenre>(EntityCacheInfo, "BitOrdinal:" + bitOrdinal, () => AssetGenreDAL.GetByBitOrdinal(bitOrdinal));
	}

	public static AssetGenre GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<byte, AssetGenreDAL, AssetGenre>(EntityCacheInfo, "Name:" + name, () => AssetGenreDAL.GetByName(name));
	}

	public static ICollection<AssetGenre> GetAssetGenresSorted()
	{
		return _SortedGenres;
	}

	public static ICollection<AssetGenre> GetAssetGenresPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetGenresPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => AssetGenreDAL.GetAssetGenreIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAssetGenres()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfAssetGenres", AssetGenreDAL.GetTotalNumberOfAssetGenres);
	}

	public static string GetLSBGenreName(ulong bitMask)
	{
		byte ordinal = 0;
		if (bitMask != 0L)
		{
			for (byte i = 0; i < 64; i = (byte)(i + 1))
			{
				if ((bitMask & (ulong)(1L << (int)i)) != 0L)
				{
					ordinal = (byte)(i + 1);
					break;
				}
			}
		}
		AssetGenre assetGenre = GetByBitOrdinal(ordinal);
		if (assetGenre != null)
		{
			return assetGenre.Name;
		}
		return "All Genres";
	}

	public static AssetGenre MustGet(byte id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static AssetGenre GetAll()
	{
		return MustGet(AllID);
	}

	public static AssetGenre GetBuilding()
	{
		return MustGet(BuildingID);
	}

	public static AssetGenre GetHorror()
	{
		return MustGet(HorrorID);
	}

	public static AssetGenre GetTownAndCity()
	{
		return MustGet(TownAndCityID);
	}

	public static AssetGenre GetMilitary()
	{
		return MustGet(MilitaryID);
	}

	public static AssetGenre GetComedy()
	{
		return MustGet(ComedyID);
	}

	public static AssetGenre GetMedieval()
	{
		return MustGet(MedievalID);
	}

	public static AssetGenre GetAdventure()
	{
		return MustGet(AdventureID);
	}

	public static AssetGenre GetSciFi()
	{
		return MustGet(SciFiID);
	}

	public static AssetGenre GetNaval()
	{
		return MustGet(NavalID);
	}

	public static AssetGenre GetFPS()
	{
		return MustGet(FPSID);
	}

	public static AssetGenre GetRPG()
	{
		return MustGet(RPGID);
	}

	public static AssetGenre GetSports()
	{
		return MustGet(SportsID);
	}

	public static AssetGenre GetFighting()
	{
		return MustGet(FightingID);
	}

	public static AssetGenre GetWestern()
	{
		return MustGet(WesternID);
	}

	public string GetSEOURL()
	{
		AssetGenresInfo assetGenresInfo = null;
		try
		{
			assetGenresInfo = AssetGenresInfo.GetByAssetGenreID(ID);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
		if (assetGenresInfo != null)
		{
			string friendlyUrl = assetGenresInfo.FriendlyURL;
			if (!string.IsNullOrEmpty(friendlyUrl))
			{
				return friendlyUrl.Replace(" ", "-");
			}
		}
		return Name.Replace(" ", "-");
	}

	public void Construct(AssetGenreDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "BitOrdinal:" + BitOrdinal;
			yield return "Name:" + Name;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
