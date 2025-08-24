using System.Threading;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Events.Properties;

namespace Roblox.Platform.Events;

internal class SqsEventPublisher : IEventPublisher
{
	private SqsBatchSender _SqsPublisher;

	private readonly string _SqsZone;

	private readonly string _AwsAccountNumber;

	private readonly string _AwsAccessKey;

	private readonly string _AwsSecretKey;

	private readonly string _SqsName;

	private const string _SqsUrlTemplate = "https://sqs.{0}.amazonaws.com/{1}/{2}_{3}";

	private readonly ILogger _Logger;

	public SqsEventPublisher(ILogger logger, string awsAccessKey, string awsSecretKey, string sqsZone, string awsAccountNumber, string sqsName)
	{
		_Logger = logger;
		_AwsAccessKey = awsAccessKey;
		_AwsSecretKey = awsSecretKey;
		_SqsZone = sqsZone;
		_AwsAccountNumber = awsAccountNumber;
		_SqsName = sqsName;
		Settings.Default.PropertyChanged += delegate
		{
			if (_SqsPublisher != null)
			{
				_SqsPublisher.Stop();
				_SqsPublisher = null;
			}
		};
	}

	public void PublishMessage(object message)
	{
		LazyInitializer.EnsureInitialized(ref _SqsPublisher, delegate
		{
			string baseQueueUrl = $"https://sqs.{_SqsZone}.amazonaws.com/{_AwsAccountNumber}/{RobloxEnvironment.Abbreviation}_{_SqsName}";
			SqsBatchSender sqsBatchSender = new SqsBatchSender(_AwsAccessKey, _AwsSecretKey, baseQueueUrl, 10, 100, 0, retryInOtherRegions: true);
			sqsBatchSender.ExceptionOccured += _Logger.Error;
			sqsBatchSender.Start();
			return sqsBatchSender;
		});
		string serializedMessage = JsonConvert.SerializeObject(message);
		SqsMessageWrapper wrapper = new SqsMessageWrapper
		{
			Message = serializedMessage
		};
		_SqsPublisher.SendMessage(JsonConvert.SerializeObject(wrapper));
	}
}
