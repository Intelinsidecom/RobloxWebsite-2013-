using Roblox.Platform.Universes;

namespace Roblox.Platform.Games.PrivateServer;

public class InvalidOwnerException : PrivateServersPlatformException
{
	private readonly long _Id;

	private readonly string _Type;

	private readonly long _UserId;

	public override string Message => "User " + _UserId + " is not the owner of " + _Type + " " + _Id;

	public InvalidOwnerException(IPrivateServer privateServer, long userId, string userFacingMessage)
		: base(userFacingMessage)
	{
		_Id = privateServer.Id;
		_Type = "Private Server";
		_UserId = userId;
	}

	public InvalidOwnerException(IUniverse universe, long userId, string userFacingMessage)
		: base(userFacingMessage)
	{
		_Id = universe.Id;
		_Type = "Universe";
		_UserId = userId;
	}
}
