using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTaskDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal long ID { get; set; }

	internal long PrivateServerID { get; set; }

	internal DateTime DueDate { get; set; }

	internal DateTime? LeaseExpiration { get; set; }

	internal Guid? WorkerID { get; set; }

	internal DateTime? Completed { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PrivateServerCancellationTaskDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PrivateServerCancellationTaskDAL
		{
			ID = (long)record["ID"],
			PrivateServerID = (long)record["PrivateServerID"],
			DueDate = (DateTime)record["DueDate"],
			LeaseExpiration = ((record["LeaseExpiration"] == null || record["LeaseExpiration"].Equals(DBNull.Value)) ? null : ((DateTime?)record["LeaseExpiration"])),
			WorkerID = ((record["WorkerID"] == null || record["WorkerID"].Equals(DBNull.Value)) ? null : ((Guid?)record["WorkerID"])),
			Completed = ((record["Completed"] == null || record["Completed"].Equals(DBNull.Value)) ? null : ((DateTime?)record["Completed"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("PrivateServerCancellationTasks_DeletePrivateServerCancellationTaskByID", ID);
	}

	internal static PrivateServerCancellationTaskDAL Get(long id)
	{
		return RobloxDatabase.RobloxGames.Get("PrivateServerCancellationTasks_GetPrivateServerCancellationTaskByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@DueDate", DueDate),
			new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration) : DBNull.Value),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGames.Insert<long>("PrivateServerCancellationTasks_InsertPrivateServerCancellationTask", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@DueDate", DueDate),
			new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration) : DBNull.Value),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGames.Update("PrivateServerCancellationTasks_UpdatePrivateServerCancellationTaskByID", queryParameters);
	}

	internal static ICollection<PrivateServerCancellationTaskDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("PrivateServerCancellationTasks_GetPrivateServerCancellationTasksByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> LeaseTasks(Guid workerId, int durationInMinutes, int numberOfTasks)
	{
		if (workerId == default(Guid))
		{
			return new List<long>();
		}
		if (numberOfTasks == 0)
		{
			return new List<long>();
		}
		if (durationInMinutes == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfTasks", numberOfTasks),
			new SqlParameter("@DurationInMinutes", durationInMinutes)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(RobloxDatabase.RobloxGames.GetConnectionString(), "PrivateServerCancellationTasks_LeaseTasks", queryParameters));
	}
}
