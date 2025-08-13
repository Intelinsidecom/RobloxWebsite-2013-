using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class SetConversationUniverseLimitExceeded : PlatformException
{
	public SetConversationUniverseLimitExceeded(string message)
		: base(message)
	{
	}
}
