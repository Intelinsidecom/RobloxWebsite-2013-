using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy.Common;

public class ExchangeRate : IRobloxEntity<long, ExchangeRateDAL>, ICacheableObject<long>, ICacheableObject
{
	private ExchangeRateDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false), typeof(ExchangeRate).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public decimal Value
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ExchangeRate()
	{
		_EntityDAL = new ExchangeRateDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	public static ExchangeRate Get(long id)
	{
		return EntityHelper.GetEntity<long, ExchangeRateDAL, ExchangeRate>(EntityCacheInfo, id, () => ExchangeRateDAL.Get(id));
	}

	public static ExchangeRate GetLatestExchangeRate()
	{
		return GetRecentExhangeRates(0, 1).FirstOrDefault();
	}

	public static ICollection<ExchangeRate> GetRecentExhangeRates(int startRow, int maxRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(TimeSpan.FromMinutes(5.0)), "LatestExchangeRate", () => ExchangeRateDAL.GetLatestExchangeRateIDs_Paged(startRow + 1, maxRows), Get);
	}

	public void Construct(ExchangeRateDAL dal)
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
