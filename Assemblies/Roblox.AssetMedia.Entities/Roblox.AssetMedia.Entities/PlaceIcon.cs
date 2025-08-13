using System;
using System.Collections.Generic;
using Roblox.AssetMedia.Entities.Properties;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.AssetMedia.Entities;

internal class PlaceIcon : IRobloxEntity<long, PlaceIconDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private PlaceIconDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PlaceIcon).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
		}
	}

	internal long ImageID
	{
		get
		{
			return _EntityDAL.ImageID;
		}
		set
		{
			_EntityDAL.ImageID = value;
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

	public PlaceIcon()
	{
		_EntityDAL = new PlaceIconDAL();
	}

	public PlaceIcon(PlaceIconDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		if (PlaceID % 100 < Settings.Default.UseRemoteCacheForPlaceIconPercentage)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (PlaceID % 100 < Settings.Default.UseRemoteCacheForPlaceIconPercentage)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
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
		else
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
	}

	internal static PlaceIcon Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceIconDAL, PlaceIcon>(EntityCacheInfo, id, () => PlaceIconDAL.Get(id));
	}

	internal static ICollection<PlaceIcon> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PlaceIconDAL, PlaceIcon>(ids, EntityCacheInfo, PlaceIconDAL.MultiGet);
	}

	public static PlaceIcon GetByPlaceID(long placeID)
	{
		if (placeID % 100 < Settings.Default.UseRemoteCacheForPlaceIconPercentage)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, PlaceIconDAL, PlaceIcon>(EntityCacheInfo, $"PlaceID:{placeID}", () => PlaceIconDAL.GetPlaceIconByPlaceID(placeID), Get);
		}
		return EntityHelper.GetEntityByLookup<long, PlaceIconDAL, PlaceIcon>(EntityCacheInfo, $"PlaceID:{placeID}", () => PlaceIconDAL.GetPlaceIconByPlaceID(placeID));
	}

	public void Construct(PlaceIconDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PlaceID:{PlaceID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
