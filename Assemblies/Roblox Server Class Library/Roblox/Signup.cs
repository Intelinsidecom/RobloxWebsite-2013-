using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

public class Signup : IEquatable<Signup>, IRobloxEntity<long, SignupDAL>, ICacheableObject<long>, ICacheableObject
{
	public enum LookupFilter
	{
		ID,
		UserID
	}

	private SignupDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Signup", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long? UserID
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

	public bool? AgeGroup
	{
		get
		{
			return _EntityDAL.AgeGroup;
		}
		set
		{
			_EntityDAL.AgeGroup = value;
		}
	}

	public int? SignupPath
	{
		get
		{
			return _EntityDAL.SignupPath;
		}
		set
		{
			_EntityDAL.SignupPath = value;
		}
	}

	public bool? DOBPageViewed
	{
		get
		{
			return _EntityDAL.DOBPageViewed;
		}
		set
		{
			_EntityDAL.DOBPageViewed = value;
		}
	}

	public bool? UsernamePageViewed
	{
		get
		{
			return _EntityDAL.UsernamePageViewed;
		}
		set
		{
			_EntityDAL.UsernamePageViewed = value;
		}
	}

	public bool? EmailPageViewed
	{
		get
		{
			return _EntityDAL.EmailPageViewed;
		}
		set
		{
			_EntityDAL.EmailPageViewed = value;
		}
	}

	public bool? EmailValidated
	{
		get
		{
			return _EntityDAL.EmailValidated;
		}
		set
		{
			_EntityDAL.EmailValidated = value;
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

	public int ThemeTypeID
	{
		get
		{
			return _EntityDAL.ThemeTypeID;
		}
		set
		{
			_EntityDAL.ThemeTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Signup()
	{
		_EntityDAL = new SignupDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			DateTime created = (Updated = DateTime.Now);
			Created = created;
			_EntityDAL.Insert();
		}, delegate
		{
			Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static Signup DoGet(LookupFilter lookupFilter, long id)
	{
		return EntityHelper.DoGetByLookup<long, SignupDAL, Signup>(() => SignupDAL.Get(SignupDAL.SelectFilter.UserID, id), $"UserID:{id}");
	}

	public static Signup Get(LookupFilter lookupFilter, long id)
	{
		if (lookupFilter == LookupFilter.ID)
		{
			return Get(id);
		}
		return EntityHelper.GetEntityByLookupOld<long, Signup>(EntityCacheInfo, $"UserID:{id}", () => DoGet(LookupFilter.UserID, id));
	}

	private static Signup DoGet(long id)
	{
		return EntityHelper.DoGet<long, SignupDAL, Signup>(() => SignupDAL.Get(id), id);
	}

	public static Signup Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public bool Equals(Signup other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(SignupDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null && UserID.HasValue)
		{
			yield return $"UserID:{UserID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
