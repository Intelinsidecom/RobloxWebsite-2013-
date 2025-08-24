namespace Roblox.CachingV2.Core;

public class SetEntry<TValue, TSetArgs> where TSetArgs : BasicSetArgs
{
	public string Key { get; }

	public TValue Value { get; }

	public TSetArgs SetArgs { get; }

	public SetEntry(string key, TValue value, TSetArgs setArgs)
	{
		NullChecker.ThrowIfNull(key, "key");
		NullChecker.ThrowIfNull(setArgs, "setArgs");
		Key = key;
		Value = value;
		SetArgs = setArgs;
	}
}
