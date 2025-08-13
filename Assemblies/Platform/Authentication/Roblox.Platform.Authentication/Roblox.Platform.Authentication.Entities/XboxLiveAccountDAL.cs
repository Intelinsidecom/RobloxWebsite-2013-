using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.Entities;

public class XboxLiveAccountDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXboxLiveAccounts;

	internal int ID { get; set; }

	internal long AccountID { get; set; }

	internal string XboxLivePairwiseID { get; set; }

	internal string XboxLiveGamerTagHash { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static XboxLiveAccountDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxLiveAccountDAL
		{
			ID = (int)record["ID"],
			AccountID = Convert.ToInt64(record["AccountID"]),
			XboxLivePairwiseID = (string)record["XboxLivePairwiseID"],
			XboxLiveGamerTagHash = (string)record["XboxLiveGamerTagHash"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXboxLiveAccounts.Delete("XboxLiveAccounts_DeleteXboxLiveAccountByID", ID);
	}

	internal static XboxLiveAccountDAL Get(int id)
	{
		return RobloxDatabase.RobloxXboxLiveAccounts.Get("XboxLiveAccounts_GetXboxLiveAccountByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@XboxLivePairwiseID", XboxLivePairwiseID),
			new SqlParameter("@XboxLiveGamerTagHash", string.IsNullOrEmpty(XboxLiveGamerTagHash) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxLiveGamerTagHash)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxXboxLiveAccounts.Insert<int>("XboxLiveAccounts_InsertXboxLiveAccount", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@XboxLivePairwiseID", XboxLivePairwiseID),
			new SqlParameter("@XboxLiveGamerTagHash", string.IsNullOrEmpty(XboxLiveGamerTagHash) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxLiveGamerTagHash)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxXboxLiveAccounts.Update("XboxLiveAccounts_UpdateXboxLiveAccountByID", queryParameters);
	}

	internal static ICollection<XboxLiveAccountDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxXboxLiveAccounts.MultiGet("XboxLiveAccounts_GetXboxLiveAccountsByIDs", ids, BuildDAL);
	}

	internal static XboxLiveAccountDAL GetXboxLiveAccountByAccountID(long accountID)
	{
		if (accountID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountID)
		};
		return RobloxDatabase.RobloxXboxLiveAccounts.Lookup("XboxLiveAccounts_GetXboxLiveAccountByAccountID", BuildDAL, queryParameters);
	}

	internal static XboxLiveAccountDAL GetXboxLiveAccountByXboxLivePairwiseID(string xboxLivePairwiseID)
	{
		if (string.IsNullOrEmpty(xboxLivePairwiseID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@XboxLivePairwiseID", xboxLivePairwiseID)
		};
		return RobloxDatabase.RobloxXboxLiveAccounts.Lookup("XboxLiveAccounts_GetXboxLiveAccountByXboxLivePairwiseID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetXboxLiveAccountIDsByXboxLiveGamerTagHash(string xboxLiveGamerTagHash, int count, int exclusiveStartXboxLiveAccountId)
	{
		if (string.IsNullOrEmpty(xboxLiveGamerTagHash))
		{
			throw new ArgumentException("Parameter 'xboxLiveGamerTagHash' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartXboxLiveAccountId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartXboxLiveAccountID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@XboxLiveGamerTagHash", string.IsNullOrEmpty(xboxLiveGamerTagHash) ? ((IConvertible)DBNull.Value) : ((IConvertible)xboxLiveGamerTagHash)),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartXboxLiveAccountID", exclusiveStartXboxLiveAccountId)
		};
		return RobloxDatabase.RobloxXboxLiveAccounts.GetIDCollection<int>("XboxLiveAccounts_GetXboxLiveAccountIDsByXboxLiveGamerTagHash", queryParameters);
	}
}
