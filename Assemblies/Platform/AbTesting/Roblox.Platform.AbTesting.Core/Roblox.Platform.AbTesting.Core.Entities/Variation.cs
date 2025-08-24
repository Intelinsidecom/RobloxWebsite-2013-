using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class Variation : IRobloxEntity<int, VariationDAL>, ICacheableObject<int>, ICacheableObject
{
	private VariationDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Variation).ToString(), isNullCacheable: true);

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

	internal int Value
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

	internal int PercentEnrollments
	{
		get
		{
			return _EntityDAL.PercentEnrollments;
		}
		set
		{
			_EntityDAL.PercentEnrollments = value;
		}
	}

	internal byte Version
	{
		get
		{
			return _EntityDAL.Version;
		}
		set
		{
			_EntityDAL.Version = value;
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

	public Variation()
	{
		_EntityDAL = new VariationDAL();
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

	internal static Variation Get(int id)
	{
		return EntityHelper.GetEntity<int, VariationDAL, Variation>(EntityCacheInfo, id, () => VariationDAL.Get(id));
	}

	internal static ICollection<Variation> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, VariationDAL, Variation>(ids, EntityCacheInfo, VariationDAL.MultiGet);
	}

	internal static ICollection<Variation> GetVariationsByExperimentIDAndVersionPaged(int experimentID, byte version, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetVariationsByExperimentIDAndVersionPaged_ExperimentID:{experimentID}_Version:{version}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ExperimentID:{experimentID}_Version:{version}"), collectionId, () => VariationDAL.GetVariationIDsByExperimentIDAndVersionPaged(experimentID, version, startRowIndex, maximumRows), MultiGet);
	}

	public void Construct(VariationDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ExperimentID:{ExperimentID}_Version:{Version}");
	}
}
