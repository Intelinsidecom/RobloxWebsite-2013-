using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

internal class ParticipantTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ParticipantTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ParticipantTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("ParticipantTypes_DeleteParticipantTypeByID", ID);
	}

	internal static ParticipantTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxChat.Get("ParticipantTypes_GetParticipantTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxChat.Insert<int>("ParticipantTypes_InsertParticipantType", queryParameters);
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
		RobloxDatabase.RobloxChat.Update("ParticipantTypes_UpdateParticipantTypeByID", queryParameters);
	}

	internal static ICollection<ParticipantTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("ParticipantTypes_GetParticipantTypesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ParticipantTypeDAL> GetOrCreateParticipantType(string value)
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
		return RobloxDatabase.RobloxChat.GetOrCreate("ParticipantTypes_GetOrCreateParticipantType", BuildDAL, queryParameters);
	}
}
