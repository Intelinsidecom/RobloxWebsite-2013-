using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

internal class ConversationPersistenceException : PlatformException
{
	public ConversationPersistenceException(string message)
		: base(message)
	{
	}
}
