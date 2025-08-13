using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

[Serializable]
internal class ConversationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal long ID { get; set; }

	internal string Title { get; set; }

	internal int CreatorTypeID { get; set; }

	internal long CreatorTargetID { get; set; }

	internal byte ConversationTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ConversationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ConversationDAL
		{
			ID = (long)record["ID"],
			Title = (string)record["Title"],
			CreatorTypeID = (int)record["CreatorTypeID"],
			CreatorTargetID = (long)record["CreatorTargetID"],
			ConversationTypeID = (byte)record["ConversationTypeID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("Conversations_DeleteConversationByID", ID);
	}

	internal static ConversationDAL Get(long id)
	{
		return RobloxDatabase.RobloxChat.Get("Conversations_GetConversationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Title", string.IsNullOrEmpty(Title) ? ((IConvertible)DBNull.Value) : ((IConvertible)Title)),
			new SqlParameter("@CreatorTypeID", CreatorTypeID),
			new SqlParameter("@CreatorTargetID", CreatorTargetID),
			new SqlParameter("@ConversationTypeID", ConversationTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxChat.Insert<long>("Conversations_InsertConversation", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Title", string.IsNullOrEmpty(Title) ? ((IConvertible)DBNull.Value) : ((IConvertible)Title)),
			new SqlParameter("@CreatorTypeID", CreatorTypeID),
			new SqlParameter("@CreatorTargetID", CreatorTargetID),
			new SqlParameter("@ConversationTypeID", ConversationTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxChat.Update("Conversations_UpdateConversationByID", queryParameters);
	}

	internal static ICollection<ConversationDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("Conversations_GetConversationsByIDs", ids, BuildDAL);
	}
}
