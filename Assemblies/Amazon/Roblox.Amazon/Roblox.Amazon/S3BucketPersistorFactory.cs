using System;
using Roblox.Amazon.Implementation;
using Roblox.EventLog;
using Roblox.S3;

namespace Roblox.Amazon;

public class S3BucketPersistorFactory : IBucketPersistorFactory
{
	private readonly string _AccessKey;

	private readonly string _SecretAccessKey;

	private readonly ILogger _Logger;

	public S3BucketPersistorFactory(string accessKey, string secretAccessKey, ILogger logger)
	{
		_AccessKey = accessKey ?? throw new ArgumentNullException("accessKey");
		_SecretAccessKey = secretAccessKey ?? throw new ArgumentNullException("secretAccessKey");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="accessKeySecretKeyCsv">awsaccesskey,awssecretkey</param>
	/// <param name="logger"></param>
	public S3BucketPersistorFactory(string accessKeySecretKeyCsv, ILogger logger)
	{
		if (string.IsNullOrWhiteSpace(accessKeySecretKeyCsv))
		{
			throw new ArgumentException("accessKeySecretKeyCsv");
		}
		string[] keyArray = accessKeySecretKeyCsv.Split(new char[1] { ',' });
		if (keyArray.Length != 2)
		{
			throw new ArgumentException("The accesskeySecretKeyCsv should contain only 2 elements");
		}
		if (string.IsNullOrWhiteSpace(keyArray[0]))
		{
			throw new ArgumentException("Access key cannot be null or empty");
		}
		if (string.IsNullOrWhiteSpace(keyArray[1]))
		{
			throw new ArgumentException("Access key cannot be null or empty");
		}
		_AccessKey = keyArray[0];
		_SecretAccessKey = keyArray[1];
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public IBucketPersistor GetBucketPersistor()
	{
		return new S3BucketPersistor(_AccessKey, _SecretAccessKey, _Logger);
	}

	public IBucketPersistor GetPrivateBucketPersistor()
	{
		return new S3PrivateBucketPersister(_AccessKey, _SecretAccessKey, _Logger);
	}
}
