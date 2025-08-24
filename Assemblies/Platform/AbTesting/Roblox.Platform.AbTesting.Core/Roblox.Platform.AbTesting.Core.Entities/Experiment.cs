using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class Experiment : IRobloxEntity<int, ExperimentDAL>, ICacheableObject<int>, ICacheableObject
{
	private ExperimentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Experiment).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	internal int Variations
	{
		get
		{
			return _EntityDAL.Variations;
		}
		set
		{
			_EntityDAL.Variations = value;
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

	internal bool IsEnrollmentExclusive
	{
		get
		{
			return _EntityDAL.IsEnrollmentExclusive;
		}
		set
		{
			_EntityDAL.IsEnrollmentExclusive = value;
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

	public Experiment()
	{
		_EntityDAL = new ExperimentDAL();
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

	internal static Experiment Get(int id)
	{
		return EntityHelper.GetEntity<int, ExperimentDAL, Experiment>(EntityCacheInfo, id, () => ExperimentDAL.Get(id));
	}

	internal static ICollection<Experiment> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ExperimentDAL, Experiment>(ids, EntityCacheInfo, ExperimentDAL.MultiGet);
	}

	internal static Experiment GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, ExperimentDAL, Experiment>(EntityCacheInfo, $"Name:{name}", () => ExperimentDAL.GetExperimentByName(name));
	}

	internal static ICollection<Experiment> GetExperimentsPaged(long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetExperimentsByNamePaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy("GetExperimentsByNamePaged"), collectionId, () => ExperimentDAL.GetExperimentIDsPaged(startRowIndex, maximumRows), MultiGet);
	}

	public void Construct(ExperimentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Name:{Name}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("GetExperimentsByNamePaged");
	}
}
