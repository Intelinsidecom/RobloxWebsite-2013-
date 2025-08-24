using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Studio.Entities;

/// <summary>
/// Entity which is indicate if CloudEdit is enabled for place or not
/// </summary>
internal class UniverseCloudEditStatus : IRobloxEntity<long, UniverseCloudEditStatusDAL>, ICacheableObject<long>, ICacheableObject
{
	private UniverseCloudEditStatusDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniverseCloudEditStatus).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	internal bool IsEnabled
	{
		get
		{
			return _EntityDAL.IsEnabled;
		}
		set
		{
			_EntityDAL.IsEnabled = value;
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

	public UniverseCloudEditStatus()
	{
		_EntityDAL = new UniverseCloudEditStatusDAL();
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

	internal static UniverseCloudEditStatus Get(long id)
	{
		return EntityHelper.GetEntity<long, UniverseCloudEditStatusDAL, UniverseCloudEditStatus>(EntityCacheInfo, id, () => UniverseCloudEditStatusDAL.Get(id));
	}

	private static ICollection<UniverseCloudEditStatus> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UniverseCloudEditStatusDAL, UniverseCloudEditStatus>(ids, EntityCacheInfo, UniverseCloudEditStatusDAL.MultiGet);
	}

	public static UniverseCloudEditStatus GetByUniverseID(long universeID)
	{
		return EntityHelper.GetEntityByLookup<long, UniverseCloudEditStatusDAL, UniverseCloudEditStatus>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeID), () => UniverseCloudEditStatusDAL.GetUniverseCloudEditStatusByUniverseID(universeID));
	}

	public static UniverseCloudEditStatus GetOrCreate(long universeID)
	{
		return EntityHelper.GetOrCreateEntity<long, UniverseCloudEditStatus>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeID), () => DoGetOrCreate(universeID));
	}

	private static UniverseCloudEditStatus DoGetOrCreate(long universeID)
	{
		return EntityHelper.DoGetOrCreate<long, UniverseCloudEditStatusDAL, UniverseCloudEditStatus>(() => UniverseCloudEditStatusDAL.GetOrCreateUniverseCloudEditStatus(universeID));
	}

	public void Construct(UniverseCloudEditStatusDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUniverseID(UniverseID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByUniverseID(long universeID)
	{
		return $"UniverseID:{universeID}";
	}
}
