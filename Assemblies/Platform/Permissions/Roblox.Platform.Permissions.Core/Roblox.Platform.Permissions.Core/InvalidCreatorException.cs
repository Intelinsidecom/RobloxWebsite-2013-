using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Permissions.Core;

public class InvalidCreatorException : PlatformException
{
	private readonly long _ItemId;

	private readonly string _ItemType;

	private readonly IUserIdentifier _User;

	public override string Message => "User " + _User.Id + " is not the creator of " + _ItemType + " " + _ItemId;

	public InvalidCreatorException(ICustomList customList, IUserIdentifier user)
	{
		_ItemId = customList.Id;
		_ItemType = "CustomList";
		_User = user;
	}

	public InvalidCreatorException(IPermissionGroup permissionGroup, IUserIdentifier user)
	{
		_ItemId = permissionGroup.Id;
		_ItemType = "PermissionGroup";
		_User = user;
	}
}
