using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Membership.Events;

internal class AccountAgeChangeEventPublisher : IAccountAgeChangeEventPublisher
{
	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	public AccountAgeChangeEventPublisher(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		Initialize();
		Settings.Default.MonitorChanges((Settings s) => s.AccountAgeChangeEventsSnsAwsAccessKeyAndSecretCSV, Initialize);
		Settings.Default.MonitorChanges((Settings s) => s.AccountAgeChangeEventsSnsTopicArn, Initialize);
	}

	private void Initialize()
	{
		string[] awsKeys = Settings.Default.AccountAgeChangeEventsSnsAwsAccessKeyAndSecretCSV.Split(',');
		if (awsKeys.Length == 2)
		{
			_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.AccountAgeChangeEventsSnsTopicArn, "Roblox.AccountAgeChangeEventPublisher", _CounterRegistry);
		}
	}

	public void Publish(IUser user, AgeBracket previousAge)
	{
		if (Settings.Default.PublishAccountAgeChangeEventsEnabled && user != null)
		{
			AccountAgeChangeMessage messageEvent = new AccountAgeChangeMessage(user.Id, user.AgeBracket, previousAge, automaticAgeUp: false);
			_Publisher.Publish(messageEvent);
		}
	}

	public void Publish(IUser user, AgeBracket previousAgeBracket, AgeBracket newAgeBracket, bool automaticAgeUp)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		AccountAgeChangeMessage message = new AccountAgeChangeMessage(user.Id, newAgeBracket, previousAgeBracket, automaticAgeUp);
		_Publisher.Publish(message);
	}
}
