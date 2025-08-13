namespace Roblox.Platform.Membership.UserDataAuditCore;

public interface IAuditCompositeEntry
{
	long Id { get; }

	string ActorName { get; set; }
}
