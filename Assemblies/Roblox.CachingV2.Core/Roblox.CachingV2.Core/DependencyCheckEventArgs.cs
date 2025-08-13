using System;

namespace Roblox.CachingV2.Core;

public abstract class DependencyCheckEventArgs : KeyedCacheEventArgs
{
	public string DependencyKey { get; }

	protected DependencyCheckEventArgs(string key, string dependencyKey)
		: base(key)
	{
		DependencyKey = dependencyKey ?? throw new ArgumentNullException("dependencyKey");
	}
}
