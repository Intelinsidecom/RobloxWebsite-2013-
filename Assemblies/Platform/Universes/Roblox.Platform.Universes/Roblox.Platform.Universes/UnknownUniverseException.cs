using Roblox.Platform.Core;

namespace Roblox.Platform.Universes;

public class UnknownUniverseException : PlatformException
{
	public UnknownUniverseException()
		: base("Unknown Universe")
	{
	}

	public UnknownUniverseException(long id)
		: base("Unknown Universe " + id)
	{
	}
}
