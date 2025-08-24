using Roblox.Platform.Core;

namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServersPlatformException : PlatformException
{
	public new string UserFacingMessage;

	public PrivateServersPlatformException(string userFacingMessage)
		: base("Private Servers Exception: " + userFacingMessage)
	{
		UserFacingMessage = userFacingMessage;
	}
}
