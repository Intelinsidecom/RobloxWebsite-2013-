using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ImbursementAuthorization : IRobloxEntity<int, ImbursementAuthorizationDAL>, ICacheableObject<int>, ICacheableObject
{
	private ImbursementAuthorizationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ImbursementAuthorization).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int ImbursementID
	{
		get
		{
			return _EntityDAL.ImbursementID;
		}
		set
		{
			_EntityDAL.ImbursementID = value;
		}
	}

	public bool CSAuth
	{
		get
		{
			return _EntityDAL.CSAuth;
		}
		set
		{
			_EntityDAL.CSAuth = value;
		}
	}

	public long? CSID
	{
		get
		{
			return _EntityDAL.CSID;
		}
		set
		{
			_EntityDAL.CSID = value;
		}
	}

	public bool BursarAuth
	{
		get
		{
			return _EntityDAL.BursarAuth;
		}
		set
		{
			_EntityDAL.BursarAuth = value;
		}
	}

	public long? BursarID
	{
		get
		{
			return _EntityDAL.BursarID;
		}
		set
		{
			_EntityDAL.BursarID = value;
		}
	}

	public string Notes
	{
		get
		{
			return _EntityDAL.Notes;
		}
		set
		{
			_EntityDAL.Notes = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ImbursementAuthorization()
	{
		_EntityDAL = new ImbursementAuthorizationDAL();
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

	public static ImbursementAuthorization CreateNew(int imbursementid, bool csauth, long? csid, bool bursarauth, long? bursarid, string notes)
	{
		ImbursementAuthorization imbursementAuthorization = new ImbursementAuthorization();
		imbursementAuthorization.ImbursementID = imbursementid;
		imbursementAuthorization.CSAuth = csauth;
		imbursementAuthorization.CSID = csid;
		imbursementAuthorization.BursarAuth = bursarauth;
		imbursementAuthorization.BursarID = bursarid;
		imbursementAuthorization.Notes = notes;
		imbursementAuthorization.Save();
		return imbursementAuthorization;
	}

	public static ImbursementAuthorization Get(int id)
	{
		return EntityHelper.GetEntity<int, ImbursementAuthorizationDAL, ImbursementAuthorization>(EntityCacheInfo, id, () => ImbursementAuthorizationDAL.Get(id));
	}

	public static ImbursementAuthorization GetByImbursementID(int imbursementId)
	{
		return EntityHelper.GetEntityByLookup<int, ImbursementAuthorizationDAL, ImbursementAuthorization>(EntityCacheInfo, $"ImbursementID:{imbursementId}", () => ImbursementAuthorizationDAL.GetByImbursementID(imbursementId));
	}

	public static ImbursementAuthorization GetOrCreate(int imbursementId)
	{
		return EntityHelper.GetOrCreateEntity<int, ImbursementAuthorization>(EntityCacheInfo, $"ImbursementID:{imbursementId}", () => DoGetOrCreate(imbursementId));
	}

	private static ImbursementAuthorization DoGetOrCreate(int imbursementId)
	{
		return EntityHelper.DoGetOrCreate<int, ImbursementAuthorizationDAL, ImbursementAuthorization>(() => ImbursementAuthorizationDAL.GetOrCreate(imbursementId));
	}

	public void Construct(ImbursementAuthorizationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ImbursementID:{ImbursementID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
