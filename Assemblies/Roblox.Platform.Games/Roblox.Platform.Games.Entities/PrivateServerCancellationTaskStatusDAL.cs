using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTaskStatusDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal long ID { get; set; }

	internal long PrivateServerCancellationTaskID { get; set; }

	internal int PrivateServerCancellationTaskStatusTypeID { get; set; }

	internal string Reason { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PrivateServerCancellationTaskStatusDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PrivateServerCancellationTaskStatusDAL
		{
			ID = (long)record["ID"],
			PrivateServerCancellationTaskID = (long)record["PrivateServerCancellationTaskID"],
			PrivateServerCancellationTaskStatusTypeID = (int)record["PrivateServerCancellationTaskStatusTypeID"],
			Reason = (string)record["Reason"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("PrivateServerCancellationTaskStatuses_DeletePrivateServerCancellationTaskStatusByID", ID);
	}

	internal static PrivateServerCancellationTaskStatusDAL Get(long id)
	{
		return RobloxDatabase.RobloxGames.Get("PrivateServerCancellationTaskStatuses_GetPrivateServerCancellationTaskStatusByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PrivateServerCancellationTaskID", PrivateServerCancellationTaskID),
			new SqlParameter("@PrivateServerCancellationTaskStatusTypeID", PrivateServerCancellationTaskStatusTypeID),
			new SqlParameter("@Reason", string.IsNullOrEmpty(Reason) ? ((IConvertible)DBNull.Value) : ((IConvertible)Reason)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGames.Insert<long>("PrivateServerCancellationTaskStatuses_InsertPrivateServerCancellationTaskStatus", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PrivateServerCancellationTaskID", PrivateServerCancellationTaskID),
			new SqlParameter("@PrivateServerCancellationTaskStatusTypeID", PrivateServerCancellationTaskStatusTypeID),
			new SqlParameter("@Reason", string.IsNullOrEmpty(Reason) ? ((IConvertible)DBNull.Value) : ((IConvertible)Reason)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGames.Update("PrivateServerCancellationTaskStatuses_UpdatePrivateServerCancellationTaskStatusByID", queryParameters);
	}

	internal static ICollection<PrivateServerCancellationTaskStatusDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("PrivateServerCancellationTaskStatuses_GetPrivateServerCancellationTaskStatusesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PrivateServerCancellationTaskStatusDAL> GetOrCreatePrivateServerCancellationTaskStatus(long privateServerCancellationTaskID)
	{
		if (privateServerCancellationTaskID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PrivateServerCancellationTaskID", privateServerCancellationTaskID)
		};
		return RobloxDatabase.RobloxGames.GetOrCreate("PrivateServerCancellationTaskStatuses_GetOrCreatePrivateServerCancellationTaskStatus", BuildDAL, queryParameters);
	}
}
