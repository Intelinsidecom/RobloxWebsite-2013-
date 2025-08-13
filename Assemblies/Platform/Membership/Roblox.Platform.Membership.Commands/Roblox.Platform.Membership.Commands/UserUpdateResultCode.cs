namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// Codes represent where the update went wrong
/// </summary>
public enum UserUpdateResultCode : byte
{
	Success,
	Unknown,
	UserNotFound,
	UsernameValidator,
	Username,
	Description,
	Birthdate
}
