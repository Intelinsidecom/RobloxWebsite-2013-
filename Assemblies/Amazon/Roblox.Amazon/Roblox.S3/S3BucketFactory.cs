using System;
using System.Net;
using com.amazon.s3;
using Roblox.BucketStore;

namespace Roblox.S3;

/// <inheritdoc cref="T:Roblox.S3.IS3BucketFactory" />
public class S3BucketFactory : IS3BucketFactory
{
	private readonly IBucketPersistor _BucketPersistor;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.S3.S3BucketFactory" />.
	/// </summary>
	/// <param name="bucketPersistor">An <see cref="T:Roblox.S3.IBucketPersistor" />.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="bucketPersistor" /></exception>
	public S3BucketFactory(IBucketPersistor bucketPersistor)
	{
		_BucketPersistor = bucketPersistor ?? throw new ArgumentNullException("bucketPersistor");
	}

	/// <inheritdoc cref="M:Roblox.S3.IS3BucketFactory.CreateVanityBucket(System.String,System.Net.DecompressionMethods)" />
	public IBucket CreateVanityBucket(string bucketName, DecompressionMethods decompressionMethod)
	{
		return new Bucket(_BucketPersistor, bucketName, CallingFormat.VANITY, decompressionMethod, neverExpires: true);
	}
}
