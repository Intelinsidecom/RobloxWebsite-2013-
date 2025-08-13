namespace Roblox.CachingV2.Core;

public class CachingLayer<TCache, TMetadata, TSetArgs> where TCache : ICache<TMetadata, TSetArgs> where TMetadata : BasicMetadata where TSetArgs : BasicSetArgs
{
	public TCache Cache { get; }

	public CachingLayer(TCache cache)
	{
		NullChecker.ThrowIfNullObj(cache, "cache");
		Cache = cache;
	}
}
