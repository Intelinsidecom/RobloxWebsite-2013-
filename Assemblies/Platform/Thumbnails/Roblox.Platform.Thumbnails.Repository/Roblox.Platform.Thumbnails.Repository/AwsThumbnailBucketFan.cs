using System.Collections.Generic;
using Roblox.BucketStore;

namespace Roblox.Platform.Thumbnails.Repository;

internal class AwsThumbnailBucketFan : BucketFan
{
	internal AwsThumbnailBucketFan(ICollection<IBucket> buckets)
		: base(buckets)
	{
	}

	protected override IBucket GetBucket(string key)
	{
		int pos = key.LastIndexOf('.');
		if (pos > 0)
		{
			key = key.Substring(0, pos);
		}
		return base.GetBucket(key);
	}
}
