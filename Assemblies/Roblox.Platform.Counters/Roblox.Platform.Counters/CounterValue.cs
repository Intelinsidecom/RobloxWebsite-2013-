using System;
using Roblox.DurableCounters.Client;

namespace Roblox.Platform.Counters;

public class CounterValue
{
	public DateTime Bucket { get; private set; }

	public double Value { get; private set; }

	internal CounterValue(CounterValue clientCounterValue)
		: this(clientCounterValue.Bucket, clientCounterValue.Value)
	{
	}

	public CounterValue(DateTime bucket, double value)
	{
		Bucket = bucket;
		Value = value;
	}
}
