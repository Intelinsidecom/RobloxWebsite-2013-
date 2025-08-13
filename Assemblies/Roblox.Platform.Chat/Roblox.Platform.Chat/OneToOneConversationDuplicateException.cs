using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class OneToOneConversationDuplicateException : PlatformException
{
	public OneToOneConversationDuplicateException()
	{
	}

	public OneToOneConversationDuplicateException(string message)
		: base(message)
	{
	}
}
