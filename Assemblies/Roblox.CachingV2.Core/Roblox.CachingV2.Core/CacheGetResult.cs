namespace Roblox.CachingV2.Core;

public class CacheGetResult<TValue>
{
	public bool IsFound { get; }

	public string Key { get; }

	public TValue Entry { get; }

	public CacheGetResult(string key, TValue entry)
		: this(key, entry, isFound: true)
	{
	}

	internal CacheGetResult(string key, TValue entry, bool isFound)
	{
		NullChecker.ThrowIfNull(key, "key");
		Key = key;
		IsFound = isFound;
		Entry = entry;
	}

	public static CacheGetResult<TValue> NotFound(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		return new CacheGetResult<TValue>(key, default(TValue), isFound: false);
	}
}
