using System;

namespace Roblox.CachingV2.Core;

public class MetadataCacheGetResult<TValue, TMetadata> : CacheGetResult<TValue> where TMetadata : BasicMetadata
{
	public TMetadata Metadata { get; }

	public MetadataCacheGetResult(string key, TValue entry, TMetadata metadata)
		: this(key, entry, isFound: true, metadata)
	{
	}

	internal MetadataCacheGetResult(string key, TValue entry, bool isFound, TMetadata metadata)
		: base(key, entry, isFound)
	{
		if (isFound && metadata == null)
		{
			throw new ArgumentNullException(string.Format("Argument '{0}' must have a value if '{1}' is true.", "metadata", "isFound"));
		}
		Metadata = metadata;
	}

	public new static MetadataCacheGetResult<TValue, TMetadata> NotFound(string key)
	{
		NullChecker.ThrowIfNull(key, "key");
		return new MetadataCacheGetResult<TValue, TMetadata>(key, default(TValue), isFound: false, null);
	}

	public static MetadataCacheGetResult<TValue, TMetadata> ConstructFromBase(CacheGetResult<TValue> baseResult, TMetadata metadata)
	{
		NullChecker.ThrowIfNull(baseResult, "baseResult");
		return new MetadataCacheGetResult<TValue, TMetadata>(baseResult.Key, baseResult.Entry, baseResult.IsFound, metadata);
	}
}
