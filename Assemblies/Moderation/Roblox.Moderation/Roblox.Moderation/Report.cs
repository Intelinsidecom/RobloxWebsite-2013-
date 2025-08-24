using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class Report : IRobloxEntity<long, ReportDAL>, ICacheableObject<long>, ICacheableObject
{
	private ReportDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Report", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SubmitterID
	{
		get
		{
			return _EntityDAL.SubmitterID;
		}
		set
		{
			_EntityDAL.SubmitterID = value;
		}
	}

	public long AllegedAbuserID
	{
		get
		{
			return _EntityDAL.AllegedAbuserID;
		}
		set
		{
			_EntityDAL.AllegedAbuserID = value;
		}
	}

	[Obsolete]
	public long? ContextUrlID
	{
		get
		{
			return _EntityDAL.ContextUrlID;
		}
		set
		{
			_EntityDAL.ContextUrlID = value;
		}
	}

	public long? ReportContextID
	{
		get
		{
			return _EntityDAL.ReportContextID;
		}
		set
		{
			_EntityDAL.ReportContextID = value;
		}
	}

	public long? CommentExpressionID
	{
		get
		{
			return _EntityDAL.CommentExpressionID;
		}
		set
		{
			_EntityDAL.CommentExpressionID = value;
		}
	}

	public Expression CommentExpression
	{
		get
		{
			return Expression.Get(CommentExpressionID);
		}
		set
		{
			if (value == null)
			{
				CommentExpressionID = null;
			}
			else
			{
				CommentExpressionID = value.ID;
			}
		}
	}

	public long? PunishmentID
	{
		get
		{
			return _EntityDAL.PunishmentID;
		}
		set
		{
			_EntityDAL.PunishmentID = value;
		}
	}

	public Punishment Punishment
	{
		get
		{
			return Punishment.Get(PunishmentID);
		}
		set
		{
			if (value == null)
			{
				PunishmentID = null;
			}
			else
			{
				PunishmentID = value.ID;
			}
		}
	}

	public IReportContext Context
	{
		get
		{
			if (ReportContextID.HasValue)
			{
				ReportContext reportContext = ReportContext.Get(ReportContextID.Value);
				if (reportContext != null)
				{
					if (reportContext.ReportContextTypeID == ReportContextType.WebsiteContext.ID)
					{
						return WebsiteReportContext.Get(reportContext.ReportContextID);
					}
					if (reportContext.ReportContextTypeID == ReportContextType.InGameContext.ID)
					{
						return InGameReportContext.Get(reportContext.ReportContextID);
					}
				}
			}
			return null;
		}
	}

	public byte? ReportCategoryID
	{
		get
		{
			return _EntityDAL.ReportCategoryID;
		}
		set
		{
			_EntityDAL.ReportCategoryID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Report()
	{
		_EntityDAL = new ReportDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	private static Report DoGet(long id)
	{
		return EntityHelper.DoGet<long, ReportDAL, Report>(() => ReportDAL.Get(id), id);
	}

	internal static Report CreateNew(long submitterId, Expression submitterComment, long allegedAbuserId, long? reportContextID, byte? reportCategoryID = null)
	{
		Report report = new Report();
		report.SubmitterID = submitterId;
		report.CommentExpression = submitterComment;
		report.AllegedAbuserID = allegedAbuserId;
		report.ReportContextID = reportContextID;
		report.ReportCategoryID = reportCategoryID ?? new byte?(ReportCategory.OtherRuleViolationID);
		report.Save();
		return report;
	}

	internal static Report CreateNew(long submitterId, Expression submitterComment, long allegedAbuserId, string contextUrl, byte? reportCategoryID = null)
	{
		ReportContext reportContext = null;
		if (!string.IsNullOrEmpty(contextUrl))
		{
			reportContext = ReportContext.GetOrCreate(WebsiteReportContext.GetOrCreate(contextUrl).ID, ReportContextType.WebsiteContext.ID);
		}
		return CreateNew(submitterId, submitterComment, allegedAbuserId, reportContext?.ID, reportCategoryID);
	}

	internal static Report CreateNew(IReportable reportableItem)
	{
		long? contextID = null;
		if (reportableItem != null)
		{
			IReportContext inputReportContext = reportableItem.ReportContext;
			if (inputReportContext is IWebsiteReportContext)
			{
				IWebsiteReportContext websiteContext = (IWebsiteReportContext)inputReportContext;
				if (!string.IsNullOrEmpty(websiteContext.ContextUrl))
				{
					ReportContext reportContext2 = ReportContext.GetOrCreate(WebsiteReportContext.GetOrCreate(websiteContext.ContextUrl).ID, ReportContextType.WebsiteContext.ID);
					contextID = reportContext2.ID;
				}
			}
			else if (inputReportContext is IInGameReportContext)
			{
				IInGameReportContext inGameReportContext = (IInGameReportContext)inputReportContext;
				ReportContext reportContext = ReportContext.GetOrCreate(InGameReportContext.GetOrCreate(inGameReportContext.PlaceID, inGameReportContext.UniverseID, inGameReportContext.GameInstanceID).ID, ReportContextType.InGameContext.ID);
				contextID = reportContext.ID;
			}
		}
		Expression submitterComment = (string.IsNullOrEmpty(reportableItem.CommentText) ? null : Expression.GetOrCreate(reportableItem.CommentText));
		return CreateNew(reportableItem.SubmitterID, submitterComment, reportableItem.AllegedAbuserID, contextID, reportableItem.ReportCategoryID);
	}

	public static Report Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Report Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<Report> GetOpenReportsByAllegedAbuserID(long allegedAbuserId)
	{
		string collectionId = $"GetOpenReportsByAllegedAbuserID_AllegedAbuserID:{allegedAbuserId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "AllegedAbuserID:" + allegedAbuserId), collectionId, () => ReportDAL.GetOpenReportIDsByAllegedAbuserID(allegedAbuserId), Get);
	}

	public static ICollection<Report> GetOpenReportsBySubmitterID(long submitterId)
	{
		string collectionId = $"GetOpenReportsBySubmitterID_SubmitterID:{submitterId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "SubmitterID:" + submitterId), collectionId, () => ReportDAL.GetOpenReportIDsBySubmitterID(submitterId), Get);
	}

	public static ICollection<Report> GetPunishmentReportsPaged(Punishment punishment, int startRowIndex, int maximumRows)
	{
		return GetPunishmentReportsPaged(punishment.ID, startRowIndex, maximumRows);
	}

	public static ICollection<Report> GetPunishmentReportsPaged(long punishmentId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPunishmentReportsPaged_PunishmentID:{punishmentId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "PunishmentID:" + punishmentId), collectionId, () => ReportDAL.GetPunishmentReportIDsPaged(punishmentId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfPunishmentReports(Punishment punishment)
	{
		return GetTotalNumberOfPunishmentReports(punishment.ID);
	}

	public static int GetTotalNumberOfPunishmentReports(long punishmentId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PunishmentID:{punishmentId}"), "GetTotalNumberOfPunishmentReports_PunishmentID:" + punishmentId, () => ReportDAL.GetTotalNumberOfPunishmentReports(punishmentId));
	}

	public void Construct(ReportDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("SubmitterID:" + SubmitterID);
		yield return new StateToken("AllegedAbuserID:" + AllegedAbuserID);
		if (PunishmentID.HasValue)
		{
			yield return new StateToken("PunishmentID:" + PunishmentID.Value);
		}
	}
}
