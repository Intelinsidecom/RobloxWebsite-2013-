namespace Roblox.CachingV2.Core;

public interface IContextCacheFactory
{
	IRawCache GetRawCacheForCurrentContext();
}
