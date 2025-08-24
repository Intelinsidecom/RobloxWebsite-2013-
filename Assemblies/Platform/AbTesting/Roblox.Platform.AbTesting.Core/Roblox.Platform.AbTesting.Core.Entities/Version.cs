using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class Version : IRobloxEntity<int, VersionDAL>, ICacheableObject<int>, ICacheableObject
{
	private VersionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Version).ToString(), isNullCacheable: true);

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

	internal byte VersionNumber
	{
		get
		{
			return _EntityDAL.VersionNumber;
		}
		set
		{
			_EntityDAL.VersionNumber = value;
		}
	}

	internal int EnrollmentPeriodInHours
	{
		get
		{
			return _EntityDAL.EnrollmentPeriodInHours;
		}
		set
		{
			_EntityDAL.EnrollmentPeriodInHours = value;
		}
	}

	internal DateTime Started
	{
		get
		{
			return _EntityDAL.Started;
		}
		set
		{
			_EntityDAL.Started = value;
		}
	}

	internal DateTime EndDate
	{
		get
		{
			return _EntityDAL.EndDate;
		}
		set
		{
			_EntityDAL.EndDate = value;
		}
	}

	internal bool IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
		}
	}

	internal byte PercentOfSubjectsToEnroll
	{
		get
		{
			return _EntityDAL.PercentOfSubjectsToEnroll;
		}
		set
		{
			_EntityDAL.PercentOfSubjectsToEnroll = value;
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

	public Version()
	{
		_EntityDAL = new VersionDAL();
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

	internal static Version Get(int id)
	{
		return EntityHelper.GetEntity<int, VersionDAL, Version>(EntityCacheInfo, id, () => VersionDAL.Get(id));
	}

	internal static ICollection<Version> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, VersionDAL, Version>(ids, EntityCacheInfo, VersionDAL.MultiGet);
	}

	public static Version GetByExperimentIDAndVersion(int experimentID, byte version)
	{
		return EntityHelper.GetEntityByLookup<int, VersionDAL, Version>(EntityCacheInfo, $"ExperimentID:{experimentID}_Version:{version}", () => VersionDAL.GetVersionByExperimentIDAndVersion(experimentID, version));
	}

	internal static ICollection<Version> GetVersionsByExperimentIDAndIsActivePaged(int experimentID, bool isActive, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetVersionsByExperimentIDAndIsActivePaged_ExperimentID:{experimentID}_IsActive:{isActive}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ExperimentID:{experimentID}_IsActive:{isActive}"), collectionId, () => VersionDAL.GetVersionIDsByExperimentIDAndIsActivePaged(experimentID, isActive, startRowIndex, maximumRows), MultiGet);
	}

	internal static ICollection<Version> GetVersionsByIsActivePaged(bool isActive, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetVersionsByIsActivePaged_IsActive:{isActive}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"IsActive:{isActive}"), collectionId, () => VersionDAL.GetVersionIDsByIsActivePaged(isActive, startRowIndex, maximumRows), MultiGet);
	}

	internal static ICollection<Version> GetVersionsByExperimentIDPaged(int experimentID, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetVersionsByExperimentIDPaged_ExperimentID:{experimentID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"ExperimentID:{experimentID}"), collectionId, () => VersionDAL.GetVersionIDsByExperimentIDPaged(experimentID, startRowIndex, maximumRows), MultiGet);
	}

	public void Construct(VersionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ExperimentID:{ExperimentID}_Version:{VersionNumber}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ExperimentID:{ExperimentID}");
		yield return new StateToken($"ExperimentID:{ExperimentID}_IsActive:{IsActive}");
		yield return new StateToken($"IsActive:{IsActive}");
	}
}
