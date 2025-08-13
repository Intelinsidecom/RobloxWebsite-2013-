using System;

namespace Roblox.Platform.Throttling;

public class InvalidRateLimitException : ArgumentException
{
	public InvalidRateLimitException(long rateLimitId)
		: base("Invalid RateLimitId:" + rateLimitId)
	{
	}
}
