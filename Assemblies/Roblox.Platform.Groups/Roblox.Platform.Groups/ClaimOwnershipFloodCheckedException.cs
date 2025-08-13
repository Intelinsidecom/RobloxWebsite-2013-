using System;

namespace Roblox.Platform.Groups;

public class ClaimOwnershipFloodCheckedException : Exception
{
	internal ClaimOwnershipFloodCheckedException(string message)
		: base(message)
	{
	}
}
