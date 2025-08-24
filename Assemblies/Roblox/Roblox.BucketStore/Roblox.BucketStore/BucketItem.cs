using System;

namespace Roblox.BucketStore;

public struct BucketItem<T> where T : struct, IConvertible
{
	public IBucket Bucket;

	public string Key;

	public string Hash;

	public T Location;

	public BucketItem(IBucket bucket, string hash, T location)
	{
		Bucket = bucket;
		Key = bucket.DeriveKey(hash);
		Hash = hash;
		Location = location;
	}
}
