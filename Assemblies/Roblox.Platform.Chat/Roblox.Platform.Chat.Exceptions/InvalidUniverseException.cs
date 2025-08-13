using Roblox.Platform.Core;

namespace Roblox.Platform.Chat.Exceptions;

public class InvalidUniverseException : PlatformException
{
	public InvalidUniverseException(string message)
		: base(message)
	{
	}
}
