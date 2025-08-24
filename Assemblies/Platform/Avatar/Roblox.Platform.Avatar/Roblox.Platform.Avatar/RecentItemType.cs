using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Avatar;

internal class RecentItemType : IRobloxEntity<byte, RecentItemTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private RecentItemTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(RecentItemType).ToString(), isNullCacheable: true);

	public static RecentItemType Asset => GetByValue("Asset");

	public static RecentItemType Outfit => GetByValue("Outfit");

	public byte ID => _EntityDAL.ID;

	internal string Value
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

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public RecentItemType()
	{
		_EntityDAL = new RecentItemTypeDAL();
	}

	public RecentItemType(RecentItemTypeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static RecentItemType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, RecentItemTypeDAL, RecentItemType>(EntityCacheInfo, id, () => RecentItemTypeDAL.Get(id));
	}

	private static ICollection<RecentItemType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, RecentItemTypeDAL, RecentItemType>(ids, EntityCacheInfo, RecentItemTypeDAL.MultiGet);
	}

	public static RecentItemType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RecentItemTypeDAL, RecentItemType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => RecentItemTypeDAL.GetRecentItemTypeByValue(value));
	}

	public void Construct(RecentItemTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByValue(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByValue(string value)
	{
		return $"Value:{value}";
	}
}
