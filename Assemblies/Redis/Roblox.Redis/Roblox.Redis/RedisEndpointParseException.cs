using System;

namespace Roblox.Redis;

internal class RedisEndpointParseException : Exception
{
	public RedisEndpointParseException(string message)
		: base(message)
	{
	}
}
