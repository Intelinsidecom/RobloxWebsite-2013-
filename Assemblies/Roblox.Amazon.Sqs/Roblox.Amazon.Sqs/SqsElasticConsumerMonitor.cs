using System;
using Roblox.Coordination;

namespace Roblox.Amazon.Sqs;

internal sealed class SqsElasticConsumerMonitor : IDisposable
{
	private readonly SqsStreamSubscriberPerformanceMonitor _TotalsPerformanceMonitor;

	private readonly SqsStreamSubscriberPerformanceMonitor _RegionPerformanceMonitor;

	private readonly ElasticConsumer _ElasticConsumer;

	public SqsElasticConsumerMonitor(ElasticConsumer elasticConsumer, SqsStreamSubscriberPerformanceMonitor totalsPerformanceMonitor, SqsStreamSubscriberPerformanceMonitor regionPerformanceMonitor)
	{
		_ElasticConsumer = elasticConsumer;
		_TotalsPerformanceMonitor = totalsPerformanceMonitor;
		_RegionPerformanceMonitor = regionPerformanceMonitor;
	}

	private void ElasticConsumer_ParallelismIncreased(ElasticConsumer sender, ElasticConsumerEventArgs e)
	{
		if (e.DegreeOfParallelism > _RegionPerformanceMonitor.TotalConsumersRunning.RawValue)
		{
			long increaseAmount = e.DegreeOfParallelism - _RegionPerformanceMonitor.TotalConsumersRunning.RawValue;
			_RegionPerformanceMonitor.LogParallelismIncreasedBy((int)increaseAmount);
			_TotalsPerformanceMonitor.LogParallelismIncreasedBy((int)increaseAmount);
		}
	}

	private void ElasticConsumer_ParallelismDecreased(ElasticConsumer sender, ElasticConsumerEventArgs e)
	{
		if (e.DegreeOfParallelism < _RegionPerformanceMonitor.TotalConsumersRunning.RawValue)
		{
			long decreaseAmount = _RegionPerformanceMonitor.TotalConsumersRunning.RawValue - e.DegreeOfParallelism;
			_RegionPerformanceMonitor.LogParallelismDecreasedBy((int)decreaseAmount);
			_TotalsPerformanceMonitor.LogParallelismDecreasedBy((int)decreaseAmount);
		}
	}

	public void Dispose()
	{
		Stop();
	}

	public void Start()
	{
		_ElasticConsumer.ParallelismIncreased += ElasticConsumer_ParallelismIncreased;
		_ElasticConsumer.ParallelismDecreased += ElasticConsumer_ParallelismDecreased;
	}

	public void Stop()
	{
		_RegionPerformanceMonitor.LogStop();
		_ElasticConsumer.ParallelismIncreased -= ElasticConsumer_ParallelismIncreased;
		_ElasticConsumer.ParallelismDecreased -= ElasticConsumer_ParallelismDecreased;
	}
}
