using Roblox.Platform.Social.Messages;
using Roblox.Properties;

namespace Roblox.Platform.Social;

internal class MessageCounter : IMessageCounter
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Social.IMessageDataAccessor" /> used to access message data.
	/// </summary>
	private readonly IMessageDataAccessor _MessageDataAccessor;

	/// <summary>
	/// Gets whether or not unread message counts should be tracked through user counters.
	/// </summary>
	private bool UseUnreadMessagesCounter => Settings.Default.UseUnreadMessagesCounter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Social.MessageCounter" /> class.
	/// </summary>
	public MessageCounter(IMessageDataAccessor messageDataAccessor = null)
	{
		_MessageDataAccessor = messageDataAccessor ?? new MessageDataAccessor();
	}

	/// <summary>
	/// Increments the unread messages user counter for the user with the given user ID.
	/// </summary>
	/// <param name="userId">The user ID of the user than the counter is for.</param>
	public void IncrementUnreadMessageCountUserCounter(long userId)
	{
		if (UseUnreadMessagesCounter)
		{
			bool wasSynced;
			UserCounter counter = UserCounter.GetOrCreate(userId, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
			if (!wasSynced)
			{
				counter.Increment();
			}
		}
	}

	/// <summary>
	/// Decrements the unread messages user counter for the user with the given user ID.
	/// </summary>
	/// <param name="userId">The user ID of the user than the counter is for.</param>
	public void DecrementUnreadMessageCountUserCounter(long userId)
	{
		if (UseUnreadMessagesCounter)
		{
			bool wasSynced;
			UserCounter counter = UserCounter.GetOrCreate(userId, UserCounterType.UnreadMessagesID, SynchronizeUnreadMessagesCounter, out wasSynced);
			if (!wasSynced)
			{
				counter.Decrement();
			}
		}
	}

	/// <summary>
	/// Synchronizes the given <see cref="T:Roblox.UserCounter" /> to exactly match the real unread
	/// messages count.
	/// </summary>
	/// <param name="unreadMessagesCounter">The <see cref="T:Roblox.UserCounter" /> to sync.</param>
	private void SynchronizeUnreadMessagesCounter(UserCounter unreadMessagesCounter)
	{
		int difference = new MessageGetter(unreadMessagesCounter.UserID, _MessageDataAccessor).GetUnreadMessagesInInboxCount() - (int)unreadMessagesCounter.Value;
		if (difference > 0)
		{
			unreadMessagesCounter.Increment(difference);
		}
		else if (difference < 0)
		{
			unreadMessagesCounter.Decrement(-1 * difference);
		}
	}
}
