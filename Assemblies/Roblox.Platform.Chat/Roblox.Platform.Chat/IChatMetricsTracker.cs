using Roblox.Platform.Devices;

namespace Roblox.Platform.Chat;

public interface IChatMetricsTracker
{
	void RecordMessageSendAttemptedWithoutRealTime(IPlatform platform);

	/// <summary>
	/// Records the event of sending a chat message to multiple users
	/// </summary>
	/// <param name="platform"></param>
	/// <param name="totalNumberOfRecipients"></param>
	void RecordChatsSent(IPlatform platform, int totalNumberOfRecipients);

	/// <summary>
	/// Records the number of chats received by users.
	/// </summary>
	/// <param name="totalNumberOfMessages"></param>
	void RecordChatsReceived(int totalNumberOfMessages);

	/// <summary>
	/// Records the number of chat messages that users are notified about receiving immediately
	/// </summary>
	/// <param name="totalNumberOfMessages"></param>
	void RecordChatsNotifiedImmediately(int totalNumberOfMessages);

	/// <summary>
	/// Records the number of chat messages that Redis was able to grab successfully
	/// </summary>
	/// <param name="totalNumberOfMessages"></param>
	void RecordChatRedisHits(int totalNumberOfMessages);

	/// <summary>
	/// Records the number of chat messages that Redis was unable to grab
	/// </summary>
	/// <param name="totalNumberOfMessages"></param>
	void RecordChatRedisMisses(int totalNumberOfMessages);

	/// <summary>
	/// Records that a user's conversations were loaded from the cache
	/// </summary>
	void RecordConversationRedisHits();

	/// <summary>
	/// Records that a user's conversations were not loaded from the cache
	/// </summary>
	void RecordConversationRedisMisses();

	/// <summary>
	/// Records that a participant was hit in the cache
	/// </summary>
	void RecordParticipantRedisHit();

	/// <summary>
	/// Records that a participant was missed in the cache
	/// </summary>
	void RecordParticipantRedisMiss();

	void RecordParticipantConversationCacheMissingEntries();

	/// <summary>
	/// Records that a chat with well known whitelisted phrase content was moderated
	/// </summary>
	void RecordWhitelistChatModerated(string chatMessage);
}
