namespace Roblox.CachingV2.Core;

public class DependencyAwareCachingLayer : CachingLayer<IDependencyAwareCache, DependencyAwareMetadata, DependencyAwareSetArgs>
{
	public DependencyAwareCachingLayer(IDependencyAwareCache cache)
		: base(cache)
	{
	}
}
