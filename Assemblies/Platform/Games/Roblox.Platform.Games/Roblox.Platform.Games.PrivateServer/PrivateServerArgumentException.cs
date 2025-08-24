namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServerArgumentException : PrivateServersPlatformException
{
	public PrivateServerArgumentException(string userFacingMessage)
		: base(userFacingMessage)
	{
	}
}
