namespace Roblox.CachingV2.Core;

public class EntryRemovedEventArgs : KeyedCacheEventArgs
{
	public EntryRemovedEventArgs(string key)
		: base(key)
	{
	}
}
