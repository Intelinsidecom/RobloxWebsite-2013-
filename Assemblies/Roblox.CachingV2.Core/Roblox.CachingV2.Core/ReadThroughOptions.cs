using System;

namespace Roblox.CachingV2.Core;

public class ReadThroughOptions<T>
{
	public static ReadThroughOptions<T> Default { get; } = new ReadThroughOptions<T>
	{
		IsCacheableFunc = null
	};


	public Func<T, bool> IsCacheableFunc { get; set; }
}
