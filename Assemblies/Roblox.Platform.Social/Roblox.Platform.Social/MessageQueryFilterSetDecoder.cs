namespace Roblox.Platform.Social;

/// <summary>
/// Provides methods for decoding a MessageQueryFilterSet into the name of a stored procedure.
/// </summary>
internal class MessageQueryFilterSetDecoder
{
	/// <summary>
	/// Decodes the given MessageQueryFilterSet to the name of a
	/// stored procedure. The stored procedure will perform a query 
	/// to get the desired messages for a recipient.
	/// </summary>
	/// <param name="filterSet">The MessageQueryFilterSet to decode.</param>
	/// <returns>The name of the stored procedure that will perform the 
	/// query to get the desired messages. Returns null if no corresponding 
	/// stored procedure exists.</returns>
	public string DecodeForRecipient(MessageQueryFilterSet filterSet)
	{
		string storedProcedure = null;
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			storedProcedure = "Messages_GetUnarchivedMessageIDsExcludingInvitationsByRecipientID_Paged";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly)
		{
			storedProcedure = "Messages_GetArchivedMessageIDsExcludingInvitationsAndSystemByRecipientID_Paged";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.SystemOnly)
		{
			storedProcedure = "Messages_GetUnarchivedMessageIDsExcludingInvitationsAndNonSystemByRecipientID_Paged";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.SystemOnly)
		{
			storedProcedure = "Messages_GetArchivedMessageIDsExcludingInvitationsAndNonSystemByRecipientID_Paged";
		}
		return storedProcedure;
	}

	/// <summary>
	/// Decodes the given MessageQueryFilterSet to the name of a
	/// stored procedure. The stored procedure will perform a query 
	/// to get the total number of desired messages for a recipient.
	/// </summary>
	/// <param name="filterSet">The MessageQueryFilterSet to decode.</param>
	/// <returns>The name of the stored procedure that will perform the 
	/// query to get the number of desired messages. Returns null if no 
	/// corresponding stored procedure exists.</returns>
	public string DecodeCountForRecipient(MessageQueryFilterSet filterSet)
	{
		string storedProcedure = null;
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			storedProcedure = "Messages_GetTotalNumberOfUnarchivedMessagesExcludingInvitationsByRecipientID";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.UserOnly)
		{
			storedProcedure = "Messages_GetTotalNumberOfArchivedMessagesExcludingInvitationsAndSystemByRecipientID";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.SystemOnly)
		{
			storedProcedure = "Messages_GetTotalNumberOfUnarchivedMessagesExcludingInvitationsAndNonSystemByRecipientID";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.UnarchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.UnreadOnly && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			storedProcedure = "Messages_GetTotalNumberOfUnreadUnarchivedMessagesExcludingInvitationsByRecipientID";
		}
		else if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.ArchivedOnly && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.SystemOnly)
		{
			storedProcedure = "Messages_GetTotalNumberOfArchivedMessagesExcludingInvitationsAndNonSystemByRecipientID";
		}
		return storedProcedure;
	}

	/// <summary>
	/// Decodes the given MessageQueryFilterSet to the name of a
	/// stored procedure. The stored procedure will perform a query 
	/// to get the desired messages for a sender.
	/// </summary>
	/// <param name="filterSet">The MessageQueryFilterSet to decode.</param>
	/// <returns>The name of the stored procedure that will perform the 
	/// query to get the desired messages. Returns null if no corresponding 
	/// stored procedure exists.</returns>
	public string DecodeForSender(MessageQueryFilterSet filterSet)
	{
		string storedProcedure = null;
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.Both && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			storedProcedure = "Messages_GetMessageIDsExcludingInvitationsByAuthorID_Paged";
		}
		return storedProcedure;
	}

	/// <summary>
	/// Decodes the given MessageQueryFilterSet to the name of a
	/// stored procedure. The stored procedure will perform a query 
	/// to get the total number of desired messages for a sender.
	/// </summary>
	/// <param name="filterSet">The MessageQueryFilterSet to decode.</param>
	/// <returns>The name of the stored procedure that will perform the 
	/// query to get the number of desired messages. Returns null if no 
	/// corresponding stored procedure exists.</returns>
	public string DecodeCountForSender(MessageQueryFilterSet filterSet)
	{
		string storedProcedure = null;
		if (filterSet.ArchiveFilter == MessageQueryFilterSet.ArchiveQueryFilter.Both && filterSet.ReadFilter == MessageQueryFilterSet.ReadQueryFilter.Both && filterSet.InvitationFilter == MessageQueryFilterSet.InvitationQueryFilter.NoInvitations && filterSet.SystemMessageFilter == MessageQueryFilterSet.SystemMessageQueryFilter.Both)
		{
			storedProcedure = "Messages_GetTotalNumberOfSentMessagesExcludingInvitationsByAuthorID";
		}
		return storedProcedure;
	}
}
