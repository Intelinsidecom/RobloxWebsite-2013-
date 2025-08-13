using System;

namespace Roblox.Platform.AssetOwnership;

public class RevokeStatusInvalidException : Exception
{
	public RevokeStatusInvalidException()
	{
	}

	public RevokeStatusInvalidException(string message)
		: base(message)
	{
	}
}
