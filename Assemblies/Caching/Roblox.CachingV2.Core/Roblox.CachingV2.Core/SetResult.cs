using System;

namespace Roblox.CachingV2.Core;

public class SetResult<TMetadata> where TMetadata : BasicMetadata
{
	public string Key { get; }

	public TMetadata Metadata { get; }

	public SetResult(string key, TMetadata metadata)
	{
		Key = key ?? throw new ArgumentNullException("key");
		Metadata = metadata ?? throw new ArgumentNullException("metadata");
	}
}
