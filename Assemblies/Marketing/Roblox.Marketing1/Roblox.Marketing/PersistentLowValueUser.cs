using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class PersistentLowValueUser : IRobloxEntity<int, PersistentLowValueUserDAL>, ICacheableObject<int>, ICacheableObject
{
	private PersistentLowValueUserDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PersistentLowValueUser).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public PersistentLowValueUser()
	{
		_EntityDAL = new PersistentLowValueUserDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static PersistentLowValueUser GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntity<int, PersistentLowValueUser>(EntityCacheInfo, $"UserID:{userId}", () => DoGetOrCreate(userId));
	}

	private static PersistentLowValueUser DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<int, PersistentLowValueUserDAL, PersistentLowValueUser>(() => PersistentLowValueUserDAL.GetOrCreatePersistentLowValueUser(userId));
	}

	public static PersistentLowValueUser Get(int id)
	{
		return EntityHelper.GetEntity<int, PersistentLowValueUserDAL, PersistentLowValueUser>(EntityCacheInfo, id, () => PersistentLowValueUserDAL.Get(id));
	}

	public static PersistentLowValueUser GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<int, PersistentLowValueUserDAL, PersistentLowValueUser>(EntityCacheInfo, $"UserID:{userId}", () => PersistentLowValueUserDAL.GetPersistentLowValueUserByUserID(userId));
	}

	public void Construct(PersistentLowValueUserDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
