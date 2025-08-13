using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

internal class LocationType : IRobloxEntity<byte, LocationTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private LocationTypeDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(LocationType).ToString(), isNullCacheable: true);

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public LocationType()
	{
		_EntityDAL = new LocationTypeDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static LocationType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, LocationTypeDAL, LocationType>(EntityCacheInfo, id, () => LocationTypeDAL.Get(id));
	}

	internal static ICollection<LocationType> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.MultiGetEntity<byte, LocationTypeDAL, LocationType>(ids, EntityCacheInfo, LocationTypeDAL.MultiGet);
	}

	internal static LocationType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, LocationTypeDAL, LocationType>(EntityCacheInfo, $"Value:{value}", () => LocationTypeDAL.GetLocationTypeByValue(value));
	}

	public void Construct(LocationTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
