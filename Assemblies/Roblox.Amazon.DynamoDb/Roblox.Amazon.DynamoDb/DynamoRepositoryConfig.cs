using System;
using Amazon;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// DynamoDB repository configuration for <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryBase" />
/// </summary>
public sealed class DynamoRepositoryConfig : IEquatable<DynamoRepositoryConfig>
{
	/// <summary>
	/// Gets the aws access key.
	/// </summary>
	public string AwsAccessKey { get; }

	/// <summary>
	/// Gets the aws secret key.
	/// </summary>
	public string AwsSecretKey { get; }

	/// <summary>
	/// Gets the endpoint available to the AWS DynamoDB client
	/// </summary>
	public RegionEndpoint RegionEndpoint { get; }

	/// <summary>
	/// Gets the maximum amount of retries on error (if null then default value will be used).
	/// </summary>
	public int? MaxErrorRetry { get; }

	/// <summary>
	/// Gets the request timeout (if null then default value will be used).
	/// </summary>
	public TimeSpan? RequestTimeout { get; }

	/// <summary>
	/// Gets is throttle retries enabled. (if null then default value will be used).
	/// Check https://aws.amazon.com/ru/blogs/developer/retry-throttling-dotnet/ for additional information.
	/// </summary>
	public bool? IsThrottleRetriesEnabled { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfig" /> class.
	/// </summary>
	/// <param name="awsAccessKey">The AWS access key.</param>
	/// <param name="awsSecretKey">The AWS secret key.</param>
	/// <param name="awsRegionName">The name of aws region which is available to the AWS DynamoDB client</param>
	/// <param name="maxErrorRetry">The maximum amount of retries on error (if null then default value will be used).</param>
	/// <param name="requestTimeout">The request timeout (if null then default value will be used).</param>
	/// <param name="isThrottleRetriesEnabled">
	/// The is throttle retries enabled (if null then default value will be used).
	/// Check https://aws.amazon.com/ru/blogs/developer/retry-throttling-dotnet/ for additional information.
	/// </param>
	/// <exception cref="T:System.ArgumentException">
	/// Has to be a nonempty string - awsAccessKey
	/// or
	/// Has to be a nonempty string - awsSecretKey
	/// or
	/// Has to be equal or grater than zero - maxErrorRetry
	/// </exception>
	public DynamoRepositoryConfig(string awsAccessKey, string awsSecretKey, string awsRegionName, int? maxErrorRetry = null, TimeSpan? requestTimeout = null, bool? isThrottleRetriesEnabled = null)
		: this(awsAccessKey, awsSecretKey, RegionEndpoint.GetBySystemName(awsRegionName), maxErrorRetry, requestTimeout, isThrottleRetriesEnabled)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.DynamoDb.DynamoRepositoryConfig" /> class.
	/// </summary>
	/// <param name="awsAccessKey">The AWS access key.</param>
	/// <param name="awsSecretKey">The AWS secret key.</param>
	/// <param name="regionEndpoint">The endpoint available to the AWS DynamoDB client</param>
	/// <param name="maxErrorRetry">The maximum amount of retries on error (if null then default value will be used).</param>
	/// <param name="requestTimeout">The request timeout (if null then default value will be used).</param>
	/// <param name="isThrottleRetriesEnabled">
	/// The is throttle retries enabled (if null then default value will be used).
	/// Check https://aws.amazon.com/ru/blogs/developer/retry-throttling-dotnet/ for additional information.
	/// </param>
	/// <exception cref="T:System.ArgumentException">Has to be a nonempty string - awsAccessKey
	/// or
	/// Has to be a nonempty string - awsSecretKey
	/// or
	/// Has to be equal or grater than zero - maxErrorRetry</exception>
	public DynamoRepositoryConfig(string awsAccessKey, string awsSecretKey, RegionEndpoint regionEndpoint, int? maxErrorRetry = null, TimeSpan? requestTimeout = null, bool? isThrottleRetriesEnabled = null)
	{
		if (string.IsNullOrWhiteSpace(awsAccessKey))
		{
			throw new ArgumentException("Has to be a nonempty string", "awsAccessKey");
		}
		if (string.IsNullOrWhiteSpace(awsSecretKey))
		{
			throw new ArgumentException("Has to be a nonempty string", "awsSecretKey");
		}
		AwsAccessKey = awsAccessKey;
		AwsSecretKey = awsSecretKey;
		RegionEndpoint = regionEndpoint;
		MaxErrorRetry = maxErrorRetry;
		RequestTimeout = requestTimeout;
		IsThrottleRetriesEnabled = isThrottleRetriesEnabled;
	}

	/// <summary>
	/// Determines whether the specified <see cref="T:System.Object" />, is equal to this instance.
	/// </summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to compare with this instance.</param>
	/// <returns>
	///   <c>true</c> if the specified <see cref="T:System.Object" /> is equal to this instance; otherwise, <c>false</c>.
	/// </returns>
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() == GetType())
		{
			return Equals((DynamoRepositoryConfig)obj);
		}
		return false;
	}

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>
	/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
	/// </returns>
	public override int GetHashCode()
	{
		return ((((((((((AwsAccessKey?.GetHashCode() ?? 0) * 397) ^ (AwsSecretKey?.GetHashCode() ?? 0)) * 397) ^ (((object)RegionEndpoint)?.GetHashCode() ?? 0)) * 397) ^ (MaxErrorRetry?.GetHashCode() ?? 0)) * 397) ^ (RequestTimeout?.GetHashCode() ?? 0)) * 397) ^ (IsThrottleRetriesEnabled?.GetHashCode() ?? 0);
	}

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns>
	/// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
	/// </returns>
	public bool Equals(DynamoRepositoryConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (string.Equals(AwsAccessKey, other.AwsAccessKey) && string.Equals(AwsSecretKey, other.AwsSecretKey))
		{
			RegionEndpoint regionEndpoint = RegionEndpoint;
			string a = ((regionEndpoint != null) ? regionEndpoint.DisplayName : null);
			RegionEndpoint regionEndpoint2 = other.RegionEndpoint;
			if (string.Equals(a, (regionEndpoint2 != null) ? regionEndpoint2.DisplayName : null))
			{
				int? maxErrorRetry = MaxErrorRetry;
				int? maxErrorRetry2 = other.MaxErrorRetry;
				if (maxErrorRetry.GetValueOrDefault() == maxErrorRetry2.GetValueOrDefault() && maxErrorRetry.HasValue == maxErrorRetry2.HasValue && RequestTimeout == other.RequestTimeout)
				{
					return IsThrottleRetriesEnabled == other.IsThrottleRetriesEnabled;
				}
			}
		}
		return false;
	}
}
