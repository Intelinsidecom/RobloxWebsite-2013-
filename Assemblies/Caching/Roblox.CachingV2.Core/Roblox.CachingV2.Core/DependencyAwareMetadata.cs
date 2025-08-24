namespace Roblox.CachingV2.Core;

public class DependencyAwareMetadata : BasicMetadata
{
	public CacheVersionToken VersionToken { get; }

	public DependencyAwareMetadata(CacheVersionToken versionToken)
	{
		NullChecker.ThrowIfNullObj(versionToken, "versionToken");
		VersionToken = versionToken;
	}
}
