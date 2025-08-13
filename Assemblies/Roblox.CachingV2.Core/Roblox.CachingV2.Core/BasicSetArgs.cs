using System;

namespace Roblox.CachingV2.Core;

public class BasicSetArgs
{
	public static BasicSetArgs Default { get; } = new BasicSetArgs(null);


	public DateTime? Expiration { get; }

	public BasicSetArgs(DateTime? expiration)
	{
		Expiration = expiration;
	}
}
