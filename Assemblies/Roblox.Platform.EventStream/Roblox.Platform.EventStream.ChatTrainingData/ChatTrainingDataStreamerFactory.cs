using System;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream.ChatTrainingData;

/// <summary>
/// A class producing <see cref="T:Roblox.Platform.EventStream.IChatTrainingDataStreamer" />
/// </summary>
public class ChatTrainingDataStreamerFactory : IChatTrainingDataStreamerFactory
{
	internal virtual string AmazonKinesisFirehoseGDPRStreamName => Settings.Default.AmazonKinesisFirehoseGDPRStreamName;

	internal virtual string AmazonKinesisFirehoseUnitedStatesStreamName => Settings.Default.AmazonKinesisFirehoseUnitedStatesStreamName;

	internal virtual int AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest => Settings.Default.AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest;

	/// <summary>
	/// Returns a <see cref="T:Roblox.Platform.EventStream.IChatTrainingDataStreamer" /> using the given <see cref="T:Roblox.EventLog.ILogger" />
	/// </summary>
	public IChatTrainingDataStreamer GetStreamer(ICounterRegistry counterRegistry, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (logger == null)
		{
			throw new ArgumentNullException("logger");
		}
		AmazonKinesisFirehoseChatTrainingDataSender unitedStatesDataSender = new AmazonKinesisFirehoseChatTrainingDataSender(logger, AmazonKinesisFirehoseUnitedStatesStreamName, AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest);
		AmazonKinesisFirehoseChatTrainingDataSender gdprDataSender = new AmazonKinesisFirehoseChatTrainingDataSender(logger, AmazonKinesisFirehoseGDPRStreamName, AmazonKinesisFirehoseMaxChatTrainingDataMessagesPerBatchRequest);
		return new ChatTrainingDataStreamer(counterRegistry, logger, unitedStatesDataSender, gdprDataSender);
	}
}
