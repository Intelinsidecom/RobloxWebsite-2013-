using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerCancellationTaskStatusTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PrivateServerCancellationTaskStatusTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PrivateServerCancellationTaskStatusTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("PrivateServerCancellationTaskStatusTypes_DeletePrivateServerCancellationTaskStatusTypeByID", ID);
	}

	internal static PrivateServerCancellationTaskStatusTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxGames.Get("PrivateServerCancellationTaskStatusTypes_GetPrivateServerCancellationTaskStatusTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGames.Insert<int>("PrivateServerCancellationTaskStatusTypes_InsertPrivateServerCancellationTaskStatusType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGames.Update("PrivateServerCancellationTaskStatusTypes_UpdatePrivateServerCancellationTaskStatusTypeByID", queryParameters);
	}

	internal static ICollection<PrivateServerCancellationTaskStatusTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("PrivateServerCancellationTaskStatusTypes_GetPrivateServerCancellationTaskStatusTypesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PrivateServerCancellationTaskStatusTypeDAL> GetOrCreatePrivateServerCancellationTaskStatusType(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxGames.GetOrCreate("PrivateServerCancellationTaskStatusTypes_GetOrCreatePrivateServerCancellationTaskStatusType", BuildDAL, queryParameters);
	}
}
