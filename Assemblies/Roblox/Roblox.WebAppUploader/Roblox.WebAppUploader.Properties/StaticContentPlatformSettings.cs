using System;
using Roblox.Platform.StaticContent.Properties;

namespace Roblox.WebAppUploader.Properties;

internal class StaticContentPlatformSettings : ISettings
{
	public TimeSpan StaticContentCacheExpiry { get; } = TimeSpan.MaxValue;


	public TimeSpan StaticContentDurableCacheExpiry { get; } = TimeSpan.MaxValue;


	public string ComponentSuffix { get; set; }

	public TimeSpan ComponentSuffixMaxAge { get; } = TimeSpan.MaxValue;

}
