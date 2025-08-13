using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class Punishment : IRobloxEntity<long, PunishmentDAL>, ICacheableObject<long>, ICacheableObject
{
	private PunishmentDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Punishment", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
		}
	}

	public long ModeratorID
	{
		get
		{
			return _EntityDAL.ModeratorID;
		}
		set
		{
			_EntityDAL.ModeratorID = value;
		}
	}

	public byte PunishmentTypeID
	{
		get
		{
			return _EntityDAL.PunishmentTypeID;
		}
		set
		{
			_EntityDAL.PunishmentTypeID = value;
		}
	}

	public PunishmentType Type
	{
		get
		{
			return PunishmentType.Get(PunishmentTypeID);
		}
		set
		{
			PunishmentTypeID = value?.ID ?? 0;
		}
	}

	public DateTime? BeginDate
	{
		get
		{
			return _EntityDAL.BeginDate;
		}
		set
		{
			_EntityDAL.BeginDate = value;
		}
	}

	public DateTime? EndDate
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

	public long? InternalNoteExpressionID
	{
		get
		{
			return _EntityDAL.InternalNoteExpressionID;
		}
		set
		{
			_EntityDAL.InternalNoteExpressionID = value;
		}
	}

	public Expression InternalNoteExpression
	{
		get
		{
			return Expression.Get(InternalNoteExpressionID);
		}
		set
		{
			if (value == null)
			{
				InternalNoteExpressionID = null;
			}
			else
			{
				InternalNoteExpressionID = value.ID;
			}
		}
	}

	public long? MessageToUserExpressionID
	{
		get
		{
			return _EntityDAL.MessageToUserExpressionID;
		}
		set
		{
			_EntityDAL.MessageToUserExpressionID = value;
		}
	}

	public Expression MessageToUserExpression
	{
		get
		{
			return Expression.Get(MessageToUserExpressionID);
		}
		set
		{
			if (value == null)
			{
				MessageToUserExpressionID = null;
			}
			else
			{
				MessageToUserExpressionID = value.ID;
			}
		}
	}

	public bool UserHasAcknowledged
	{
		get
		{
			return _EntityDAL.UserHasAcknowledged;
		}
		set
		{
			_EntityDAL.UserHasAcknowledged = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	internal byte? PunishmentReasonTypeID
	{
		get
		{
			return _EntityDAL.PunishmentReasonTypeID;
		}
		set
		{
			_EntityDAL.PunishmentReasonTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Punishment()
	{
		_EntityDAL = new PunishmentDAL();
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

	private static Punishment DoGet(long id)
	{
		return EntityHelper.DoGet<long, PunishmentDAL, Punishment>(() => PunishmentDAL.Get(id), id);
	}

	private static Punishment GetWorstPunishment(IEnumerable<Punishment> punishments)
	{
		Punishment worstPunishment = null;
		foreach (Punishment punishment in punishments)
		{
			if (worstPunishment == null || punishment.Type.SeverityRank > worstPunishment.Type.SeverityRank)
			{
				worstPunishment = punishment;
			}
		}
		return worstPunishment;
	}

	public static Punishment GetLatestUserPunishment(IEnumerable<Punishment> punishments)
	{
		return punishments?.OrderByDescending((Punishment p) => p.Updated).FirstOrDefault();
	}

	private static PunishmentType GetWorstPunishmentType(IEnumerable<Punishment> punishments)
	{
		Punishment worstPunishment = GetWorstPunishment(punishments);
		if (worstPunishment != null)
		{
			return worstPunishment.Type;
		}
		return PunishmentType.MinActivePunishment;
	}

	public static Punishment CreateNew(long userId, long moderatorId, PunishmentType punishmentType, DateTime? beginDate, DateTime? endDate, string internalNote, string messageToUser, byte? punishmentreasontypeid = null)
	{
		Expression internalNoteExpression = (string.IsNullOrEmpty(internalNote) ? null : Expression.GetOrCreate(internalNote));
		Expression messageToUserExpression = (string.IsNullOrEmpty(messageToUser) ? null : Expression.GetOrCreate(messageToUser));
		Punishment punishment = new Punishment();
		punishment.UserID = userId;
		punishment.ModeratorID = moderatorId;
		punishment.Type = punishmentType;
		punishment.BeginDate = beginDate;
		punishment.EndDate = endDate;
		punishment.InternalNoteExpression = internalNoteExpression;
		punishment.MessageToUserExpression = messageToUserExpression;
		punishment.PunishmentReasonTypeID = punishmentreasontypeid;
		punishment.Save();
		return punishment;
	}

	internal static Punishment CreateNew(long userId, long moderatorId, byte punishmentTypeId, DateTime? beginDate, DateTime? endDate, long? internalNoteExpressionId, long? messageToUserExpressionId, byte? punishmentreasontypeid = null)
	{
		Punishment punishment = new Punishment();
		punishment.UserID = userId;
		punishment.ModeratorID = moderatorId;
		punishment.PunishmentTypeID = punishmentTypeId;
		punishment.BeginDate = beginDate;
		punishment.EndDate = endDate;
		punishment.InternalNoteExpressionID = internalNoteExpressionId;
		punishment.MessageToUserExpressionID = messageToUserExpressionId;
		punishment.PunishmentReasonTypeID = punishmentreasontypeid;
		punishment.Save();
		return punishment;
	}

	public static Punishment Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Punishment Get(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return Get(id.Value);
	}

	public static ICollection<Punishment> GetActiveUserPunishmentsPaged(IPunishableUser user, int startRowIndex, int maximumRows)
	{
		return GetActiveUserPunishmentsPaged(user.ID, startRowIndex, maximumRows);
	}

	internal static ICollection<Punishment> GetActiveUserPunishmentsPaged(long userId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetActiveUserPunishmentsPaged_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, null, collectionId, () => PunishmentDAL.GetActiveUserPunishmentIDsPaged(userId, startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfActiveUserPunishments(IPunishableUser user)
	{
		return GetTotalNumberOfActiveUserPunishments(user.ID);
	}

	internal static int GetTotalNumberOfActiveUserPunishments(long userId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), $"GetTotalNumberOfActiveUserPunishments_UserID:{userId}", () => PunishmentDAL.GetTotalNumberOfActiveUserPunishments(userId));
	}

	public static int GetTotalNumberOfUserPunishments(IPunishableUser user)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{user.ID}"), $"GetTotalNumberOfUserPunishments_UserID:{user.ID}", () => PunishmentDAL.GetTotalNumberOfUserPunishments(user.ID));
	}

	public static int GetTotalNumberOfUserPunishments(long userId)
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), $"GetTotalNumberOfUserPunishments_UserID:{userId}", () => PunishmentDAL.GetTotalNumberOfUserPunishments(userId));
	}

	public static ICollection<Punishment> GetUnacknowledgedUserPunishments(IPunishableUser user)
	{
		return GetUnacknowledgedUserPunishments(user.ID);
	}

	internal static ICollection<Punishment> GetUnacknowledgedUserPunishments(long userId)
	{
		ICollection<Punishment> unacknowledgedPunishments = new List<Punishment>();
		int totalNumberOfPunishments = GetTotalNumberOfUserPunishments(userId);
		foreach (Punishment punishment in GetUserPunishmentsPaged(userId, 0, totalNumberOfPunishments))
		{
			if (punishment.PunishmentTypeID != PunishmentType.None.ID && !punishment.UserHasAcknowledged)
			{
				unacknowledgedPunishments.Add(punishment);
			}
		}
		return unacknowledgedPunishments;
	}

	public static ICollection<Punishment> GetUserPunishmentsPaged(IPunishableUser user, int startRowIndex, int maximumRows)
	{
		return GetUserPunishmentsPaged(user.ID, startRowIndex, maximumRows);
	}

	public static ICollection<Punishment> GetUserPunishmentsPaged(long userId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetUserPunishmentsPaged_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserID:{userId}"), collectionId, () => PunishmentDAL.GetUserPunishmentIDsPaged(userId, startRowIndex + 1, maximumRows), Get);
	}

	public static Punishment GetWorstActiveUserPunishment(IPunishableUser user)
	{
		int totalNumberOfPunishments = GetTotalNumberOfActiveUserPunishments(user);
		return GetWorstPunishment(GetActiveUserPunishmentsPaged(user, 0, totalNumberOfPunishments));
	}

	public static Punishment GetWorstUserPunishment(IPunishableUser user)
	{
		int totalNumberOfPunishments = GetTotalNumberOfUserPunishments(user);
		return GetWorstPunishment(GetUserPunishmentsPaged(user, 0, totalNumberOfPunishments));
	}

	public static Punishment GetWorstUnacknowledgedUserPunishment(IPunishableUser user)
	{
		return GetWorstPunishment(GetUnacknowledgedUserPunishments(user));
	}

	public static PunishmentType GetWorstUserPunishmentType(IPunishableUser user)
	{
		int totalNumberOfPunishments = GetTotalNumberOfUserPunishments(user);
		return GetWorstPunishmentType(GetUserPunishmentsPaged(user, 0, totalNumberOfPunishments));
	}

	public static PunishmentType GetWorstActiveUserPunishmentType(IPunishableUser user)
	{
		int totalNumberOfPunishments = GetTotalNumberOfActiveUserPunishments(user);
		return GetWorstPunishmentType(GetActiveUserPunishmentsPaged(user, 0, totalNumberOfPunishments));
	}

	/// <summary>
	/// Load all of the Utterances connected to this Punishment.
	/// Note that the UserID must match the Utterer.
	/// Extra Note:
	///  - If you think this needs to live somewhere better, you are completely correct.
	///  - It lives here for now because it was copy-pasted across CS and Moderation.
	/// </summary>
	/// <returns>The List of Utterances</returns>
	public IList<ReportUtterance> GetUtterancesForPunishment()
	{
		List<ReportUtterance> punishedUtterances = new List<ReportUtterance>();
		foreach (Report item in Report.GetPunishmentReportsPaged(this, 0, 100))
		{
			foreach (ReportUtterance reportUtterance in ReportUtterance.GetReportUtterancesByReportPaged(item, 0, 100))
			{
				if (reportUtterance.AbuseType != null && reportUtterance.AbuseType.ID != AbuseType.None.ID && reportUtterance.Utterance.UttererID == UserID)
				{
					punishedUtterances.Add(reportUtterance);
				}
			}
		}
		return punishedUtterances;
	}

	public void Construct(PunishmentDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"UserID:{UserID}");
	}
}
