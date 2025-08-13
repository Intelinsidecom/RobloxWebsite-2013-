using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class ChatPlatformAuthorizationException : PlatformException
{
	public ChatPlatformAuthorizationException(string message)
		: base(message)
	{
	}
}
