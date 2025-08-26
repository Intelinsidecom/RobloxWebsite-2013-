using System;
namespace Roblox.Platform.Users.Client
{
public enum UserModerationStatus
{
	Ok = 1,
	Suppressed,
	Deleted,
	[Obsolete]
	Poisoned,
	[Obsolete]
	MustValidateEmail,
	Forgotten
}

}
