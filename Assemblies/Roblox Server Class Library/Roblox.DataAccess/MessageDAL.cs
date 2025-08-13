using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class MessageDAL
{
	public enum MessagesReceivedFilter
	{
		All,
		ExcludeInvitations,
		SystemMessages,
		Unread_ExcludeInvitations,
		Archived_ExcludeInvitations,
		Unarchived_ExcludeInvitations,
		Unread_Archived_ExcludeInvitations,
		Unread_Unarchived_ExcludeInvitations,
		Unarchived_ExcludeInvitationsAndSystem,
		Archived_ExcludeInvitationsAndSystem
	}

	private static string ConnectionString => RobloxDatabase.RobloxMessages.GetConnectionString();

	public long ID { get; set; }

	public int MessageTypeID { get; set; }

	public string Subject { get; set; } = string.Empty;


	public string Body { get; set; } = string.Empty;


	public long AuthorID { get; set; }

	public long RecipientID { get; set; }

	public bool IsSystemMessage { get; set; }

	public bool IsBroadcastMessage { get; set; }

	public bool IsRead { get; set; }

	public bool IsArchived { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[MessagesV2_DeleteMessageV2ByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (MessageTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: MessageTypeID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@MessageTypeID", MessageTypeID);
		dbHelper.SQLParameters.AddWithValue("@Subject", (Subject.Trim().Length > 0) ? ((IConvertible)Subject) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Body", (Body.Trim().Length > 0) ? ((IConvertible)Body) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@AuthorID", (AuthorID > 0) ? ((object)AuthorID) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@RecipientID", (RecipientID > 0) ? ((object)RecipientID) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@IsSystemMessage", IsSystemMessage);
		dbHelper.SQLParameters.AddWithValue("@IsBroadcastMessage", IsBroadcastMessage);
		dbHelper.SQLParameters.AddWithValue("@IsRead", IsRead ? 1 : 0);
		dbHelper.SQLParameters.AddWithValue("@IsArchived", IsArchived ? 1 : 0);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[MessagesV2_InsertMessageV2]", CommandType.StoredProcedure);
		ID = Convert.ToInt64(id.Value);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (MessageTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: MessageTypeID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@MessageTypeID", MessageTypeID);
		dbHelper.SQLParameters.AddWithValue("@Subject", (Subject.Trim().Length > 0) ? ((IConvertible)Subject) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@Body", (Body.Trim().Length > 0) ? ((IConvertible)Body) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@AuthorID", (AuthorID > 0) ? ((object)AuthorID) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@RecipientID", (RecipientID > 0) ? ((object)RecipientID) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@IsSystemMessage", IsSystemMessage);
		dbHelper.SQLParameters.AddWithValue("@IsBroadcastMessage", IsBroadcastMessage);
		dbHelper.SQLParameters.AddWithValue("@IsRead", IsRead ? 1 : 0);
		dbHelper.SQLParameters.AddWithValue("@IsArchived", IsArchived ? 1 : 0);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[MessagesV2_UpdateMessageV2ByID]", CommandType.StoredProcedure);
	}

	private static MessageDAL GetDALFromReader(SqlDataReader reader)
	{
		return new MessageDAL
		{
			ID = (long)reader["ID"],
			MessageTypeID = (int)reader["MessageTypeID"],
			Subject = (reader["Subject"].Equals(Convert.DBNull) ? string.Empty : ((string)reader["Subject"])),
			Body = (reader["Body"].Equals(Convert.DBNull) ? string.Empty : ((string)reader["Body"])),
			AuthorID = (reader["AuthorID"].Equals(Convert.DBNull) ? 0 : ((long)reader["AuthorID"])),
			RecipientID = (reader["RecipientID"].Equals(Convert.DBNull) ? 0 : ((long)reader["RecipientID"])),
			IsSystemMessage = (bool)reader["IsSystemMessage"],
			IsBroadcastMessage = (bool)reader["IsBroadcastMessage"],
			IsRead = (bool)reader["IsRead"],
			IsArchived = (bool)reader["IsArchived"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
	}

	private static MessageDAL BuildDAL(SqlDataReader reader)
	{
		MessageDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<MessageDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<MessageDAL> dals = new List<MessageDAL>();
		while (reader.Read())
		{
			MessageDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	public static ICollection<MessageDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "[dbo].[MessagesV2_GetMessagesV2ByIDs]"), ids, BuildDALCollection);
	}

	public static MessageDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[MessagesV2_GetMessageV2ByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<long> GetUserMessageIDsReceivedPagedAndSorted(long recipientId, MessagesReceivedFilter filter, string sortExpression, long startRowIndex, int maximumRows)
	{
		string storedProcedure = string.Empty;
		switch (filter)
		{
		case MessagesReceivedFilter.All:
			storedProcedure = "[dbo].[MessagesV2_GetMessageV2IDsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.Unread_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetUnreadMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetArchivedMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetUnarchivedMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.Unread_Archived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetUnreadArchivedMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetUnreadUnarchivedMessageV2IDsExcludingInvitationsByRecipientID_PagedAndSorted]";
			break;
		case MessagesReceivedFilter.SystemMessages:
			storedProcedure = "[dbo].[MessagesV2_GetSystemMessagesV2ByRecipientID_Paged]";
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem:
			storedProcedure = "[dbo].[MessagesV2_GetUnarchivedMessagesV2ExcludingInvitationsAndSystemByRecipientID_Paged]";
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem:
			storedProcedure = "[dbo].[MessagesV2_GetArchivedMessageV2IDsExcludingInvitationsAndSystemByRecipientID_Paged]";
			break;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@RecipientID", recipientId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		if (ShouldPassSortExpression(filter))
		{
			dbHelper.SQLParameters.AddWithValue("@SortExpression", (sortExpression.Trim().Length > 0) ? ((IConvertible)sortExpression) : ((IConvertible)DBNull.Value));
		}
		using SqlDataReader reader = dbHelper.ExecuteSQLReader(storedProcedure, CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	private static bool ShouldPassSortExpression(MessagesReceivedFilter filter)
	{
		if (filter == MessagesReceivedFilter.SystemMessages || (uint)(filter - 8) <= 1u)
		{
			return false;
		}
		return true;
	}

	public static int GetTotalNumberOfSentUserMessages(long authorId)
	{
		object count;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@AuthorID", authorId);
			count = dbHelper.ExecuteSQLScalar("MessagesV2_GetTotalNumberOfSentMessagesV2ExcludingInvitationsByAuthorID", CommandType.StoredProcedure);
		}
		return Convert.ToInt32(count);
	}

	public static ICollection<long> GetUserMessageIDsSentPaged(long authorId, long startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AuthorID", authorId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("MessagesV2_GetMessageV2IDsExcludingInvitationsByAuthorID_Paged", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static int GetTotalNumberOfUserMessagesReceived(long recipientId, MessagesReceivedFilter filter)
	{
		string storedProcedure = string.Empty;
		switch (filter)
		{
		case MessagesReceivedFilter.All:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfMessagesV2ByRecipientID]";
			break;
		case MessagesReceivedFilter.ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Unread_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfUnreadMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfArchivedMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfUnarchivedMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Unread_Archived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfUnreadArchivedMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Unread_Unarchived_ExcludeInvitations:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfUnreadUnarchivedMessagesV2ExcludingInvitationsByRecipientID]";
			break;
		case MessagesReceivedFilter.Unarchived_ExcludeInvitationsAndSystem:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfUnarchivedMessagesV2ExcludingInvitationsAndSystemByRecipientID]";
			break;
		case MessagesReceivedFilter.Archived_ExcludeInvitationsAndSystem:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfArchivedMessagesV2ExcludingInvitationsAndSystemByRecipientID]";
			break;
		case MessagesReceivedFilter.SystemMessages:
			storedProcedure = "[dbo].[MessagesV2_GetTotalNumberOfSystemMessagesV2ByRecipientID]";
			break;
		}
		object count;
		using (DbHelper dbHelper = new DbHelper(ConnectionString))
		{
			dbHelper.SQLParameters.AddWithValue("@RecipientID", recipientId);
			count = dbHelper.ExecuteSQLScalar(storedProcedure, CommandType.StoredProcedure);
		}
		return Convert.ToInt32(count);
	}

	public static ICollection<long> GetMessageIDs(long exclusiveStartRow, int batchSize)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ExclusiveStartID", exclusiveStartRow);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", batchSize);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[MessagesV2_GetMessageV2IDs]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}
}
