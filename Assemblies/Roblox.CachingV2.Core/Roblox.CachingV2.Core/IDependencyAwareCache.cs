using System;

namespace Roblox.CachingV2.Core;

public interface IDependencyAwareCache : ICache<DependencyAwareMetadata, DependencyAwareSetArgs>
{
	event EventHandler<DependencyCheckFailedEventArgs> DependencyCheckFailed;

	event EventHandler<DependencyCheckSucceededEventArgs> DependencyCheckSucceeded;
}
