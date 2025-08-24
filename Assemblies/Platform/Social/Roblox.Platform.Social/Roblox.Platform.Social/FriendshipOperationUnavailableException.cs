using System;

namespace Roblox.Platform.Social;

public class FriendshipOperationUnavailableException : Exception
{
	public FriendshipOperationUnavailableException(string errorMessage, Exception innerException)
		: base(errorMessage, innerException)
	{
	}
}
