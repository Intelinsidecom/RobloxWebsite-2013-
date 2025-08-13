namespace Roblox.Platform.MembershipCore;

public static class UserIdentifierFactory
{
	public static IUserIdentifier GetUserIdentifier(long id)
	{
		return new UserIdentifier(id);
	}
}
