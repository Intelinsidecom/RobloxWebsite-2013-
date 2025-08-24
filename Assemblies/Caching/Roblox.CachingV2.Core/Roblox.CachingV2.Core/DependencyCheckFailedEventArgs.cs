namespace Roblox.CachingV2.Core;

public class DependencyCheckFailedEventArgs : DependencyCheckEventArgs
{
	public DependencyCheckFailedEventArgs(string key, string dependencyKey)
		: base(key, dependencyKey)
	{
	}
}
