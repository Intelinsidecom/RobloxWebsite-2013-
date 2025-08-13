using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

public class LoginFailureLimitExceededException : PlatformException
{
	public LoginFailureLimitExceededException(string accountName)
		: base($"Target account {accountName} has exceeded the login attempts")
	{
	}
}
