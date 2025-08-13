using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Core;
using Roblox.Platform.UniverseDisplayInformation.Properties;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class SnsEventPublisher : ISnsEventPublisher<UniverseDisplayInformationChangeEvent>
{
	private readonly ILogger _Logger;

	private string _AccessKeyAndSecretCsv;

	private string _SnsTopicArn;

	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	private string Name => "UniverseDisplayInformationChangeEvent";

	public SnsEventPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.UniverseDisplayInformationChangeTopicAccessKeyIdAndSecretCsv, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.UniverseDisplayInformationChangeSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		VerifyAndCreatePublisher(_AccessKeyAndSecretCsv, _SnsTopicArn, Settings.Default.UniverseDisplayInformationChangeTopicAccessKeyIdAndSecretCsv, Settings.Default.UniverseDisplayInformationChangeSnsTopicArn);
	}

	private void VerifyAndCreatePublisher(string previousKeyAndSecret, string previousTopicArn, string newAccessKeyIdAndSecretCsv, string newSnsTopicArn)
	{
		if (_Publisher != null && previousKeyAndSecret == newAccessKeyIdAndSecretCsv && previousTopicArn == newSnsTopicArn)
		{
			return;
		}
		string initOrReinit = ((_Publisher == null) ? "Initializing" : "Re-initializing");
		_Logger.Info($"{initOrReinit} {Name}");
		string[] keyAndSecret = newAccessKeyIdAndSecretCsv.Split(',');
		if (keyAndSecret.Length != 2)
		{
			_Logger.Error($"{initOrReinit} {Name}, invalid AWS Key ID & Secret CSV.");
			return;
		}
		string keyId = keyAndSecret[0];
		string secretKey = keyAndSecret[1];
		try
		{
			_Publisher = new SnsPublisher(keyId, secretKey, RegionEndpoint.USEast1, newSnsTopicArn, $"Roblox.{Name}", _CounterRegistry);
			_Publisher.SnsError += OnSnsError;
		}
		catch (ArgumentException ex)
		{
			_Logger.Error($"{initOrReinit} {Name} failed: {ex}");
		}
		_AccessKeyAndSecretCsv = newAccessKeyIdAndSecretCsv;
		_SnsTopicArn = newSnsTopicArn;
	}

	private void OnSnsError(Exception e, string message)
	{
		_Logger.Error($"Error sending {Name} SNS: {e}.\nMessage: {message}");
	}

	public void Publish(UniverseDisplayInformationChangeEvent snsEvent)
	{
		_Publisher.Publish(snsEvent);
	}
}
