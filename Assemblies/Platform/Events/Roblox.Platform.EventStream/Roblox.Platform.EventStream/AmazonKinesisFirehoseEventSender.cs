using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Amazon.Firehose;
using Roblox.EventLog;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream;

internal class AmazonKinesisFirehoseEventSender : IEventSender
{
	private readonly AmazonKinesisFirehoseBatchEventSender _AmazonKinesisFirehoseBatchEventSender;

	private readonly ILogger _Logger;

	public AmazonKinesisFirehoseEventSender(ILogger logger)
	{
		_AmazonKinesisFirehoseBatchEventSender = new AmazonKinesisFirehoseBatchEventSender(logger, Settings.Default.AmazonKinesisFirehoseAwsAccessKey, Settings.Default.AmazonKinesisFirehoseAwsAccessSecretKey, Settings.Default.AmazonKinesisFirehoseDeliveryStreamName, Settings.Default.AmazonKinesisFirehoseMaxBufferSizeOfRecord, Settings.Default.AmazonKinesisFirehoseMaxMessagesPerBatchRequest, Settings.Default.AmazonKinesisFirehoseMaxTimeoutPerMessage);
		_Logger = logger;
	}

	public void PublishEvent(string target, string eventType, IEnumerable<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, string partitionKey = null)
	{
		string formattedData = FormatEventData(target, eventType, eventParameters, clientIp, isTrustedSource);
		_AmazonKinesisFirehoseBatchEventSender.EnqueueWork(formattedData);
	}

	private string FormatEventData(string target, string eventType, IEnumerable<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource)
	{
		IEnumerable<string> parts = eventParameters.Select((KeyValuePair<string, string> kvp) => HttpUtility.UrlEncode(kvp.Key) + "=" + HttpUtility.UrlEncode(kvp.Value));
		string eventParametersAsQueryString = string.Join("&", parts);
		return string.Join("\t", target, eventType, clientIp, isTrustedSource, DateTime.UtcNow.ToString("O"), eventParametersAsQueryString) + "\r\n";
	}
}
