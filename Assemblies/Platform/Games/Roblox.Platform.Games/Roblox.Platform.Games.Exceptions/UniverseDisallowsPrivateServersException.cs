using Roblox.Platform.Games.PrivateServer;

namespace Roblox.Platform.Games.Exceptions;

public class UniverseDisallowsPrivateServersException : PrivateServersPlatformException
{
	public UniverseDisallowsPrivateServersException(string userFacingMessage)
		: base(userFacingMessage)
	{
	}
}
