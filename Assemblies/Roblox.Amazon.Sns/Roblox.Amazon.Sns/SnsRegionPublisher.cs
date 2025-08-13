using System;
using Amazon;
using Amazon.SimpleNotificationService;

namespace Roblox.Amazon.Sns;

internal class SnsRegionPublisher
{
	public IAmazonSimpleNotificationService SnsClient { get; }

	public string SnsTopicArn { get; }

	public RegionEndpoint RegionEndpoint { get; }

	internal SnsRegionPublisher(IAmazonSimpleNotificationService snsClient, string snsTopicArn, RegionEndpoint regionEndpoint)
	{
		SnsClient = snsClient ?? throw new ArgumentNullException("snsClient");
		SnsTopicArn = snsTopicArn;
		RegionEndpoint = regionEndpoint ?? throw new ArgumentNullException("regionEndpoint");
	}
}
