using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CancellationAuditLog : IRobloxEntity<int, CancellationAuditLogDAL>, ICacheableObject<int>, ICacheableObject
{
	private CancellationAuditLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CancellationAuditLog", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public string CancelledBy
	{
		get
		{
			return _EntityDAL.CancelledBy;
		}
		set
		{
			_EntityDAL.CancelledBy = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CancellationAuditLog()
	{
		_EntityDAL = new CancellationAuditLogDAL();
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

	public static CancellationAuditLog CreateNew(int saleId, string cancelledBy)
	{
		CancellationAuditLog cancellationAuditLog = new CancellationAuditLog();
		cancellationAuditLog.SaleID = saleId;
		cancellationAuditLog.CancelledBy = cancelledBy;
		cancellationAuditLog.Save();
		return cancellationAuditLog;
	}

	public static CancellationAuditLog Get(int id)
	{
		return EntityHelper.GetEntity<int, CancellationAuditLogDAL, CancellationAuditLog>(EntityCacheInfo, id, () => CancellationAuditLogDAL.Get(id));
	}

	public void Construct(CancellationAuditLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
