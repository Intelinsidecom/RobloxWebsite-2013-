using Amazon;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// A wrapper interface for AWS RegionEndpoint so that it can be faked for testing.
/// </summary>
internal interface IRobloxRegionEndpoint
{
	/// <summary>
	/// The system name of the region endpoint.
	/// </summary>
	string SystemName { get; }

	/// <summary>
	/// Gets the AWS <see cref="T:Amazon.RegionEndpoint" />.
	/// </summary>
	/// <returns>The <see cref="T:Amazon.RegionEndpoint" />.</returns>
	RegionEndpoint GetAwsRegionEndpoint();
}
