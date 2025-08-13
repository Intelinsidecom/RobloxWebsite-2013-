using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

public class DelayedReleaseAsset : IRobloxEntity<long, DelayedReleaseAssetDAL>, ICacheableObject<long>, ICacheableObject
{
	public const int MaxNumberOfDelayedReleaseAssets = 10000;

	public static TimeSpan BackdatedAssetUpdatedTime = TimeSpan.FromDays(-730.0);

	private DelayedReleaseAssetDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.DelayedReleaseAsset", isNullCacheable: true);

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

	public int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
		}
	}

	public DateTime ReleaseDate
	{
		get
		{
			return _EntityDAL.ReleaseDate;
		}
		set
		{
			_EntityDAL.ReleaseDate = value;
		}
	}

	public int PriceInRobux
	{
		get
		{
			return _EntityDAL.PriceInRobux;
		}
		set
		{
			_EntityDAL.PriceInRobux = value;
		}
	}

	public int PriceInTickets
	{
		get
		{
			return _EntityDAL.PriceInTickets;
		}
		set
		{
			_EntityDAL.PriceInTickets = value;
		}
	}

	public bool IsLimited
	{
		get
		{
			return _EntityDAL.IsLimited;
		}
		set
		{
			_EntityDAL.IsLimited = value;
		}
	}

	public long TotalAvailable
	{
		get
		{
			return _EntityDAL.TotalAvailable;
		}
		set
		{
			_EntityDAL.TotalAvailable = value;
		}
	}

	public byte MinMembershipType
	{
		get
		{
			return _EntityDAL.MinMembershipType;
		}
		set
		{
			_EntityDAL.MinMembershipType = value;
		}
	}

	public DateTime? LeaseExpiration
	{
		get
		{
			return _EntityDAL.LeaseExpiration;
		}
		set
		{
			_EntityDAL.LeaseExpiration = value;
		}
	}

	public Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	public DateTime? Completed
	{
		get
		{
			return _EntityDAL.Completed;
		}
		set
		{
			_EntityDAL.Completed = value;
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

	public Asset Asset => Asset.Get(AssetID);

	public AssetType AssetType => AssetType.Get(AssetTypeID);

	public bool IsExpirable => ExpirationPeriod.HasValue;

	public TimeSpan? ExpirationPeriod
	{
		get
		{
			AssetOption option = AssetOption.GetOrCreate(AssetID);
			if (!option.DefaultExpirationInTicks.HasValue)
			{
				return null;
			}
			return TimeSpan.FromTicks(option.DefaultExpirationInTicks.Value);
		}
		set
		{
			AssetOption option = AssetOption.GetOrCreate(AssetID);
			if (!value.HasValue)
			{
				if (option.DefaultExpirationInTicks.HasValue)
				{
					option.DefaultExpirationInTicks = null;
					option.Save();
				}
				return;
			}
			long ticks = value.Value.Ticks;
			if (!option.DefaultExpirationInTicks.HasValue || option.DefaultExpirationInTicks.Value != ticks)
			{
				option.DefaultExpirationInTicks = ticks;
				option.Save();
			}
		}
	}

	public bool IsForSale
	{
		get
		{
			return _EntityDAL.IsForSale;
		}
		set
		{
			_EntityDAL.IsForSale = value;
		}
	}

	public bool IsPublicDomain
	{
		get
		{
			return _EntityDAL.IsPublicDomain;
		}
		set
		{
			_EntityDAL.IsPublicDomain = value;
		}
	}

	public DateTime? OffSaleDeadline
	{
		get
		{
			return _EntityDAL.OffSaleDeadline;
		}
		set
		{
			_EntityDAL.OffSaleDeadline = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static bool IsDelayedAsset(long assetId)
	{
		bool isDelayed = GetDelayedReleaseAssetAssetIDsPaged(null, 0, 10000).Contains(assetId);
		if (isDelayed && Settings.Default.IsAssetReleaseDateCheckingEnabled)
		{
			return GetDelayedReleaseAssetsPaged(null, 0, 10000).Any((DelayedReleaseAsset a) => a.AssetID == assetId && a.ReleaseDate > DateTime.Now);
		}
		return isDelayed;
	}

	public DelayedReleaseAsset()
	{
		_EntityDAL = new DelayedReleaseAssetDAL();
	}

	public static DelayedReleaseAsset CreateNew(long assetid, int assettypeid, DateTime releasedate, int priceinrobux, bool islimited, long totalavailable, DateTime? leaseexpiration, Guid? workerid, DateTime? completed, byte minBCRequirement, bool isForSale, bool isPublicDomain, DateTime? offSaleDeadline)
	{
		DelayedReleaseAsset delayedReleaseAsset = new DelayedReleaseAsset();
		delayedReleaseAsset.AssetID = assetid;
		delayedReleaseAsset.AssetTypeID = assettypeid;
		delayedReleaseAsset.ReleaseDate = releasedate;
		delayedReleaseAsset.PriceInRobux = priceinrobux;
		delayedReleaseAsset.IsLimited = islimited;
		delayedReleaseAsset.TotalAvailable = totalavailable;
		delayedReleaseAsset.LeaseExpiration = leaseexpiration;
		delayedReleaseAsset.WorkerID = workerid;
		delayedReleaseAsset.Completed = completed;
		delayedReleaseAsset.MinMembershipType = minBCRequirement;
		delayedReleaseAsset.IsForSale = isForSale;
		delayedReleaseAsset.IsPublicDomain = isPublicDomain;
		delayedReleaseAsset.OffSaleDeadline = offSaleDeadline;
		delayedReleaseAsset.Save();
		return delayedReleaseAsset;
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

	public static DelayedReleaseAsset Get(long id)
	{
		return EntityHelper.GetEntity<long, DelayedReleaseAssetDAL, DelayedReleaseAsset>(EntityCacheInfo, id, () => DelayedReleaseAssetDAL.Get(id));
	}

	private static ICollection<DelayedReleaseAsset> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, DelayedReleaseAssetDAL, DelayedReleaseAsset>(ids, EntityCacheInfo, DelayedReleaseAssetDAL.MultiGet);
	}

	public static int GetTotalNumberOfDelayedReleaseAssets(int? assetTypeId)
	{
		string countId = $"GetTotalNumberOfDelayedReleaseAssets_AssetTypeID:{assetTypeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), countId, () => DelayedReleaseAssetDAL.GetTotalNumberOfDelayedReleaseAssets(assetTypeId));
	}

	/// <remarks>
	/// Currently does not directly call DelayedReleaseAssetDAL.GetDelayedReleaseAssetIDsPaged because returns DelayedReleaseAssetID NOT AssetID.
	/// Need to create new DelayedReleaseAssetDAL method + stored procedure to avoid using GetDelayedReleaseAssetsPaged: AVBURST-271.
	/// </remarks>
	private static HashSet<long> GetDelayedReleaseAssetAssetIDsPaged(int? assetTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetDelayedReleaseAssetAssetIDsPaged_AssetTypeID:{assetTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return (HashSet<long>)EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, delegate
		{
			ICollection<DelayedReleaseAsset> delayedReleaseAssetsPaged = GetDelayedReleaseAssetsPaged(assetTypeId, startRowIndex, maximumRows);
			return (delayedReleaseAssetsPaged != null) ? new HashSet<long>(from asset in delayedReleaseAssetsPaged
				where asset != null
				select asset into a
				select a.AssetID) : new HashSet<long>();
		});
	}

	public static ICollection<DelayedReleaseAsset> GetDelayedReleaseAssetsPaged(int? assetTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetDelayedReleaseAssetsPaged_AssetTypeID:{assetTypeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => DelayedReleaseAssetDAL.GetDelayedReleaseAssetIDsPaged(assetTypeId, startRowIndex + 1, maximumRows), MultiGet);
	}

	public void Construct(DelayedReleaseAssetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>();
	}
}
