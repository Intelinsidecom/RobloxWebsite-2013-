using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership;

namespace Roblox.PremiumFeatures;

public class GrantedAssetListActivationTask : IRobloxEntity<long, GrantedAssetListActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private GrantedAssetListActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "GrantedAssetListActivationTask", isNullCacheable: true);

	private static IAssetOwnershipAuthority _AssetOwnershipAuthority { get; } = new AssetOwnershipAuthority(Asset.LookupAssetTypeId, "ServerClassLibrary", NoOpLogger.Instance);


	public long ID => _EntityDAL.ID;

	internal long PremiumFeatureActivationTaskID
	{
		get
		{
			return _EntityDAL.PremiumFeatureActivationTaskID;
		}
		set
		{
			_EntityDAL.PremiumFeatureActivationTaskID = value;
		}
	}

	internal Guid? WorkerID
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

	internal DateTime? Completed
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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public GrantedAssetListActivationTask()
	{
		_EntityDAL = new GrantedAssetListActivationTaskDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static GrantedAssetListActivationTask CreateNew(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		GrantedAssetListActivationTask grantedAssetListActivationTask = new GrantedAssetListActivationTask();
		grantedAssetListActivationTask.PremiumFeatureActivationTaskID = premiumFeatureActivationTask.ID;
		grantedAssetListActivationTask.Save();
		return grantedAssetListActivationTask;
	}

	internal static GrantedAssetListActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedAssetListActivationTaskDAL, GrantedAssetListActivationTask>(EntityCacheInfo, id, () => GrantedAssetListActivationTaskDAL.Get(id));
	}

	public static GrantedAssetListActivationTask GetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.GetOrCreateEntity<long, GrantedAssetListActivationTask>(EntityCacheInfo, $"PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskID}", () => DoGetOrCreate(premiumFeatureActivationTaskID));
	}

	private static GrantedAssetListActivationTask DoGetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.DoGetOrCreate<long, GrantedAssetListActivationTaskDAL, GrantedAssetListActivationTask>(() => GrantedAssetListActivationTaskDAL.GetOrCreate(premiumFeatureActivationTaskID));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in GrantedAssetListActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			GrantedAssetListActivationTaskDAL entityDal = GrantedAssetListActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				GrantedAssetListActivationTask entity = new GrantedAssetListActivationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(GrantedAssetListActivationTaskDAL dal)
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

	public void ProcessTaskAndMarkComplete()
	{
		PremiumFeatureActivationTask premiumFeatureActivationTask = PremiumFeatureActivationTask.Get(PremiumFeatureActivationTaskID);
		PremiumFeature premiumFeature = PremiumFeature.Get(premiumFeatureActivationTask.PremiumFeatureID);
		if (GrantedAssetList.Get(premiumFeature.GrantedAssetListID).ID == GrantedAssetList.NoneID)
		{
			return;
		}
		User user = User.GetByAccountID(premiumFeatureActivationTask.AccountID);
		foreach (GrantedAssetListItem item2 in GrantedAssetListItem.GetGrantedAssetListItemsByGrantedAssetListID(premiumFeature.GrantedAssetListID))
		{
			Asset asset = Asset.Get(item2.AssetID);
			if (asset == null)
			{
				continue;
			}
			_AssetOwnershipAuthority.AwardAsset(asset.ID, user.ID);
			if (!asset.IsPackageAssetType())
			{
				continue;
			}
			foreach (AccoutrementPackageItem item in AccoutrementPackageItem.GetAccoutrementPackageItems(asset.ID))
			{
				_AssetOwnershipAuthority.AwardAsset(item.AssetID, user.ID);
			}
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
	}
}
