namespace Roblox.Platform.Games.PrivateServer;

public class UnknownPrivateServerException : PrivateServersPlatformException
{
	private readonly long _PrivateServerId;

	public override string Message
	{
		get
		{
			if (_PrivateServerId != 0L)
			{
				return "Private Server with ID: " + _PrivateServerId + " does not exist.";
			}
			return "";
		}
	}

	public UnknownPrivateServerException()
		: base("That VIP Server does not exist.")
	{
	}

	public UnknownPrivateServerException(long id)
		: base("That VIP Server does not exist.")
	{
		_PrivateServerId = id;
	}
}
