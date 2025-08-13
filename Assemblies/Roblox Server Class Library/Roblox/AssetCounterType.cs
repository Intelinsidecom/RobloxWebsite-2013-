using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetCounterType : IRobloxEntity<byte, AssetCounterTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	public enum SegmentedTypes
	{
		TotalPlays,
		TotalPlayTime,
		ReturnRate
	}

	private AssetCounterTypeDAL _EntityDAL;

	public static readonly byte CommentsID;

	public const string CommentsValue = "Comments";

	public static readonly byte FavoritesID;

	public const string FavoritesValue = "Favorites";

	public static readonly byte NumberSoldByRobloxID;

	public const string NumberSoldByRobloxValue = "NumberSoldByRoblox";

	public static readonly byte GrossSalesRevenueRobuxID;

	public const string GrossSalesRevenueRobuxValue = "GrossSalesRevenueRobux";

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetCounterType()
	{
		_EntityDAL = new AssetCounterTypeDAL();
	}

	static AssetCounterType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AssetCounterType", isNullCacheable: true);
		CommentsID = Get("Comments").ID;
		FavoritesID = Get("Favorites").ID;
		NumberSoldByRobloxID = Get("NumberSoldByRoblox").ID;
		GrossSalesRevenueRobuxID = Get("GrossSalesRevenueRobux").ID;
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

	private static AssetCounterType CreateNew(string value)
	{
		AssetCounterType assetCounterType = new AssetCounterType();
		assetCounterType.Value = value;
		assetCounterType.Save();
		return assetCounterType;
	}

	private static AssetCounterType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, AssetCounterTypeDAL, AssetCounterType>(() => AssetCounterTypeDAL.Get(id), id);
	}

	private static AssetCounterType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, AssetCounterTypeDAL, AssetCounterType>(() => AssetCounterTypeDAL.Get(value), value);
	}

	public static AssetCounterType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static AssetCounterType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AssetCounterType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, AssetCounterType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static AssetCounterType GetSegmentedType(SegmentedTypes type, int segmentId)
	{
		string typeString = $"{type}_SegmentID:{segmentId}";
		return Get(typeString) ?? CreateNew(typeString);
	}

	public static AssetCounterType GetByPlatformType(SegmentedTypes type, byte platformTypeId)
	{
		string typeString = $"{type}_PlatformTypeID:{platformTypeId}";
		return Get(typeString) ?? CreateNew(typeString);
	}

	public void Construct(AssetCounterTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
