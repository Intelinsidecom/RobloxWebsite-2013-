using System;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream;

internal class ChatTrainingDataStreamer : IChatTrainingDataStreamer
{
	private readonly IChatTrainingDataSender _UnitedStatesRegionDataSender;

	private readonly IChatTrainingDataSender _GdprRegionDataSender;

	private readonly ChatTrainingDataStreamerPerformanceMonitor _Perfmon;

	public ChatTrainingDataStreamer(ICounterRegistry counterRegistry, ILogger logger, IChatTrainingDataSender unitedStatesRegionDataSender, IChatTrainingDataSender gdprRegionDataSender)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_UnitedStatesRegionDataSender = unitedStatesRegionDataSender;
		_GdprRegionDataSender = gdprRegionDataSender;
		_Perfmon = new ChatTrainingDataStreamerPerformanceMonitor(counterRegistry);
	}

	public void StreamChatTrainingData(IChatTrainingData data)
	{
		if (!ValidateChatTrainingData(data))
		{
			throw new ArgumentNullException("data");
		}
		if (data.Region == Region.GDPR)
		{
			_Perfmon.GdprRegionChatDataAttemptedToSentPerSecond.Increment();
			_GdprRegionDataSender.PublishData(data);
		}
		else if (data.Region == Region.UnitedStates)
		{
			_Perfmon.UnitedStatesRegionChatDataAttemptedToSentPerSecond.Increment();
			_UnitedStatesRegionDataSender.PublishData(data);
		}
	}

	private static bool ValidateChatTrainingData(IChatTrainingData data)
	{
		if (!string.IsNullOrWhiteSpace(data.Event) && !string.IsNullOrWhiteSpace(data.Context) && !string.IsNullOrWhiteSpace(data.Subcontext1) && !string.IsNullOrEmpty(data.OriginalText))
		{
			_ = data.Timestamp;
			if (!string.IsNullOrWhiteSpace(data.Name) && !string.IsNullOrWhiteSpace(data.RequestType) && !string.IsNullOrWhiteSpace(data.Under13Response) && !string.IsNullOrWhiteSpace(data.Over13Response) && data.Under13Categories != null && data.Over13Categories != null)
			{
				return Enum.IsDefined(typeof(Region), data.Region);
			}
		}
		return false;
	}
}
