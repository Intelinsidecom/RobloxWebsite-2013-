using System;

namespace Roblox.Platform.AssetOwnership;

public class PreconditionFailedException : Exception
{
	public PreconditionFailedException()
	{
	}

	public PreconditionFailedException(string message)
		: base(message)
	{
	}
}
