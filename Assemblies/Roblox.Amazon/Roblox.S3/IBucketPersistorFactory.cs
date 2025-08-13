namespace Roblox.S3;

/// <summary>
/// The Bucket Persistor Factory
/// </summary>
public interface IBucketPersistorFactory
{
	/// <summary>
	/// Gets the bucket persistor.
	/// </summary>
	/// <returns>An <see cref="T:Roblox.S3.IBucketPersistor" />.</returns>
	IBucketPersistor GetBucketPersistor();
}
