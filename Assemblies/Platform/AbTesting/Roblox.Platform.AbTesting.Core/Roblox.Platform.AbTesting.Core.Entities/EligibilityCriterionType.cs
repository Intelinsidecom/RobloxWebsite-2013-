using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class EligibilityCriterionType : IRobloxEntity<int, EligibilityCriterionTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private EligibilityCriterionTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), typeof(EligibilityCriterionType).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Value
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

	internal DateTime Updated
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

	public EligibilityCriterionType()
	{
		_EntityDAL = new EligibilityCriterionTypeDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static EligibilityCriterionType Get(int id)
	{
		return EntityHelper.GetEntity<int, EligibilityCriterionTypeDAL, EligibilityCriterionType>(EntityCacheInfo, id, () => EligibilityCriterionTypeDAL.Get(id));
	}

	internal static ICollection<EligibilityCriterionType> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, EligibilityCriterionTypeDAL, EligibilityCriterionType>(ids, EntityCacheInfo, EligibilityCriterionTypeDAL.MultiGet);
	}

	internal static ICollection<EligibilityCriterionType> GetEligibilityCriterionTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetEligibilityCriterionTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy("GetEligibilityCriterionTypesPaged"), collectionId, () => EligibilityCriterionTypeDAL.GetEligibilityCriterionTypeIDsPaged(startRowIndex, maximumRows), MultiGet);
	}

	public void Construct(EligibilityCriterionTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("GetEligibilityCriterionTypesPaged");
	}
}
