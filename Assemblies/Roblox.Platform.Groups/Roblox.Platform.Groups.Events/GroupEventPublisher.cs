using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups.Events;

public class GroupEventPublisher : IGroupEventPublisher
{
	private SnsPublisher _Publisher;

	private readonly Action<Exception, string> _ErrorHandler;

	private ICounterRegistry _CounterRegistry;

	public GroupEventPublisher(Action<Exception, string> errorHandler, ICounterRegistry counterRegistry)
	{
		_ErrorHandler = errorHandler;
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.GroupEventsSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.GroupEventsSnsTopicArn, InitializePublisher);
	}

	public GroupEventPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: this(delegate(Exception e, string m)
		{
			logger.Error("Error sending SNS message: {0}  {1}", m, e);
		}, counterRegistry)
	{
	}

	public void Publish(long groupId, GroupEventType groupEventType, long? userId)
	{
		if (_Publisher == null)
		{
			throw new InvalidOperationException("Publisher failed to initialize.");
		}
		GroupEvent message = new GroupEvent
		{
			GroupEventType = groupEventType,
			GroupId = groupId,
			UserId = userId
		};
		_Publisher.Publish(message);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.GroupEventsSnsAwsAccessKeyAndSecretCSV.Split(',');
		if (awsKeys.Length == 2)
		{
			_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.GroupEventsSnsTopicArn, "Roblox.GroupEventPublisher", _CounterRegistry);
			_Publisher.SnsError += _ErrorHandler;
		}
	}
}
