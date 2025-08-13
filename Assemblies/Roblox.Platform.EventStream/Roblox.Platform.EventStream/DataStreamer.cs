using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.EventStream;

public class DataStreamer : IDataStreamer
{
	private readonly IDataSender _DataSender;

	private readonly DataStreamerPerformanceMonitor _Perfmon;

	public DataStreamer(ICounterRegistry counterRegistry, ILogger logger, IDataSender dataSender)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_DataSender = dataSender;
		_Perfmon = new DataStreamerPerformanceMonitor(counterRegistry);
	}

	public void StreamData(List<string> dataList)
	{
		_Perfmon.AssetHandlerDataAttemptedToSentPerSecond.Increment();
		_DataSender.PublishData(dataList);
	}
}
