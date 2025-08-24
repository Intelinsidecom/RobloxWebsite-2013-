namespace Roblox.Platform.Games.PrivateServer;

public class WhitelistCountExceededException : PrivateServersPlatformException
{
	private readonly long _Count;

	public override string Message => "Whitelist count exceeded, tried to have " + _Count + " players on the list";

	public WhitelistCountExceededException(long count, string userFacingMessage)
		: base(userFacingMessage)
	{
		_Count = count;
	}
}
