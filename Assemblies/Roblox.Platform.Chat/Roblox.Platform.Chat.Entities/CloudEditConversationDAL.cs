using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

internal class CloudEditConversationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal long ID { get; set; }

	internal long ConversationID { get; set; }

	internal long PlaceID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static CloudEditConversationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CloudEditConversationDAL
		{
			ID = (long)record["ID"],
			ConversationID = (long)record["ConversationID"],
			PlaceID = (long)record["PlaceID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("CloudEditConversations_DeleteCloudEditConversationByID", ID);
	}

	internal static CloudEditConversationDAL Get(long id)
	{
		return RobloxDatabase.RobloxChat.Get("CloudEditConversations_GetCloudEditConversationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxChat.Insert<long>("CloudEditConversations_InsertCloudEditConversation", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxChat.Update("CloudEditConversations_UpdateCloudEditConversationByID", queryParameters);
	}

	internal static ICollection<CloudEditConversationDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("CloudEditConversations_GetCloudEditConversationsByIDs", ids, BuildDAL);
	}

	internal static CloudEditConversationDAL GetCloudEditConversationByConversationID(long conversationID)
	{
		if (conversationID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ConversationID", conversationID)
		};
		return RobloxDatabase.RobloxChat.Lookup("CloudEditConversations_GetCloudEditConversationByConversationID", BuildDAL, queryParameters);
	}

	internal static CloudEditConversationDAL GetCloudEditConversationByPlaceID(long placeID)
	{
		if (placeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeID)
		};
		return RobloxDatabase.RobloxChat.Lookup("CloudEditConversations_GetCloudEditConversationByPlaceID", BuildDAL, queryParameters);
	}
}
