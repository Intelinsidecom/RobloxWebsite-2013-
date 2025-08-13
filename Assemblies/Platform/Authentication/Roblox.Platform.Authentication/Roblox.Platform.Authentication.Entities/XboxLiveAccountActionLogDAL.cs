using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.Entities;

internal class XboxLiveAccountActionLogDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXbox;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal byte XboxLiveAccountActionTypeID { get; set; }

	internal string XboxLivePairwiseID { get; set; }

	internal string XboxLiveGamerTagHash { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static XboxLiveAccountActionLogDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxLiveAccountActionLogDAL
		{
			ID = (long)record["ID"],
			AccountID = Convert.ToInt64(record["AccountID"]),
			XboxLiveAccountActionTypeID = (byte)record["XboxLiveAccountActionTypeID"],
			XboxLivePairwiseID = (string)record["XboxLivePairwiseID"],
			XboxLiveGamerTagHash = (string)record["XboxLiveGamerTagHash"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXbox.Delete("XboxLiveAccountActionLogs_DeleteXboxLiveAccountActionLogByID", ID);
	}

	internal static XboxLiveAccountActionLogDAL Get(long id)
	{
		return RobloxDatabase.RobloxXbox.Get("XboxLiveAccountActionLogs_GetXboxLiveAccountActionLogByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@XboxLiveAccountActionTypeID", XboxLiveAccountActionTypeID),
			new SqlParameter("@XboxLivePairwiseID", XboxLivePairwiseID),
			new SqlParameter("@XboxLiveGamerTagHash", XboxLiveGamerTagHash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxXbox.Insert<long>("XboxLiveAccountActionLogs_InsertXboxLiveAccountActionLog", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@XboxLiveAccountActionTypeID", XboxLiveAccountActionTypeID),
			new SqlParameter("@XboxLivePairwiseID", XboxLivePairwiseID),
			new SqlParameter("@XboxLiveGamerTagHash", XboxLiveGamerTagHash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxXbox.Update("XboxLiveAccountActionLogs_UpdateXboxLiveAccountActionLogByID", queryParameters);
	}

	internal static ICollection<XboxLiveAccountActionLogDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxXbox.MultiGet("XboxLiveAccountActionLogs_GetXboxLiveAccountActionLogsByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetXboxLiveAccountActionLogIDsByAccountID(long accountId, int count, long exclusiveStartXboxLiveAccountActionLogId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartXboxLiveAccountActionLogId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartXboxLiveAccountActionLogID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartXboxLiveAccountActionLogID", exclusiveStartXboxLiveAccountActionLogId)
		};
		return RobloxDatabase.RobloxXbox.GetIDCollection<long>("XboxLiveAccountActionLogs_GetXboxLiveAccountActionLogIDsByAccountID", queryParameters);
	}

	internal static ICollection<long> GetXboxLiveAccountActionLogIDsByAccountIDAndXboxLiveAccountActionTypeID(long accountId, byte xboxLiveAccountActionTypeId, int count, long exclusiveStartXboxLiveAccountActionLogId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		if (xboxLiveAccountActionTypeId == 0)
		{
			throw new ArgumentException("Parameter 'xboxLiveAccountActionTypeID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartXboxLiveAccountActionLogId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartXboxLiveAccountActionLogID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@XboxLiveAccountActionTypeID", xboxLiveAccountActionTypeId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartXboxLiveAccountActionLogID", exclusiveStartXboxLiveAccountActionLogId)
		};
		return RobloxDatabase.RobloxXbox.GetIDCollection<long>("XboxLiveAccountActionLogs_GetXboxLiveAccountActionLogIDsByAccountIDAndXboxLiveAccountActionTypeID", queryParameters);
	}
}
