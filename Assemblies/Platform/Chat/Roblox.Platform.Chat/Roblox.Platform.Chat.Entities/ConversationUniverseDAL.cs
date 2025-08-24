using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

[Serializable]
internal class ConversationUniverseDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal long Id { get; set; }

	internal long ConversationId { get; set; }

	internal long UniverseId { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ConversationUniverseDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ConversationUniverseDAL
		{
			Id = (long)record["ID"],
			ConversationId = (long)record["ConversationID"],
			UniverseId = (long)record["UniverseID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("ConversationUniverses_DeleteConversationUniverseByID", Id);
	}

	internal static ConversationUniverseDAL Get(long id)
	{
		return RobloxDatabase.RobloxChat.Get("ConversationUniverses_GetConversationUniverseByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ConversationID", ConversationId),
			new SqlParameter("@UniverseID", UniverseId),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		Id = RobloxDatabase.RobloxChat.Insert<long>("ConversationUniverses_InsertConversationUniverse", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", Id),
			new SqlParameter("@ConversationID", ConversationId),
			new SqlParameter("@UniverseID", UniverseId),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxChat.Update("ConversationUniverses_UpdateConversationUniverseByID", queryParameters);
	}

	internal static ICollection<ConversationUniverseDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("ConversationUniverses_GetConversationUniversesByIDs", ids, BuildDAL);
	}

	internal static ConversationUniverseDAL GetConversationUniverseByConversationId(long conversationId)
	{
		if (conversationId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ConversationID", conversationId)
		};
		return RobloxDatabase.RobloxChat.Lookup("ConversationUniverses_GetConversationUniverseByConversationID", BuildDAL, queryParameters);
	}
}
