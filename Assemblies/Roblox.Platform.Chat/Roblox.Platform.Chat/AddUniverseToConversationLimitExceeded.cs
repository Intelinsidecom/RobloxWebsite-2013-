using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class AddUniverseToConversationLimitExceeded : PlatformException
{
	public AddUniverseToConversationLimitExceeded(string message)
		: base(message)
	{
	}
}
