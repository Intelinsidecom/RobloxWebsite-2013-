namespace Roblox.Platform.Games.PrivateServer;

public class InvalidPrivateServerStateException : PrivateServersPlatformException
{
	private readonly IPrivateServer _PrivateServer;

	public override string Message => "Private Server with ID: " + _PrivateServer.Id + " is in an invalid state and cannot be configured.";

	public InvalidPrivateServerStateException(IPrivateServer privateServer, string userFacingMessage)
		: base(userFacingMessage)
	{
		_PrivateServer = privateServer;
	}
}
