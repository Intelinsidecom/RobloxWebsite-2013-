using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

/// <summary>
/// Exception thrown when a user fails to join a group.
/// </summary>
public class JoinGroupException : PlatformException
{
	public JoinGroupFailureReason Reason { get; private set; }

	internal JoinGroupException(JoinGroupFailureReason reason, long userId, long groupId)
		: base($"UserId {userId} failed to join groupId {groupId} for reason: {reason}")
	{
		Reason = reason;
	}
}
