using System.Collections.Generic;
using Roblox.Amazon.Firehose;
using Roblox.EventLog;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream;

public class AmazonKinesisFirehoseAssetHandlerDataSender : IDataSender
{
	private readonly AmazonKinesisFirehoseBatchEventSender _AmazonKinesisFirehoseBatchEventSender;

	private readonly ILogger _Logger;

	public AmazonKinesisFirehoseAssetHandlerDataSender(ILogger logger)
	{
		_AmazonKinesisFirehoseBatchEventSender = new AmazonKinesisFirehoseBatchEventSender(logger, Settings.Default.AmazonKinesisFirehoseAwsAccessKey, Settings.Default.AmazonKinesisFirehoseAwsAccessSecretKey, Settings.Default.AmazonKinesisFirehoseAssetHandlerStreamName, Settings.Default.AmazonKinesisFirehoseMaxBufferSizeOfRecord, Settings.Default.AmazonKinesisFirehoseMaxAssetHandlerMessagesPerBatchRequest, Settings.Default.AmazonKinesisFirehoseMaxTimeoutPerMessage);
		_Logger = logger;
	}

	public void PublishData(List<string> dataList)
	{
		if (Settings.Default.AssetHandlerDataStreamToAmazonKinesisFirehoseEnabled)
		{
			string data = string.Join("\t", dataList);
			data += "\r\n";
			_AmazonKinesisFirehoseBatchEventSender.EnqueueWork(data);
		}
	}
}
