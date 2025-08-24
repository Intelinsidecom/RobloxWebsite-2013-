namespace Roblox.CachingV2.Core;

public class DependencyAwareSetEntry<TValue> : SetEntry<TValue, DependencyAwareSetArgs>
{
	public DependencyAwareSetEntry(string key, TValue value, DependencyAwareSetArgs setArgs)
		: base(key, value, setArgs)
	{
	}
}
