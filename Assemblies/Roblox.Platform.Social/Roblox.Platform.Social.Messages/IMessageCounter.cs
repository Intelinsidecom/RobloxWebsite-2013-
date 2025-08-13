namespace Roblox.Platform.Social.Messages;

internal interface IMessageCounter
{
	void IncrementUnreadMessageCountUserCounter(long userId);

	void DecrementUnreadMessageCountUserCounter(long userId);
}
