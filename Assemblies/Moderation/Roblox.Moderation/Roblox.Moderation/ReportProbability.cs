using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

internal class ReportProbability : IRobloxEntity<long, ReportProbabilityDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReportProbabilityDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReportProbability).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long ReportID
	{
		get
		{
			return _EntityDAL.ReportID;
		}
		set
		{
			_EntityDAL.ReportID = value;
		}
	}

	internal double Value
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

	internal bool? IsAutoClosed
	{
		get
		{
			return _EntityDAL.IsAutoClosed;
		}
		set
		{
			_EntityDAL.IsAutoClosed = value;
		}
	}

	internal bool? ModeratorConcurred
	{
		get
		{
			return _EntityDAL.ModeratorConcurred;
		}
		set
		{
			_EntityDAL.ModeratorConcurred = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReportProbability()
	{
		_EntityDAL = new ReportProbabilityDAL();
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

	internal static ReportProbability CreateNew(long reportId, double value)
	{
		ReportProbability reportProbability = new ReportProbability();
		reportProbability.ReportID = reportId;
		reportProbability.Value = value;
		reportProbability.Save();
		return reportProbability;
	}

	internal static ReportProbability Get(long id)
	{
		return EntityHelper.GetEntity<long, ReportProbabilityDAL, ReportProbability>(EntityCacheInfo, id, () => ReportProbabilityDAL.Get(id));
	}

	internal static ReportProbability GetByReportId(long reportId)
	{
		return EntityHelper.GetEntityByLookup<long, ReportProbabilityDAL, ReportProbability>(EntityCacheInfo, "ReportID:" + reportId, () => ReportProbabilityDAL.GetByReportId(reportId));
	}

	public void Construct(ReportProbabilityDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return "ReportID:" + ReportID;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
