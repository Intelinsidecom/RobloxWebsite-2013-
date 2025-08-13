using System.Net;
using com.amazon.s3;
using Roblox.S3;

namespace Roblox.Platform.Thumbnails.Repository;

internal class CompressedThumbnailBucket : Roblox.S3.Bucket
{
	internal CompressedThumbnailBucket(IBucketPersistor storageManager, string name)
		: base(storageManager, name, CallingFormat.VANITY, DecompressionMethods.GZip, neverExpires: true)
	{
	}

	protected override bool IncludeFileExtensions(Key key)
	{
		return false;
	}
}
