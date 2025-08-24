using System;

namespace Roblox.Platform.Groups;

public class ClaimGroupUnauthorizedException : Exception
{
	internal ClaimGroupUnauthorizedException(string message)
		: base(message)
	{
	}
}
