using System;

namespace Roblox.Coordination;

public class ElasticConsumerEventArgs : EventArgs
{
	public int DegreeOfParallelism { get; }

	public bool IsThrottled { get; }

	public ElasticConsumerEventArgs(int degreeOfParallelism, bool isThrottled)
	{
		DegreeOfParallelism = degreeOfParallelism;
		IsThrottled = isThrottled;
	}
}
