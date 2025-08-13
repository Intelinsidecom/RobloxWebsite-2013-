using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetCategory : IRobloxEntity<byte, AssetCategoryDAL>, ICacheableObject<byte>, ICacheableObject
{
	private AssetCategoryDAL _EntityDAL;

	public const string AllCategoriesName = "All";

	public static readonly byte AllTShirtCategoriesID;

	public static readonly byte AllGearCategories;

	public static string[] GearNames;

	public static string[] FriendlyGearNames;

	public const byte AllCategories = 0;

	public const int GearCategoriesCount = 10;

	public const byte GearAll = 0;

	public const byte GearMelee = 1;

	public const byte GearRanged = 2;

	public const byte GearExplosive = 3;

	public const byte GearPowerUps = 4;

	public const byte GearNavigation = 5;

	public const byte GearMusical = 6;

	public const byte GearSocial = 7;

	public const byte GearBuilding = 8;

	public const byte GearPersonalTransport = 9;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public int AssetTypeID => _EntityDAL.AssetTypeID;

	public byte BitOrdinal
	{
		get
		{
			return _EntityDAL.BitOrdinal;
		}
		set
		{
			_EntityDAL.BitOrdinal = value;
			_EntityDAL.BitMask = (long)Math.Pow(2.0, value - 1);
		}
	}

	public ulong BitMask => (ulong)_EntityDAL.BitMask;

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

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

	public static string GetFriendlyGearName(byte gearCategory)
	{
		if (gearCategory < 0 || gearCategory > FriendlyGearNames.Length)
		{
			return "";
		}
		return FriendlyGearNames[gearCategory];
	}

	public static string GetGearName(byte gearCategory)
	{
		if (gearCategory < 0 || gearCategory > GearNames.Length)
		{
			return "";
		}
		return GearNames[gearCategory];
	}

	static AssetCategory()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetCategory", isNullCacheable: true);
		AllTShirtCategoriesID = AssetCategoryDAL.Get(AssetType.TeeShirtID, "All").ID;
		AllGearCategories = AssetCategoryDAL.Get(AssetType.GearID, "All").ID;
		_InitializeGearNames();
	}

	public AssetCategory()
	{
		_EntityDAL = new AssetCategoryDAL();
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

	private static AssetCategory DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, AssetCategoryDAL, AssetCategory>(() => AssetCategoryDAL.Get(id), id);
	}

	private static AssetCategory DoGet(int assetTypeId, byte bitOrdinal)
	{
		return EntityHelper.DoGetByLookup<byte, AssetCategoryDAL, AssetCategory>(() => AssetCategoryDAL.Get(assetTypeId, bitOrdinal), $"AssetTypeID:{assetTypeId}_BitOrdinal:{bitOrdinal}");
	}

	private static AssetCategory DoGet(int assetTypeId, string name)
	{
		return EntityHelper.DoGetByLookup<byte, AssetCategoryDAL, AssetCategory>(() => AssetCategoryDAL.Get(assetTypeId, name), $"AssetTypeID:{assetTypeId}_Name:{name}");
	}

	public static AssetCategory Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static AssetCategory Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AssetCategory Get(int assetTypeId, byte bitOrdinal)
	{
		return EntityHelper.GetEntityByLookupOld<byte, AssetCategory>(EntityCacheInfo, $"AssetTypeID:{assetTypeId}_BitOrdinal:{bitOrdinal}", () => DoGet(assetTypeId, bitOrdinal));
	}

	public static AssetCategory Get(int assetTypeId, string name)
	{
		return EntityHelper.GetEntityByLookupOld<byte, AssetCategory>(EntityCacheInfo, $"AssetTypeID:{assetTypeId}_Name:{name}", () => DoGet(assetTypeId, name));
	}

	public static ICollection<AssetCategory> GetAssetCategoriesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAssetCategoriesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => AssetCategoryDAL.GetAssetCategoryIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfAssetCategories()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfAssetCategories", AssetCategoryDAL.GetTotalNumberOfAssetCategories);
	}

	public static ulong CoalesceAssetCategories(ICollection<AssetCategory> categories)
	{
		ulong returnValue = 0uL;
		foreach (AssetCategory cat in categories)
		{
			returnValue |= cat.BitMask;
		}
		return returnValue;
	}

	public static IEnumerable<AssetCategory> ConvertBitMaskToCategories(int assetTypeId, ulong bitMask)
	{
		foreach (byte ordinal in Converters.DistillOrdinalsFromBitMask(bitMask))
		{
			yield return Get(assetTypeId, ordinal);
		}
	}

	private static void _InitializeGearNames()
	{
		GearNames = new string[10];
		GearNames[0] = "All";
		GearNames[1] = "Melee";
		GearNames[2] = "Ranged";
		GearNames[3] = "Explosive";
		GearNames[4] = "PowerUps";
		GearNames[5] = "Navigation";
		GearNames[6] = "Music";
		GearNames[7] = "Social";
		GearNames[8] = "Building";
		GearNames[9] = "PersonalTransport";
		FriendlyGearNames = new string[10];
		FriendlyGearNames[0] = "All";
		FriendlyGearNames[1] = "Melee";
		FriendlyGearNames[2] = "Ranged";
		FriendlyGearNames[3] = "Explosive";
		FriendlyGearNames[4] = "Power Up";
		FriendlyGearNames[5] = "Navigation";
		FriendlyGearNames[6] = "Musical";
		FriendlyGearNames[7] = "Social";
		FriendlyGearNames[8] = "Building";
		FriendlyGearNames[9] = "Transport";
	}

	public void Construct(AssetCategoryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AssetTypeID:{AssetTypeID}_BitOrdinal:{BitOrdinal}";
			yield return $"AssetTypeID:{AssetTypeID}_Name:{Name}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
