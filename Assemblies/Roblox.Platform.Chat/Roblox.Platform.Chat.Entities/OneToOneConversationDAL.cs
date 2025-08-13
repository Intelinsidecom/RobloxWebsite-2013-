using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

internal class OneToOneConversationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChat;

	internal long ID { get; set; }

	internal long ConversationID { get; set; }

	internal int FirstParticipantTypeID { get; set; }

	internal long FirstParticipantTargetID { get; set; }

	internal int SecondParticipantTypeID { get; set; }

	internal long SecondParticipantTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static OneToOneConversationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new OneToOneConversationDAL
		{
			ID = (long)record["ID"],
			ConversationID = (long)record["ConversationID"],
			FirstParticipantTypeID = (int)record["FirstParticipantTypeID"],
			FirstParticipantTargetID = (long)record["FirstParticipantTargetID"],
			SecondParticipantTypeID = (int)record["SecondParticipantTypeID"],
			SecondParticipantTargetID = (long)record["SecondParticipantTargetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChat.Delete("OneToOneConversations_DeleteOneToOneConversationByID", ID);
	}

	internal static OneToOneConversationDAL Get(long id)
	{
		return RobloxDatabase.RobloxChat.Get("OneToOneConversations_GetOneToOneConversationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@FirstParticipantTypeID", FirstParticipantTypeID),
			new SqlParameter("@FirstParticipantTargetID", FirstParticipantTargetID),
			new SqlParameter("@SecondParticipantTypeID", SecondParticipantTypeID),
			new SqlParameter("@SecondParticipantTargetID", SecondParticipantTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxChat.Insert<long>("OneToOneConversations_InsertOneToOneConversation", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@FirstParticipantTypeID", FirstParticipantTypeID),
			new SqlParameter("@FirstParticipantTargetID", FirstParticipantTargetID),
			new SqlParameter("@SecondParticipantTypeID", SecondParticipantTypeID),
			new SqlParameter("@SecondParticipantTargetID", SecondParticipantTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxChat.Update("OneToOneConversations_UpdateOneToOneConversationByID", queryParameters);
	}

	internal static ICollection<OneToOneConversationDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxChat.MultiGet("OneToOneConversations_GetOneToOneConversationsByIDs", ids, BuildDAL);
	}

	internal static OneToOneConversationDAL GetOneToOneConversationByFirstAndSecondParticipants(int firstParticipantTypeID, long firstParticipantTargetID, int secondParticipantTypeID, long secondParticipantTargetID)
	{
		if (firstParticipantTypeID == 0)
		{
			return null;
		}
		if (firstParticipantTargetID == 0L)
		{
			return null;
		}
		if (secondParticipantTypeID == 0)
		{
			return null;
		}
		if (secondParticipantTargetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@FirstParticipantTypeID", firstParticipantTypeID),
			new SqlParameter("@FirstParticipantTargetID", firstParticipantTargetID),
			new SqlParameter("@SecondParticipantTypeID", secondParticipantTypeID),
			new SqlParameter("@SecondParticipantTargetID", secondParticipantTargetID)
		};
		return RobloxDatabase.RobloxChat.Lookup("OneToOneConversations_GetOneToOneConversationByFirstAndSecondParticipants", BuildDAL, queryParameters);
	}

	internal static OneToOneConversationDAL GetOneToOneConversationByConversationID(long conversationId)
	{
		if (conversationId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ConversationID", conversationId)
		};
		return RobloxDatabase.RobloxChat.Lookup("OneToOneConversations_GetOneToOneConversationByConversationID", BuildDAL, queryParameters);
	}
}
