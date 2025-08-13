using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ReportCategoryAutoCloseProbabilityThreshold : IRobloxEntity<byte, ReportCategoryAutoCloseProbabilityThresholdDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ReportCategoryAutoCloseProbabilityThresholdDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(ReportCategoryAutoCloseProbabilityThreshold).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public byte ReportCategoryID
	{
		get
		{
			return _EntityDAL.ReportCategoryID;
		}
		internal set
		{
			_EntityDAL.ReportCategoryID = value;
		}
	}

	public double LowLoadMinimumProbability
	{
		get
		{
			return _EntityDAL.LowLoadMinimumProbability;
		}
		set
		{
			_EntityDAL.LowLoadMinimumProbability = value;
		}
	}

	public double HighLoadMinimumProbability
	{
		get
		{
			return _EntityDAL.HighLoadMinimumProbability;
		}
		set
		{
			_EntityDAL.HighLoadMinimumProbability = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		internal set
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
		internal set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReportCategoryAutoCloseProbabilityThreshold()
	{
		_EntityDAL = new ReportCategoryAutoCloseProbabilityThresholdDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
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

	internal static ReportCategoryAutoCloseProbabilityThreshold CreateNew(byte reportcategoryid, float lowloadminimumprobability, float highloadminimumprobability)
	{
		ReportCategoryAutoCloseProbabilityThreshold reportCategoryAutoCloseProbabilityThreshold = new ReportCategoryAutoCloseProbabilityThreshold();
		reportCategoryAutoCloseProbabilityThreshold.ReportCategoryID = reportcategoryid;
		reportCategoryAutoCloseProbabilityThreshold.LowLoadMinimumProbability = lowloadminimumprobability;
		reportCategoryAutoCloseProbabilityThreshold.HighLoadMinimumProbability = highloadminimumprobability;
		reportCategoryAutoCloseProbabilityThreshold.Save();
		return reportCategoryAutoCloseProbabilityThreshold;
	}

	internal static ReportCategoryAutoCloseProbabilityThreshold Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ReportCategoryAutoCloseProbabilityThresholdDAL, ReportCategoryAutoCloseProbabilityThreshold>(EntityCacheInfo, id, () => ReportCategoryAutoCloseProbabilityThresholdDAL.Get(id));
	}

	public static ReportCategoryAutoCloseProbabilityThreshold GetByReportCategoryID(byte reportCategoryID)
	{
		return EntityHelper.GetEntityByLookup<byte, ReportCategoryAutoCloseProbabilityThresholdDAL, ReportCategoryAutoCloseProbabilityThreshold>(EntityCacheInfo, $"ReportCategoryID:{reportCategoryID}", () => ReportCategoryAutoCloseProbabilityThresholdDAL.GetReportCategoryAutoCloseProbabilityThresholdByReportCategoryID(reportCategoryID));
	}

	public void Construct(ReportCategoryAutoCloseProbabilityThresholdDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ReportCategoryID:{ReportCategoryID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
