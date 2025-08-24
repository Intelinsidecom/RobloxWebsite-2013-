using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class RenewalPeriodType : IRobloxEntity<byte, RenewalPeriodTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private RenewalPeriodTypeDAL _EntityDAL;

	public static readonly RenewalPeriodType Monthly;

	public static readonly RenewalPeriodType Quarterly;

	public static readonly RenewalPeriodType SemiAnnual;

	public static readonly RenewalPeriodType Annual;

	public static readonly RenewalPeriodType Hourly;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
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

	public RenewalPeriodType()
	{
		_EntityDAL = new RenewalPeriodTypeDAL();
	}

	static RenewalPeriodType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RenewalPeriodType", isNullCacheable: true);
		Monthly = Get("Monthly");
		Quarterly = Get("Quarterly");
		SemiAnnual = Get("Semi-Annual");
		Annual = Get("Annual");
		Hourly = Get("HourlyForTesting");
	}

	private static RenewalPeriodType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, RenewalPeriodTypeDAL, RenewalPeriodType>(() => RenewalPeriodTypeDAL.Get(value), $"Value:{value}");
	}

	private static RenewalPeriodType DoGet(byte id)
	{
		return EntityHelper.DoGetByLookup<byte, RenewalPeriodTypeDAL, RenewalPeriodType>(() => RenewalPeriodTypeDAL.Get(id), $"ID:{id}");
	}

	public static RenewalPeriodType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, RenewalPeriodTypeDAL, RenewalPeriodType>(EntityCacheInfo, "Value:" + value, () => RenewalPeriodTypeDAL.Get(value));
	}

	public void Construct(RenewalPeriodTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public static RenewalPeriodType Get(byte renewalPeriodTypeID)
	{
		return EntityHelper.GetEntityByLookupOld<byte, RenewalPeriodType>(EntityCacheInfo, $"Id:{renewalPeriodTypeID}", () => DoGet(renewalPeriodTypeID));
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}
}
