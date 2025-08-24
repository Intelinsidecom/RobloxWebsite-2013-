namespace Roblox.CachingV2.Core;

public class EntryRetrievalEventArgs : KeyedCacheEventArgs
{
	public object Value { get; }

	public EntryRetrievalEventArgs(string key, object value)
		: base(key)
	{
		Value = value;
	}
}
