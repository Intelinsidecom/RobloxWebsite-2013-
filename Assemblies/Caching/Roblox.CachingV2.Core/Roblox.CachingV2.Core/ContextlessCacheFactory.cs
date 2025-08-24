namespace Roblox.CachingV2.Core;

public class ContextlessCacheFactory : IContextCacheFactory
{
	public static ContextlessCacheFactory Instance { get; } = new ContextlessCacheFactory();


	private ContextlessCacheFactory()
	{
	}

	public IRawCache GetRawCacheForCurrentContext()
	{
		return null;
	}
}
