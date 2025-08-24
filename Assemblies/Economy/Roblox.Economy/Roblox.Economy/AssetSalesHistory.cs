using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Economy.Properties;

namespace Roblox.Economy;

public class AssetSalesHistory : IRobloxEntity<long, AssetSalesHistoryDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private static readonly TimeSpan _UnixEpochTicks = new TimeSpan(DateTime.Parse("1/1/1970").Ticks);

	private readonly TimeSpan _ThirtyDayTimeSpan = TimeSpan.FromDays(30.0);

	private readonly TimeSpan _NinetyDayTimeSpan = TimeSpan.FromDays(90.0);

	private readonly TimeSpan _OneHundredAndEightyDayTimeSpan = TimeSpan.FromDays(180.0);

	private AssetSalesHistoryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Economy.AssetSalesHistory", isNullCacheable: true);

	private static bool PriceGraphEnabled => Settings.Default.PriceGraphEnabled;

	private static TimeSpan PriceGraphUpdateFrequency => Settings.Default.PriceGraphUpdateFrequencyTimeSpan;

	private static bool IsAssetSaleHistoryRemoteCachingEnabled => Settings.Default.IsAssetSaleHistoryRemoteCacheEnabled;

	public long ID => _EntityDAL.ID;

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	public string ThirtyDaySalesChart
	{
		get
		{
			return _EntityDAL.ThirtyDaySalesChart;
		}
		set
		{
			_EntityDAL.ThirtyDaySalesChart = value;
		}
	}

	public string ThirtyDayVolumeChart
	{
		get
		{
			return _EntityDAL.ThirtyDayVolumeChart;
		}
		set
		{
			_EntityDAL.ThirtyDayVolumeChart = value;
		}
	}

	public int ThirtyDayAveragePrice
	{
		get
		{
			return _EntityDAL.ThirtyDayAveragePrice;
		}
		set
		{
			_EntityDAL.ThirtyDayAveragePrice = value;
		}
	}

	public int ThirtyDaySalesVolume
	{
		get
		{
			return _EntityDAL.ThirtyDaySalesVolume;
		}
		set
		{
			_EntityDAL.ThirtyDaySalesVolume = value;
		}
	}

	public string NinetyDaySalesChart
	{
		get
		{
			return _EntityDAL.NinetyDaySalesChart;
		}
		set
		{
			_EntityDAL.NinetyDaySalesChart = value;
		}
	}

	public string NinetyDayVolumeChart
	{
		get
		{
			return _EntityDAL.NinetyDayVolumeChart;
		}
		set
		{
			_EntityDAL.NinetyDayVolumeChart = value;
		}
	}

	public int NinetyDayAveragePrice
	{
		get
		{
			return _EntityDAL.NinetyDayAveragePrice;
		}
		set
		{
			_EntityDAL.NinetyDayAveragePrice = value;
		}
	}

	public int NinetyDaySalesVolume
	{
		get
		{
			return _EntityDAL.NinetyDaySalesVolume;
		}
		set
		{
			_EntityDAL.NinetyDaySalesVolume = value;
		}
	}

	public string HundredEightyDaySalesChart
	{
		get
		{
			return _EntityDAL.HundredEightyDaySalesChart;
		}
		set
		{
			_EntityDAL.HundredEightyDaySalesChart = value;
		}
	}

	public string HundredEightyDayVolumeChart
	{
		get
		{
			return _EntityDAL.HundredEightyDayVolumeChart;
		}
		set
		{
			_EntityDAL.HundredEightyDayVolumeChart = value;
		}
	}

	public int HundredEightyDayAveragePrice
	{
		get
		{
			return _EntityDAL.HundredEightyDayAveragePrice;
		}
		set
		{
			_EntityDAL.HundredEightyDayAveragePrice = value;
		}
	}

	public int HundredEightyDaySalesVolume
	{
		get
		{
			return _EntityDAL.HundredEightyDaySalesVolume;
		}
		set
		{
			_EntityDAL.HundredEightyDaySalesVolume = value;
		}
	}

	public int RecentAveragePrice
	{
		get
		{
			return _EntityDAL.RecentAveragePrice;
		}
		set
		{
			_EntityDAL.RecentAveragePrice = value;
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

	public DateTime UpdatedCharts
	{
		get
		{
			return _EntityDAL.UpdatedCharts;
		}
		set
		{
			_EntityDAL.UpdatedCharts = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetSalesHistory()
	{
		_EntityDAL = new AssetSalesHistoryDAL();
	}

	public AssetSalesHistory(AssetSalesHistoryDAL dal)
	{
		_EntityDAL = dal;
	}

	public static AssetSalesHistory Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetSalesHistoryDAL, AssetSalesHistory>(EntityCacheInfo, id, () => AssetSalesHistoryDAL.Get(id));
	}

	public static AssetSalesHistory GetByAssetID(long assetId)
	{
		if (IsAssetSaleHistoryRemoteCachingEnabled)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, AssetSalesHistoryDAL, AssetSalesHistory>(EntityCacheInfo, GetLookupKeyByAssetId(assetId), () => AssetSalesHistoryDAL.GetByAssetID(assetId), Get);
		}
		return EntityHelper.GetEntityByLookup<long, AssetSalesHistoryDAL, AssetSalesHistory>(EntityCacheInfo, GetLookupKeyByAssetId(assetId), () => AssetSalesHistoryDAL.GetByAssetID(assetId));
	}

	public static AssetSalesHistory CreateNew(long AssetID, string thirtydaysaleschart, string thirtydayvolumechart, int thirtydayaverageprice, int thirtydaysalesvolume, string ninetydaysaleschart, string ninetydayvolumechart, int ninetydayaverageprice, int ninetydaysalesvolume, string hundredeightydaysaleschart, string hundredeightydayvolumechart, int hundredeightydayaverageprice, int hundredeightydaysalesvolume, int recentaverageprice)
	{
		AssetSalesHistory assetSalesHistory = new AssetSalesHistory();
		assetSalesHistory.AssetID = AssetID;
		assetSalesHistory.ThirtyDaySalesChart = thirtydaysaleschart;
		assetSalesHistory.ThirtyDayVolumeChart = thirtydayvolumechart;
		assetSalesHistory.ThirtyDayAveragePrice = thirtydayaverageprice;
		assetSalesHistory.ThirtyDaySalesVolume = thirtydaysalesvolume;
		assetSalesHistory.NinetyDaySalesChart = ninetydaysaleschart;
		assetSalesHistory.NinetyDayVolumeChart = ninetydayvolumechart;
		assetSalesHistory.NinetyDayAveragePrice = ninetydayaverageprice;
		assetSalesHistory.NinetyDaySalesVolume = ninetydaysalesvolume;
		assetSalesHistory.HundredEightyDaySalesChart = hundredeightydaysaleschart;
		assetSalesHistory.HundredEightyDayVolumeChart = hundredeightydayvolumechart;
		assetSalesHistory.HundredEightyDayAveragePrice = hundredeightydayaverageprice;
		assetSalesHistory.HundredEightyDaySalesVolume = hundredeightydaysalesvolume;
		assetSalesHistory.RecentAveragePrice = recentaverageprice;
		assetSalesHistory.Save();
		return assetSalesHistory;
	}

	public void Save()
	{
		if (IsAssetSaleHistoryRemoteCachingEnabled)
		{
			EntityHelper.SaveEntityWithRemoteCache(this, delegate
			{
				_EntityDAL.Created = DateTime.Now;
				_EntityDAL.Updated = Created;
				_EntityDAL.UpdatedCharts = Created.AddDays(-7.0);
				_EntityDAL.Insert();
			}, delegate
			{
				_EntityDAL.Updated = DateTime.Now;
				if (_EntityDAL.UpdatedCharts == default(DateTime))
				{
					_EntityDAL.UpdatedCharts = Updated.AddDays(-7.0);
				}
				_EntityDAL.Update();
			});
			return;
		}
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.UpdatedCharts = Created.AddDays(-7.0);
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			if (_EntityDAL.UpdatedCharts == default(DateTime))
			{
				_EntityDAL.UpdatedCharts = Updated.AddDays(-7.0);
			}
			_EntityDAL.Update();
		});
	}

	public void Construct(AssetSalesHistoryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return GetLookupKeyByAssetId(AssetID);
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public void RefreshEntryIfRequired(bool forceUpdate)
	{
		if (!PriceGraphEnabled || (!forceUpdate && !(DateTime.Now - UpdatedCharts > PriceGraphUpdateFrequency)))
		{
			return;
		}
		using UpdateStatsRemoteLock statsLock = new UpdateStatsRemoteLock(EntityCacheInfo, AssetID);
		if (statsLock.IsLockAquired)
		{
			HundredEightyDaySalesChart = GetSalesChart(DateTime.Now - _OneHundredAndEightyDayTimeSpan, DateTime.Now);
			HundredEightyDayVolumeChart = GetVolumeChart(DateTime.Now - _OneHundredAndEightyDayTimeSpan, DateTime.Now);
			UpdateStats();
			UpdatedCharts = DateTime.Now;
			Save();
		}
	}

	private static long GetJavascriptTimestamp(DateTime input)
	{
		return input.Subtract(_UnixEpochTicks).Ticks / 10000;
	}

	private void UpdateStats()
	{
		ThirtyDayAveragePrice = AssetSalesHistoryDAL.GetAveragePrice(AssetID, DateTime.Now - _ThirtyDayTimeSpan, DateTime.Now);
		NinetyDayAveragePrice = AssetSalesHistoryDAL.GetAveragePrice(AssetID, DateTime.Now - _NinetyDayTimeSpan, DateTime.Now);
		HundredEightyDayAveragePrice = AssetSalesHistoryDAL.GetAveragePrice(AssetID, DateTime.Now - _OneHundredAndEightyDayTimeSpan, DateTime.Now);
		ThirtyDaySalesVolume = AssetSalesHistoryDAL.GetVolume(AssetID, DateTime.Now - _ThirtyDayTimeSpan, DateTime.Now);
		NinetyDaySalesVolume = AssetSalesHistoryDAL.GetVolume(AssetID, DateTime.Now - _NinetyDayTimeSpan, DateTime.Now);
		HundredEightyDaySalesVolume = AssetSalesHistoryDAL.GetVolume(AssetID, DateTime.Now - _OneHundredAndEightyDayTimeSpan, DateTime.Now);
	}

	private string GetSalesChart(DateTime start, DateTime end)
	{
		List<Tuple<DateTime, int>> d = AssetSalesHistoryDAL.GetAverageDailySalesPrices(AssetID, start, end);
		return GetAsString(d);
	}

	private string GetVolumeChart(DateTime start, DateTime end)
	{
		List<Tuple<DateTime, int>> d = AssetSalesHistoryDAL.GetDailyVolume(AssetID, start, end);
		return GetAsString(d);
	}

	private string GetAsString(List<Tuple<DateTime, int>> data)
	{
		string s = "[";
		foreach (Tuple<DateTime, int> tuple in data)
		{
			if (s.Length > 1)
			{
				s += ",";
			}
			s = s + "[" + GetJavascriptTimestamp(tuple.Item1) + "," + tuple.Item2 + "]";
		}
		return s + "]";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupKeyByAssetId(long assetId)
	{
		return $"AssetID:{assetId}";
	}
}
