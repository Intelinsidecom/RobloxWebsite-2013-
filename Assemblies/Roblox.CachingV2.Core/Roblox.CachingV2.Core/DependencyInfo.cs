using System;
using Newtonsoft.Json;

namespace Roblox.CachingV2.Core;

[Serializable]
public class DependencyInfo
{
	[JsonProperty(PropertyName = "k")]
	public string Key { get; }

	[JsonProperty(PropertyName = "vt")]
	public CacheVersionToken VersionToken { get; }

	public DependencyInfo(string key, CacheVersionToken versionToken)
	{
		Key = key ?? throw new ArgumentNullException("key");
		VersionToken = versionToken;
	}
}
