using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class InvalidCreatingUniverseException : PlatformException
{
	public InvalidCreatingUniverseException(string message)
		: base(message)
	{
	}
}
