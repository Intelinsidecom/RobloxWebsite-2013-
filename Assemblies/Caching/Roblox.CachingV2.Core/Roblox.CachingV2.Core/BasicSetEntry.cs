namespace Roblox.CachingV2.Core;

public class BasicSetEntry<TValue> : SetEntry<TValue, BasicSetArgs>
{
	public BasicSetEntry(string key, TValue value, BasicSetArgs setArgs)
		: base(key, value, setArgs)
	{
	}
}
