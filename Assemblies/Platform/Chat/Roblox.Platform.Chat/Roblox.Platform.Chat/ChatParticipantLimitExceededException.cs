using Roblox.Platform.Core;

namespace Roblox.Platform.Chat;

public class ChatParticipantLimitExceededException : PlatformException
{
	public ChatParticipantLimitExceededException(string message)
		: base(message)
	{
	}
}
