using System;

namespace Roblox.Platform.Groups;

public class ClaimGroupWithOwnerException : Exception
{
	internal ClaimGroupWithOwnerException(string message)
		: base(message)
	{
	}
}
