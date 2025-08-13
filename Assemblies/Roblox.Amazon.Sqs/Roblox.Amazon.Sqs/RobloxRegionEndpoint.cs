using System;
using System.Diagnostics.CodeAnalysis;
using Amazon;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// The default implemetation of <see cref="T:Roblox.Amazon.Sqs.IRobloxRegionEndpoint" />.
/// </summary>
[ExcludeFromCodeCoverage]
internal class RobloxRegionEndpoint : IRobloxRegionEndpoint
{
	private readonly RegionEndpoint _RegionEndpoint;

	/// <summary>
	/// <inheritdoc cref="P:Roblox.Amazon.Sqs.IRobloxRegionEndpoint.SystemName" />
	/// </summary>
	public string SystemName => _RegionEndpoint.SystemName;

	internal RobloxRegionEndpoint(RegionEndpoint regionEndpoint)
	{
		_RegionEndpoint = regionEndpoint ?? throw new ArgumentNullException("regionEndpoint");
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Amazon.Sqs.IRobloxRegionEndpoint.GetAwsRegionEndpoint" />
	/// </summary>
	public RegionEndpoint GetAwsRegionEndpoint()
	{
		return _RegionEndpoint;
	}
}
