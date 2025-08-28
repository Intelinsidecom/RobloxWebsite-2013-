namespace Roblox.Platform.Membership;

public static class BcMembership
{
    public static IBcMembershipService Service { get; set; } = new BcMembershipService();
}
