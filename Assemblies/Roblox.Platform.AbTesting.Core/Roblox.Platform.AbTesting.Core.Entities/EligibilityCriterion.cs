using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class EligibilityCriterion : IRobloxEntity<int, EligibilityCriterionDAL>, ICacheableObject<int>, ICacheableObject
{
	private EligibilityCriterionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(EligibilityCriterion).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal int ExperimentID
	{
		get
		{
			return _EntityDAL.ExperimentID;
		}
		set
		{
			_EntityDAL.ExperimentID = value;
		}
	}

	internal int EligibilityCriterionTypeID
	{
		get
		{
			return _EntityDAL.EligibilityCriterionTypeID;
		}
		set
		{
			_EntityDAL.EligibilityCriterionTypeID = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public EligibilityCriterion()
	{
		_EntityDAL = new EligibilityCriterionDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static EligibilityCriterion Get(int id)
	{
		return EntityHelper.GetEntity<int, EligibilityCriterionDAL, EligibilityCriterion>(EntityCacheInfo, id, () => EligibilityCriterionDAL.Get(id));
	}

	internal static ICollection<EligibilityCriterion> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, EligibilityCriterionDAL, EligibilityCriterion>(ids, EntityCacheInfo, EligibilityCriterionDAL.MultiGet);
	}

	internal static ICollection<EligibilityCriterion> GetEligibilityCriteriaByExperimentIDPaged(int experimentID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetEligibilityCriteriaByExperimentIDPaged_ExperimentID:{experimentID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ExperimentID:{experimentID}"), collectionId, () => EligibilityCriterionDAL.GetEligibilityCriterionIDsByExperimentIDPaged(experimentID, startRowIndex, maximumRows), MultiGet);
	}

	internal static EligibilityCriterion GetByExperimentIDAndEligibilityCriterionTypeID(int experimentID, int eligibilityCriterionTypeID)
	{
		return EntityHelper.GetEntityByLookup<int, EligibilityCriterionDAL, EligibilityCriterion>(EntityCacheInfo, $"ExperimentID:{experimentID}_EligibilityCriterionTypeID:{eligibilityCriterionTypeID}", () => EligibilityCriterionDAL.GetEligibilityCriterionByExperimentIDAndEligibilityCriterionTypeID(experimentID, eligibilityCriterionTypeID));
	}

	internal static EligibilityCriterion GetOrCreate(int experimentID, int eligibilityCriterionTypeID)
	{
		return EntityHelper.GetOrCreateEntity<int, EligibilityCriterion>(EntityCacheInfo, $"ExperimentID:{experimentID}_EligibilityCriterionTypeID:{eligibilityCriterionTypeID}", () => DoGetOrCreate(experimentID, eligibilityCriterionTypeID));
	}

	internal static EligibilityCriterion DoGetOrCreate(int experimentID, int eligibilityCriterionTypeID)
	{
		return EntityHelper.DoGetOrCreate<int, EligibilityCriterionDAL, EligibilityCriterion>(() => EligibilityCriterionDAL.GetOrCreateEligibilityCriterion(experimentID, eligibilityCriterionTypeID));
	}

	public void Construct(EligibilityCriterionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ExperimentID:{ExperimentID}_EligibilityCriterionTypeID:{EligibilityCriterionTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ExperimentID:{ExperimentID}");
	}
}
