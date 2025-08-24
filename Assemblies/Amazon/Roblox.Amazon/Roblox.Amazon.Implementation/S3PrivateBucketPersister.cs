using Roblox.EventLog;
using Roblox.S3;

namespace Roblox.Amazon.Implementation;

internal class S3PrivateBucketPersister : S3BucketPersistor
{
	public S3PrivateBucketPersister(string accessKey, string secretAccessKey, ILogger logger)
		: base(accessKey, secretAccessKey, logger)
	{
		IncludeAmzAclHeader = false;
	}
}
