using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class MatchmakingContextDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGames;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static MatchmakingContextDAL BuildDAL(IDictionary<string, object> record)
	{
		return new MatchmakingContextDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGames.Delete("MatchmakingContexts_DeleteMatchmakingContextByID", ID);
	}

	internal static MatchmakingContextDAL Get(int id)
	{
		return RobloxDatabase.RobloxGames.Get("MatchmakingContexts_GetMatchmakingContextByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxGames.Insert<int>("MatchmakingContexts_InsertMatchmakingContext", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxGames.Update("MatchmakingContexts_UpdateMatchmakingContextByID", queryParameters);
	}

	internal static ICollection<MatchmakingContextDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxGames.MultiGet("MatchmakingContexts_GetMatchmakingContextsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<MatchmakingContextDAL> GetOrCreateMatchmakingContext(string value)
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
		return RobloxDatabase.RobloxGames.GetOrCreate("MatchmakingContexts_GetOrCreateMatchmakingContext", BuildDAL, queryParameters);
	}

	internal static MatchmakingContextDAL GetMatchmakingContextByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxGames.Lookup("MatchmakingContexts_GetMatchmakingContextByValue", BuildDAL, queryParameters);
	}
}
