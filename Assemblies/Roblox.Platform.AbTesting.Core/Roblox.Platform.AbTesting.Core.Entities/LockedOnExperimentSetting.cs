using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AbTesting.Core.Entities;

internal class LockedOnExperimentSetting : IRobloxEntity<int, LockedOnExperimentSettingDAL>, ICacheableObject<int>, ICacheableObject
{
	private LockedOnExperimentSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(LockedOnExperimentSetting).ToString(), isNullCacheable: true);

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

	internal byte? LockedOnVariationValue
	{
		get
		{
			return _EntityDAL.LockedOnVariationValue;
		}
		set
		{
			_EntityDAL.LockedOnVariationValue = value;
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

	public LockedOnExperimentSetting()
	{
		_EntityDAL = new LockedOnExperimentSettingDAL();
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

	public void Construct(LockedOnExperimentSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ExperimentID:{ExperimentID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static LockedOnExperimentSetting DoGetOrCreate(int experimentID)
	{
		return EntityHelper.DoGetOrCreate<int, LockedOnExperimentSettingDAL, LockedOnExperimentSetting>(() => LockedOnExperimentSettingDAL.GetOrCreateLockedOnExperimentSetting(experimentID));
	}

	public static LockedOnExperimentSetting GetOrCreate(int experimentID)
	{
		return EntityHelper.GetOrCreateEntity<int, LockedOnExperimentSetting>(EntityCacheInfo, $"ExperimentID:{experimentID}", () => DoGetOrCreate(experimentID));
	}

	internal static LockedOnExperimentSetting Get(int id)
	{
		return EntityHelper.GetEntity<int, LockedOnExperimentSettingDAL, LockedOnExperimentSetting>(EntityCacheInfo, id, () => LockedOnExperimentSettingDAL.Get(id));
	}

	internal static ICollection<LockedOnExperimentSetting> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, LockedOnExperimentSettingDAL, LockedOnExperimentSetting>(ids, EntityCacheInfo, LockedOnExperimentSettingDAL.MultiGet);
	}
}
