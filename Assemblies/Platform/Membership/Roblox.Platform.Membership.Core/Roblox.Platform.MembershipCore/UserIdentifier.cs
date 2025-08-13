namespace Roblox.Platform.MembershipCore;

public class UserIdentifier : IUserIdentifier, IVisitorIdentifier
{
	public long Id { get; }

	public UserIdentifier(long id)
	{
		Id = id;
	}
}
