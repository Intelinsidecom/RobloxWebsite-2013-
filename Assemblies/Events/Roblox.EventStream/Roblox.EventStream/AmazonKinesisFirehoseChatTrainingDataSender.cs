using System;
using Newtonsoft.Json;
using Roblox.Amazon.Firehose;
using Roblox.EventLog;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream;

public class AmazonKinesisFirehoseChatTrainingDataSender : IChatTrainingDataSender
{
	private readonly AmazonKinesisFirehoseBatchEventSender _AmazonKinesisFirehoseBatchEventSender;

	private readonly ILogger _Logger;

	public AmazonKinesisFirehoseChatTrainingDataSender(ILogger logger, string amazonKinesisFirehoseStreamName, int recordsPerBatchRequest)
	{
		_AmazonKinesisFirehoseBatchEventSender = new AmazonKinesisFirehoseBatchEventSender(logger, Settings.Default.AmazonKinesisFirehoseAwsAccessKey, Settings.Default.AmazonKinesisFirehoseAwsAccessSecretKey, amazonKinesisFirehoseStreamName, Settings.Default.AmazonKinesisFirehoseMaxBufferSizeOfRecord, recordsPerBatchRequest, Settings.Default.AmazonKinesisFirehoseMaxTimeoutPerMessage);
		_Logger = logger;
	}

	public void PublishData(IChatTrainingData data)
	{
		if (Settings.Default.StreamToChatTrainingDataAmazonKinesisFirehoseEnabled)
		{
			string formattedData = JsonConvert.SerializeObject(data);
			formattedData += Environment.NewLine;
			_AmazonKinesisFirehoseBatchEventSender.EnqueueWork(formattedData);
		}
	}
}
