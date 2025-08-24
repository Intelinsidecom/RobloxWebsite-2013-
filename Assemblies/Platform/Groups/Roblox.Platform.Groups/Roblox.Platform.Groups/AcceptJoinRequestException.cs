using System;

namespace Roblox.Platform.Groups;

public class AcceptJoinRequestException : Exception
{
	public AcceptJoinRequestFailureReason Reason { get; }

	public AcceptJoinRequestException(AcceptJoinRequestFailureReason reason)
		: base($"Failed to accept group join-request: {reason}")
	{
		Reason = reason;
	}
}
