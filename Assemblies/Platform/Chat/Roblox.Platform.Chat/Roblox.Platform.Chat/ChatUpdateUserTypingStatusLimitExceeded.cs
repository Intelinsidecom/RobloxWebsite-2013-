using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class ChatUpdateUserTypingStatusLimitExceeded : PlatformException
{
	public ChatUpdateUserTypingStatusLimitExceeded(string message)
		: base(message)
	{
	}
}
