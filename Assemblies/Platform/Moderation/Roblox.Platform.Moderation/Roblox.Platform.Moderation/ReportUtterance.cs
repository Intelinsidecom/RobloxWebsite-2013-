using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ReportUtterance : IRobloxEntity<long, ReportUtteranceDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReportUtteranceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ReportUtterance", isNullCacheable: true);

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

	internal long UtteranceID
	{
		get
		{
			return _EntityDAL.UtteranceID;
		}
		set
		{
			_EntityDAL.UtteranceID = value;
		}
	}

	internal byte? AbuseTypeID
	{
		get
		{
			return _EntityDAL.AbuseTypeID;
		}
		set
		{
			_EntityDAL.AbuseTypeID = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public long ID => _EntityDAL.ID;

	public AbuseType AbuseType
	{
		get
		{
			return AbuseType.Get(AbuseTypeID);
		}
		set
		{
			if (value == null)
			{
				AbuseTypeID = null;
			}
			else
			{
				AbuseTypeID = value.ID;
			}
		}
	}

	public Report Report => Report.Get(ReportID);

	public Utterance Utterance
	{
		get
		{
			return Utterance.Get(UtteranceID);
		}
		set
		{
			if (value == null)
			{
				UtteranceID = 0L;
			}
			else
			{
				UtteranceID = value.ID;
			}
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ReportUtterance()
	{
		_EntityDAL = new ReportUtteranceDAL();
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

	private static ReportUtterance DoGet(long id)
	{
		return EntityHelper.DoGet<long, ReportUtteranceDAL, ReportUtterance>(() => ReportUtteranceDAL.Get(id), id);
	}

	public static ReportUtterance CreateNew(Report report, Utterance utterance, AbuseType abuseType)
	{
		return CreateNew(report?.ID ?? 0, utterance, abuseType);
	}

	public static ReportUtterance CreateNew(long reportId, Utterance utterance, AbuseType abuseType)
	{
		ReportUtterance reportUtterance = new ReportUtterance();
		reportUtterance.ReportID = reportId;
		reportUtterance.Utterance = utterance;
		reportUtterance.AbuseType = abuseType;
		reportUtterance.Save();
		return reportUtterance;
	}

	internal static ICollection<KeyValuePair<byte, int>> GetHistoricalSummary(Utterance utterance)
	{
		List<KeyValuePair<byte, int>> abuseOccurrences = new List<KeyValuePair<byte, int>>();
		foreach (AbuseType abuseType in AbuseType.AllAbuseTypes)
		{
			int count = GetTotalNumberOfReportUtterancesByUtteranceAndAbuseType(utterance, abuseType);
			abuseOccurrences.Add(new KeyValuePair<byte, int>(abuseType.ID, count));
		}
		abuseOccurrences.Sort((KeyValuePair<byte, int> pair1, KeyValuePair<byte, int> pair2) => pair2.Value.CompareTo(pair1.Value));
		return abuseOccurrences;
	}

	internal static int GetTotalNumberOfReportUtterancesByUtterance(Utterance utterance)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UtteranceID:{utterance.ID}"), $"GetTotalNumberOfReportUtterancesByUtterance_UtteranceID:{utterance.ID}", () => ReportUtteranceDAL.GetTotalNumberOfReportUtterancesByUtteranceID(utterance.ID));
	}

	internal static int GetTotalNumberOfReportUtterancesByUtteranceAndAbuseType(Utterance utterance, AbuseType abuseType)
	{
		string countId = $"GetTotalNumberOfReportUtterancesByUtteranceAndAbuseType_UtteranceID:{utterance.ID}_AbuseTypeID:{abuseType.ID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UtteranceID:{utterance.ID}_AbuseTypeID:{abuseType.ID}"), countId, () => ReportUtteranceDAL.GetTotalNumberOfReportUtterancesByUtteranceIDAndAbuseTypeID(utterance.ID, abuseType.ID));
	}

	public static ReportUtterance Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static ReportUtterance Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<ReportUtterance> GetReportUtterancesByReportPaged(Report report, int startRowIndex, int maximumRows)
	{
		if (report != null)
		{
			return GetReportUtterancesByReportPaged(report.ID, startRowIndex, maximumRows);
		}
		return new List<ReportUtterance>();
	}

	public static ICollection<ReportUtterance> GetReportUtterancesByReportPaged(long reportId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetReportUtterancesByReportPaged_ReportID:{reportId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ReportID:{reportId}"), collectionId, () => ReportUtteranceDAL.GetReportUtteranceIDsByReportIDPaged(reportId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfReportUtterancesByReport(Report report)
	{
		if (report != null)
		{
			return GetTotalNumberOfReportUtterancesByReport(report.ID);
		}
		return 0;
	}

	public static int GetTotalNumberOfReportUtterancesByReport(long reportId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ReportID:{reportId}"), $"GetTotalNumberOfReportUtterancesByReport_ReportID:{reportId}", () => ReportUtteranceDAL.GetTotalNumberOfReportUtterancesByReportID(reportId));
	}

	public static ICollection<ReportUtterance> GetReportUtterancesByUtterancePaged(long utteranceID, int startRowIndex, int maximumRows)
	{
		if (utteranceID == 0L)
		{
			return new List<ReportUtterance>();
		}
		string collectionId = $"GetReportUtterancesByUtterancePaged_UtteranceID:{utteranceID}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UtteranceID:{utteranceID}"), collectionId, () => ReportUtteranceDAL.GetReportUtteranceIDsByUtteranceIDPaged(utteranceID, startRowIndex + 1, maximumRows), Get);
	}

	public void Construct(ReportUtteranceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ReportID:{ReportID}");
		yield return new StateToken($"UtteranceID:{UtteranceID}");
	}
}
