namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServersOperationUnavailableException : PrivateServersPlatformException
{
	public PrivateServersOperationUnavailableException(string userFacingMessage)
		: base(userFacingMessage)
	{
	}
}
