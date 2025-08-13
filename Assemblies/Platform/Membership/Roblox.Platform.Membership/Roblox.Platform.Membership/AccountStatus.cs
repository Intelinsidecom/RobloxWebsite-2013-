namespace Roblox.Platform.Membership;

public enum AccountStatus
{
	Ok = 1,
	Suppressed,
	Deleted,
	Poisoned,
	MustValidateEmail,
	Forgotten
}
