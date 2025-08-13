using System.Net;
using com.amazon.s3;
using Roblox.S3;

namespace Roblox.Platform.Thumbnails.Repository;

internal class UncompressedThumbnailBucket : Roblox.S3.Bucket
{
	internal UncompressedThumbnailBucket(IBucketPersistor bucketPersistor, string name)
		: base(bucketPersistor, name, CallingFormat.VANITY, DecompressionMethods.None, neverExpires: true)
	{
	}

	protected override bool IncludeFileExtensions(Key key)
	{
		return false;
	}
}
