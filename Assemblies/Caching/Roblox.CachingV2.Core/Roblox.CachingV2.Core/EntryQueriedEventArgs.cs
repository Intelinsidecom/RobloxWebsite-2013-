namespace Roblox.CachingV2.Core;

public class EntryQueriedEventArgs : KeyedCacheEventArgs
{
	public EntryQueriedEventArgs(string key)
		: base(key)
	{
	}
}
