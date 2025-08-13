using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Email.Delivery.Properties;

namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// An  implementation of <see cref="T:Roblox.Platform.Email.Delivery.IEmailDeliveryEventsPublisher" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Email.Delivery.IEmailDeliveryEventsPublisher" />.
internal class EmailDeliveryEventsPublisher : IEmailDeliveryEventsPublisher
{
	private SnsPublisher _SnsPublisher;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.Delivery.EmailDeliveryEventsPublisher" /> class.
	/// </summary>
	public EmailDeliveryEventsPublisher(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.EmailDeliveryEventsSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.EmailDeliveryEventsSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.EmailDeliveryEventsSnsAwsAccessKeyAndSecretCSV.Split(',');
		if (awsKeys.Length == 2)
		{
			_SnsPublisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.EmailDeliveryEventsSnsTopicArn, "Roblox.EmailDeliveryEventsPublisher", _CounterRegistry);
		}
	}

	public void Publish(EmailDeliveryEvent emailDeliveryEvent)
	{
		if (emailDeliveryEvent != null)
		{
			_SnsPublisher.Publish(emailDeliveryEvent);
		}
	}
}
