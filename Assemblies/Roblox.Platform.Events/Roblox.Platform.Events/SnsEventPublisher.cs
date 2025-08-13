using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;

namespace Roblox.Platform.Events;

internal class SnsEventPublisher : IEventPublisher
{
	private readonly SnsPublisher _SnsPublisher;

	private const string _SnsTopicArnTemplate = "arn:aws:sns:{0}:{1}:{2}_{3}";

	public SnsEventPublisher(string awsAccessKey, string awsSecretKey, string snsZone, string awsAccountNumber, string snsTopicName, string performanceCategory, ICounterRegistry counterRegistry)
	{
		string snsArn = $"arn:aws:sns:{snsZone}:{awsAccountNumber}:{RobloxEnvironment.Abbreviation}_{snsTopicName}";
		_SnsPublisher = new SnsPublisher(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1, snsArn, performanceCategory, counterRegistry);
	}

	public void PublishMessage(object message)
	{
		_SnsPublisher.Publish(message);
	}
}
