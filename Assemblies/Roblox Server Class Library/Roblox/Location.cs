using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

internal class Location : IRobloxEntity<short, LocationDAL>, ICacheableObject<short>, ICacheableObject
{
	private LocationDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Location).ToString(), isNullCacheable: true);

	public short ID => _EntityDAL.ID;

	internal byte LocationTypeID
	{
		get
		{
			return _EntityDAL.LocationTypeID;
		}
		set
		{
			_EntityDAL.LocationTypeID = value;
		}
	}

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

	public Location()
	{
		_EntityDAL = new LocationDAL();
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

	internal static Location Get(short id)
	{
		return EntityHelper.GetEntity<short, LocationDAL, Location>(EntityCacheInfo, id, () => LocationDAL.Get(id));
	}

	internal static ICollection<Location> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.MultiGetEntity<short, LocationDAL, Location>(ids, EntityCacheInfo, LocationDAL.MultiGet);
	}

	internal static Location GetByLocationTypeIDAndValue(byte locationTypeID, string value)
	{
		return EntityHelper.GetEntityByLookup<short, LocationDAL, Location>(EntityCacheInfo, $"LocationTypeID:{locationTypeID}_Value:{value}", () => LocationDAL.GetLocationByLocationTypeIDAndValue(locationTypeID, value));
	}

	public void Construct(LocationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"LocationTypeID:{LocationTypeID}_Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
