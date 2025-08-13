using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Properties;

namespace Roblox;

public class ReportedScript : IEquatable<ReportedScript>, IRobloxEntity<long, ReportedScriptDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReportedScriptDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ReportedScript", isNullCacheable: true);

	public static bool ParseScriptsFromBuggyPlacesOn => Settings.Default.ParseScriptsFromReportedPlacesOn;

	public static int UploadedPlaceParsingFrequency => Settings.Default.UploadedPlaceParsingFrequency;

	public long ID => _EntityDAL.ID;

	public int ScriptID
	{
		get
		{
			return _EntityDAL.ScriptID;
		}
		set
		{
			_EntityDAL.ScriptID = value;
		}
	}

	public int NumberOfInstancesInAsset
	{
		get
		{
			return _EntityDAL.NumberOfInstancesInAsset;
		}
		set
		{
			_EntityDAL.NumberOfInstancesInAsset = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public Script Script => Script.Get(ScriptID);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReportedScript()
	{
		_EntityDAL = new ReportedScriptDAL();
	}

	public static ReportedScript Get(long id)
	{
		return EntityHelper.GetEntity<long, ReportedScriptDAL, ReportedScript>(EntityCacheInfo, id, () => ReportedScriptDAL.Get(id));
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

	public static ReportedScript CreateNew(int scriptId, int numberOfInstancesInAsset)
	{
		ReportedScript reportedScript = new ReportedScript();
		reportedScript.ScriptID = scriptId;
		reportedScript.NumberOfInstancesInAsset = numberOfInstancesInAsset;
		reportedScript.Save();
		return reportedScript;
	}

	public static int GetTotalNumberOfReportedScriptInstancesByScriptID(int scriptId)
	{
		string countId = $"GetTotalNumberOfReportedScriptInstancesByScriptID_ScriptID:{scriptId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ScriptID:{scriptId}"), countId, () => ReportedScriptDAL.GetTotalNumberOfReportedScriptInstancesByScriptID(scriptId));
	}

	public static int GetTotalNumberOfReportedScriptsByScriptID(int scriptId)
	{
		string countId = $"GetTotalNumberOfReportedScriptsByScriptID_ScriptID:{scriptId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ScriptID:{scriptId}"), countId, () => ReportedScriptDAL.GetTotalNumberOfReportedScriptsByScriptID(scriptId));
	}

	public bool Equals(ReportedScript other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(ReportedScriptDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ScriptID:{ScriptID}");
	}
}
