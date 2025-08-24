using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Chat.Entities;

[Serializable]
internal class ConversationParticipantDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxChatParticipants;

	internal long ID { get; set; }

	internal long ConversationID { get; set; }

	internal int ParticipantTypeID { get; set; }

	internal long ParticipantTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ConversationParticipantDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ConversationParticipantDAL
		{
			ID = (long)record["ID"],
			ConversationID = (long)record["ConversationID"],
			ParticipantTypeID = (int)record["ParticipantTypeID"],
			ParticipantTargetID = (long)record["ParticipantTargetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxChatParticipants.Delete("ConversationParticipants_DeleteConversationParticipantByID", ID);
	}

	internal static ConversationParticipantDAL Get(long id)
	{
		return RobloxDatabase.RobloxChatParticipants.Get("ConversationParticipants_GetConversationParticipantByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@ParticipantTypeID", ParticipantTypeID),
			new SqlParameter("@ParticipantTargetID", ParticipantTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxChatParticipants.Insert<long>("ConversationParticipants_InsertConversationParticipant", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ConversationID", ConversationID),
			new SqlParameter("@ParticipantTypeID", ParticipantTypeID),
			new SqlParameter("@ParticipantTargetID", ParticipantTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxChatParticipants.Update("ConversationParticipants_UpdateConversationParticipantByID", queryParameters);
	}

	internal static ICollection<ConversationParticipantDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxChatParticipants.MultiGet("ConversationParticipants_GetConversationParticipantsByIDs", ids, BuildDAL);
	}

	internal static ConversationParticipantDAL GetConversationParticipantByConversationIDParticipantTypeIDAndParticipantTargetID(long conversationID, int participantTypeID, long participantTargetID)
	{
		if (conversationID == 0L)
		{
			return null;
		}
		if (participantTypeID == 0)
		{
			return null;
		}
		if (participantTargetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ConversationID", conversationID),
			new SqlParameter("@ParticipantTypeID", participantTypeID),
			new SqlParameter("@ParticipantTargetID", participantTargetID)
		};
		return RobloxDatabase.RobloxChatParticipants.Lookup("ConversationParticipants_GetConversationParticipantByConversationIDParticipantTypeIDAndParticipantTargetID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetConversationParticipantIDsByConversationIDPaged(long conversationID, long startRowIndex, long maximumRows)
	{
		if (conversationID == 0L)
		{
			throw new ArgumentException("Parameter 'conversationID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ConversationID", conversationID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxChatParticipants.GetIDCollection<long>("ConversationParticipants_GetConversationParticipantIDsByConversationID_Paged", queryParameters);
	}

	internal static ICollection<long> GetConversationParticipantIDsByParticipantTypeIDAndParticipantTargetIDPaged(int participantTypeID, long participantTargetID, long startRowIndex, long maximumRows)
	{
		if (participantTypeID == 0)
		{
			throw new ArgumentException("Parameter 'participantTypeID' cannot be null, empty or the default value.");
		}
		if (participantTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'participantTargetID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ParticipantTypeID", participantTypeID),
			new SqlParameter("@ParticipantTargetID", participantTargetID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxChatParticipants.GetIDCollection<long>("ConversationParticipants_GetConversationParticipantIDsByParticipantTypeIDAndParticipantTargetID_Paged", queryParameters);
	}
}
