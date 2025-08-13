namespace Roblox.Platform.Groups;

public enum AcceptJoinRequestFailureReason
{
	/// <summary>
	/// Group join requester is in too many groups to join another.
	/// </summary>
	MaxGroups,
	/// <summary>
	/// Insufficient permissions to accept a group join request.
	/// </summary>
	InsufficientPermissions
}
