using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Assets;

public class InvalidCreatorException : PlatformException
{
	private IAsset _Asset;

	private IUserIdentifier _User;

	public override string Message => "User " + _User.Id + " is not the creator of Asset " + _Asset.Id;

	public InvalidCreatorException(IAsset asset, IUserIdentifier user)
	{
		_Asset = asset;
		_User = user;
	}
}
