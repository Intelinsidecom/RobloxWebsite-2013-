using System;

namespace Roblox.Platform.AssetOwnership;

public class RevokeFailedDueToNotOwnedException : Exception
{
	public RevokeFailedDueToNotOwnedException()
	{
	}

	public RevokeFailedDueToNotOwnedException(string message)
		: base(message)
	{
	}
}
