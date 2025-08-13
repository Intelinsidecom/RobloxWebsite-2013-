using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

public class PlaceGamePass : IRobloxEntity<long, PlaceGamePassDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private PlaceGamePassDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.DataAccess.PlaceGamePass", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PassID
	{
		get
		{
			return _EntityDAL.PassID;
		}
		set
		{
			_EntityDAL.PassID = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public long PlaceID
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

	public long ImageID
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PlaceGamePass()
	{
		_EntityDAL = new PlaceGamePassDAL();
	}

	public PlaceGamePass(PlaceGamePassDAL entityDAL)
	{
		_EntityDAL = entityDAL;
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

	public static PlaceGamePass CreateNew(long passid, long placeid, long imageid)
	{
		PlaceGamePass placeGamePass = new PlaceGamePass();
		placeGamePass.PassID = passid;
		placeGamePass.PlaceID = placeid;
		placeGamePass.ImageID = imageid;
		placeGamePass.Save();
		return placeGamePass;
	}

	public static PlaceGamePass Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceGamePassDAL, PlaceGamePass>(EntityCacheInfo, id, () => PlaceGamePassDAL.Get(id));
	}

	public static PlaceGamePass Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<PlaceGamePass> GetPlaceGamePassesByPassID(long passId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPlaceGamePassIDsByPassID_PassID:{passId}_StartRowIndex:{startRowIndex}_MaxRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PassID:{passId}"), collectionId, () => PlaceGamePassDAL.GetPlaceGamePassIDsByPassID(passId, startRowIndex, maximumRows), Get);
	}

	public static ICollection<PlaceGamePass> GetPlaceGamePassesByPlaceID(long placeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPlaceGamePassIDsByPlaceID_PlaceID:{placeId}_StartRowIndex:{startRowIndex}_MaxRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), collectionId, () => PlaceGamePassDAL.GetPlaceGamePassIDsByPlaceID(placeId, startRowIndex, maximumRows), Get);
	}

	public static int GetTotalNumberOfPlaceGamePassesByPlaceID(long placeId)
	{
		string countId = $"GetTotalNumberOfPlaceGamePassesByPlaceID:{placeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), countId, () => PlaceGamePassDAL.GetTotalNumberOfPlaceGamePassesByPlaceID(placeId));
	}

	public static int GetTotalNumberOfPlaceGamePassesByPassID(long passId)
	{
		string countId = $"GetTotalNumberOfPlaceGamePassesByPassID:{passId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PassID:{passId}"), countId, () => PlaceGamePassDAL.GetTotalNumberOfPlaceGamePassesByPassID(passId));
	}

	public void Construct(PlaceGamePassDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PassID:{PassID}");
		yield return new StateToken($"PlaceID:{PlaceID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
