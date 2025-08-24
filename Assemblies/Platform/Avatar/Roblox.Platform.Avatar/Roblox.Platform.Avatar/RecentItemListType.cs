using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Avatar;

internal class RecentItemListType : IRobloxEntity<byte, RecentItemListTypeDAL>, ICacheableObject<byte>, ICacheableObject, IRemoteCacheableObject
{
	private RecentItemListTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(RecentItemListType).ToString(), isNullCacheable: true);

	public static RecentItemListType Clothing => GetByValue("Clothing");

	public static RecentItemListType Accessories => GetByValue("Accessories");

	public static RecentItemListType AvatarAnimations => GetByValue("AvatarAnimations");

	public static RecentItemListType BodyParts => GetByValue("BodyParts");

	public static RecentItemListType Outfits => GetByValue("Outfits");

	public static RecentItemListType Gear => GetByValue("Gear");

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

	public RecentItemListType()
	{
		_EntityDAL = new RecentItemListTypeDAL();
	}

	public RecentItemListType(RecentItemListTypeDAL entityDAL)
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

	internal static RecentItemListType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, RecentItemListTypeDAL, RecentItemListType>(EntityCacheInfo, id, () => RecentItemListTypeDAL.Get(id));
	}

	private static ICollection<RecentItemListType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, RecentItemListTypeDAL, RecentItemListType>(ids, EntityCacheInfo, RecentItemListTypeDAL.MultiGet);
	}

	public static RecentItemListType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RecentItemListTypeDAL, RecentItemListType>(EntityCacheInfo, GetLookupCacheKeysByValue(value), () => RecentItemListTypeDAL.GetRecentItemListTypeByValue(value));
	}

	public void Construct(RecentItemListTypeDAL dal)
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
