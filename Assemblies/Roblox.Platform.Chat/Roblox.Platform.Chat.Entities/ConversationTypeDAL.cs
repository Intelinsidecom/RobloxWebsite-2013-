using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

internal class ConversationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ConversationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ConversationTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("ConversationTypes_DeleteConversationTypeByID", ID);
	}

	internal static ConversationTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxChat.Get("ConversationTypes_GetConversationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxChat.Insert<byte>("ConversationTypes_InsertConversationType", queryParameters);
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
		RobloxDatabase.RobloxChat.Update("ConversationTypes_UpdateConversationTypeByID", queryParameters);
	}

	internal static ICollection<ConversationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("ConversationTypes_GetConversationTypesByIDs", ids, BuildDAL);
	}

	internal static ConversationTypeDAL GetConversationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxChat.Lookup("ConversationTypes_GetConversationTypeByValue", BuildDAL, queryParameters);
	}
}
