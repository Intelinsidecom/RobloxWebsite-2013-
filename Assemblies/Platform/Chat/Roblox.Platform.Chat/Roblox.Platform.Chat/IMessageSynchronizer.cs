namespace Roblox.Platform.Chat;

/// <summary>
/// This component helps us sync messages from dynamoDB onto Redis
/// </summary>
public interface IMessageSynchronizer
{
	void SynchronizeCacheWithPersistentStorage(long conversationId);
}
