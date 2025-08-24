using System;
using System.Collections.Concurrent;
using Roblox.Configuration;
using Roblox.Data;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Events.Properties;

namespace Roblox.Platform.Events;

public class GlobalEventsPublisher : IGlobalEventsPublisher
{
	private string _AwsAccessKey;

	private string _AwsSecret;

	private string _AwsAccountNumber;

	private string _SnsZone;

	private string _SqsZone;

	private ConcurrentDictionary<long, IEventPublisher> _Publishers;

	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	public GlobalEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger;
		_CounterRegistry = counterRegistry;
		Settings.Default.MonitorChanges((Settings s) => s.SnsZone, SetAwsCredentials);
		Settings.Default.MonitorChanges((Settings s) => s.SqsZone, SetAwsCredentials);
		Settings.Default.MonitorChanges((Settings s) => s.EventPublisherAwsAccountNumber, SetAwsCredentials);
		Settings.Default.ReadValueAndMonitorChanges((Settings s) => s.EventPublisherAwsAccessKeyAndSecretCsv, SetAwsCredentials);
	}

	private void SetAwsCredentials()
	{
		string[] awsKeys = Settings.Default.EventPublisherAwsAccessKeyAndSecretCsv.Split(',');
		if (awsKeys.Length == 2)
		{
			_AwsAccessKey = awsKeys[0];
			_AwsSecret = awsKeys[1];
			_AwsAccountNumber = Settings.Default.EventPublisherAwsAccountNumber;
			_SnsZone = Settings.Default.SnsZone;
			_SqsZone = Settings.Default.SqsZone;
			_Publishers = new ConcurrentDictionary<long, IEventPublisher>();
		}
	}

	public bool PublishMessage(object message, long eventDestinationId)
	{
		try
		{
			if (!_Publishers.TryGetValue(eventDestinationId, out var publisher))
			{
				EventCallbackLocation eventCallbackLocation = EventCallbackLocation.Get(eventDestinationId);
				if (eventCallbackLocation == null)
				{
					throw new ArgumentException("An EventCallbackUrl with that ID does not exist.");
				}
				if (eventCallbackLocation.EventCallbackLocationTypeID == EventCallbackLocationType.AmazonSns.ID)
				{
					publisher = new SnsEventPublisher(_AwsAccessKey, _AwsSecret, _SnsZone, _AwsAccountNumber, eventCallbackLocation.Value, Settings.Default.SnsPerformanceCategory, _CounterRegistry);
				}
				else
				{
					if (eventCallbackLocation.EventCallbackLocationTypeID != EventCallbackLocationType.AmazonSqs.ID)
					{
						throw new DataIntegrityException("Unrecognized EventCallbackType present in the database.");
					}
					publisher = new SqsEventPublisher(_Logger, _AwsAccessKey, _AwsSecret, _SqsZone, _AwsAccountNumber, eventCallbackLocation.Value);
				}
				_Publishers.AddOrUpdate(eventDestinationId, publisher, (long id, IEventPublisher p) => publisher);
			}
			publisher.PublishMessage(message);
			return true;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			return false;
		}
	}

	public long GetOrCreateEventDestination(EventDestinationType eventDestinationType, string eventDestinationName)
	{
		return EventCallbackLocation.GetOrCreate(eventDestinationName, (byte)eventDestinationType).ID;
	}
}
