namespace Roblox.CachingV2.Core;

public class DependencyCheckSucceededEventArgs : DependencyCheckEventArgs
{
	public DependencyCheckSucceededEventArgs(string key, string dependencyKey)
		: base(key, dependencyKey)
	{
	}
}
