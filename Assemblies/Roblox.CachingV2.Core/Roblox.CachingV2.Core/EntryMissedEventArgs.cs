namespace Roblox.CachingV2.Core;

public class EntryMissedEventArgs : KeyedCacheEventArgs
{
	public EntryMissedEventArgs(string key)
		: base(key)
	{
	}
}
