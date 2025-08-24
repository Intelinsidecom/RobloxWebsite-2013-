namespace Roblox.Platform.Social;

/// <summary>
/// Provides methods for determining if a user has permission to access an existing message
/// </summary>
public class MessagePermission
{
	/// <summary>
	/// The IMessageDataAccessor used to get message data.
	/// </summary>
	private readonly IMessageDataAccessor _MessageDataAccessor;

	/// <summary>
	/// Returns the message id to check permissions for
	/// </summary>
	public long Message { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Social.MessagePermission" /> class.
	/// </summary>
	/// <param name="messageId">The message ID of the message to get permissions for.</param>
	/// <param name="messageDataAccessor">The IMessageDataAccessor used to access message data. Uses 
	/// a <see cref="T:Roblox.Platform.Social.MessageDataAccessor" /> if left null.</param>
	public MessagePermission(long messageId, IMessageDataAccessor messageDataAccessor = null)
	{
		Message = messageId;
		_MessageDataAccessor = messageDataAccessor ?? new MessageDataAccessor();
	}

	/// <summary>
	/// Determines whether user has permission to access the specified message.
	/// </summary>
	/// <param name="userId">The user identifier to check.</param>
	/// <returns>False if the user not the sender or receiver of the message or 
	///     if the message can not be found, true if they are the sender or receiver.</returns>
	public bool HasPermissionToAccess(long userId)
	{
		Message message = _MessageDataAccessor.GetByMessageId(Message);
		if (message == null || (message.RecipientId != userId && message.AuthorId != userId))
		{
			return false;
		}
		return true;
	}
}
