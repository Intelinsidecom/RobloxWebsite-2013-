using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.BillingTransactionEventPublisher.Properties;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.BillingTransactionEventPublisher;

public class BillingTransactionEventPublisher
{
	private static SnsPublisher _Publisher;

	private static ILogger _Logger;

	private string Name => "BillingTransactionEventPublisher";

	static BillingTransactionEventPublisher()
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.BillingTransactionsSnsAwsAccessKeyAndSecretKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.BillingTransactionsSnsTopicArn, InitializePublisher);
	}

	/// <summary>
	/// BillingTransactionEventPublisher constructor, which includes a logger instance and OnSnsError method delegate.
	/// </summary>
	/// <param name="logger"></param>
	public BillingTransactionEventPublisher(ILogger logger)
	{
		_Logger = logger;
		_Publisher.SnsError += OnSnsError;
	}

	private static void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.BillingTransactionsSnsAwsAccessKeyAndSecretKey.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.BillingTransactionsSnsTopicArn, "Roblox.BillingTransactionEventPublisher", StaticCounterRegistry.Instance);
	}

	private void OnSnsError(Exception ex, string message)
	{
		_Logger?.Error($"Error sending {Name} SNS: {ex}.\nMessage: {message}");
	}

	/// <summary>
	/// An instance method which will log on SNS error.
	/// </summary>
	/// <param name="message"></param>
	public void Publish(BillingTransactionMessage message)
	{
		if (Settings.Default.PublishBillingTransactionEventsToSnsEnabled)
		{
			_Publisher.Publish(message);
		}
	}

	/// <summary>
	/// Static method, using this method will not instantiate a logger, so no SNS error will be observed.
	/// </summary>
	/// <param name="message"></param>
	public static void PublishStatically(BillingTransactionMessage message)
	{
		if (Settings.Default.PublishBillingTransactionEventsToSnsEnabled)
		{
			_Publisher.Publish(message);
		}
	}
}
