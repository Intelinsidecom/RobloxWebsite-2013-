namespace Roblox.Platform.Membership;

public static class GuestFactory
{
	public static IGuest Build(long id)
	{
		return new Guest(id);
	}
}
