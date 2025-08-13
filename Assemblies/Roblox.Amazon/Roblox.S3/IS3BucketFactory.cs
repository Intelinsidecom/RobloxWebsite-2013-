using System.Net;
using Roblox.BucketStore;

namespace Roblox.S3;

/// <summary>
/// A factory for <see cref="T:Roblox.BucketStore.IBucket" />s.
/// </summary>
public interface IS3BucketFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.BucketStore.IBucket" /> with a <see cref="F:com.amazon.s3.CallingFormat.VANITY" /> calling format.
	/// </summary>
	/// <param name="bucketName">The bucket name.</param>
	/// <param name="decompressionMethod">The <see cref="T:System.Net.DecompressionMethods" /> used for the bucket.</param>
	/// <returns><see cref="T:Roblox.BucketStore.IBucket" /></returns>
	IBucket CreateVanityBucket(string bucketName, DecompressionMethods decompressionMethod);
}
