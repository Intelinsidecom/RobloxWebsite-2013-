using Roblox.Platform.Core;

namespace Roblox.Platform.Floodcheckers;

public class FloodCheckerFloodedException : PlatformException
{
	public new string UserFacingMessage;

	public FloodCheckerFloodedException(string userFacingMessage)
		: base("Floodchecker flooded")
	{
		UserFacingMessage = userFacingMessage;
	}
}
