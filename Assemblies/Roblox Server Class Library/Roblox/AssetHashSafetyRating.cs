using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

public class AssetHashSafetyRating : IRobloxEntity<long, AssetHashSafetyRatingDAL>, ICacheableObject<long>, ICacheableObject
{
	/// Data Members *
	private AssetHashSafetyRatingDAL _EntityDAL;

	public static float MaxSafety = 1f;

	public static float MinSafety = 0f;

	private static readonly HashSet<long> _updateSafetyIdsBeingProcessed = new HashSet<long>();

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetHashSafetyRating", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	public float Safety
	{
		get
		{
			return _EntityDAL.Safety;
		}
		set
		{
			_EntityDAL.Safety = value;
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

	/// Properties *
	public static float MinAssetHashSafetyRatingToDisplay => Settings.Default.MinAssetHashSafetyRatingToDisplay;

	public static long AssetHashSafetyRatingRecalculationIntervalInTicks => Settings.Default.AssetHashSafetyRatingRecalculationIntervalInTicks;

	public static float AssetHashSafetyDefaultRating => Settings.Default.AssetHashSafetyDefaultRating;

	public CacheInfo CacheInfo => EntityCacheInfo;

	/// CRUD *
	public AssetHashSafetyRating()
	{
		_EntityDAL = new AssetHashSafetyRatingDAL();
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

	public static AssetHashSafetyRating GetOrCreate(long assetHashId)
	{
		return GetOrCreate(assetHashId, submitUpdateRequest: true);
	}

	private static AssetHashSafetyRating GetOrCreate(long assetHashId, bool submitUpdateRequest)
	{
		AssetHashSafetyRating entity = EntityHelper.GetOrCreateEntity<long, AssetHashSafetyRating>(EntityCacheInfo, $"AssetHashID:{assetHashId}", () => DoGetOrCreate(assetHashId, AssetHashSafetyDefaultRating));
		if (submitUpdateRequest && ((DateTime.Now - entity.Updated).Ticks > AssetHashSafetyRatingRecalculationIntervalInTicks || entity.Created == entity.Updated))
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				UpdateSafety(assetHashId);
			});
		}
		return entity;
	}

	private static AssetHashSafetyRating DoGetOrCreate(long assetHashId, float safety)
	{
		return EntityHelper.DoGetOrCreate<long, AssetHashSafetyRatingDAL, AssetHashSafetyRating>(() => AssetHashSafetyRatingDAL.GetOrCreate(assetHashId, safety));
	}

	/// Methods *
	public bool IsTrusted()
	{
		return Safety >= MinAssetHashSafetyRatingToDisplay;
	}

	/// Static Methods *
	public static float CalculateSafety(long assetHashId)
	{
		return MaxSafety;
	}

	private static void UpdateSafety(long assetHashId)
	{
		AssetHashSafetyRating ahsr = GetOrCreate(assetHashId, submitUpdateRequest: false);
		if ((DateTime.Now - ahsr.Updated).Ticks < AssetHashSafetyRatingRecalculationIntervalInTicks && ahsr.Updated != ahsr.Created)
		{
			return;
		}
		lock (_updateSafetyIdsBeingProcessed)
		{
			if (_updateSafetyIdsBeingProcessed.Contains(assetHashId))
			{
				return;
			}
			_updateSafetyIdsBeingProcessed.Add(assetHashId);
		}
		try
		{
			ahsr.SetSafety(CalculateSafety(ahsr.AssetHashID));
		}
		finally
		{
			lock (_updateSafetyIdsBeingProcessed)
			{
				_updateSafetyIdsBeingProcessed.Remove(assetHashId);
			}
		}
	}

	public void SetSafety(float safety)
	{
		if (Safety != safety)
		{
			Safety = safety;
			Save();
		}
	}

	public void Construct(AssetHashSafetyRatingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetHashID:{AssetHashID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>();
	}
}
