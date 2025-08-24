using System;

namespace Roblox.CachingV2.Core;

public class RawSetEntry<TValue>
{
	public string Key { get; }

	public TValue Value { get; }

	public DateTime? Expiration { get; }

	public RawSetEntry(string key, TValue value, DateTime? expiration)
	{
		Key = key ?? throw new ArgumentNullException("key");
		Value = value;
		Expiration = expiration;
	}
}
