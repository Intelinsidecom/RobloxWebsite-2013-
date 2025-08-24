using System;
using System.Collections.Concurrent;
using System.Linq;
using Roblox.Coordination.Interface;

namespace Roblox.Coordination;

public class ElasticConsumer
{
	private readonly Func<IConsumer> _ConsumerCreator;

	private readonly Func<bool, double> _PredictionConfidenceGetter;

	private readonly Func<int> _MaximumDegreeOfParallelismGetter;

	private readonly ConcurrentDictionary<IConsumer, bool> _Consumers = new ConcurrentDictionary<IConsumer, bool>();

	private readonly object _Sync = new object();

	private readonly Random _Random;

	private const double _FloatingPointTolerance = 0.001;

	public int BatchSize { get; }

	public bool IsRunning { get; private set; }

	public int Capacity => _Consumers.Keys.Sum((IConsumer c) => c.BatchSize);

	public int CurrentDegreeOfParallelism => _Consumers.Count;

	public int SurplusCapacity => _Consumers.Keys.Sum((IConsumer c) => c.SurplusCapacity);

	private int ThrottledConsumersCount => _Consumers.Keys.Count((IConsumer c) => c.MessageDeliveryWasThrottled);

	private bool IsThrottled => ThrottledConsumersCount > 0;

	private bool MaximumParallelismIsExceeded => CurrentDegreeOfParallelism > _MaximumDegreeOfParallelismGetter();

	private bool MoreParallelismIsAvailable => CurrentDegreeOfParallelism < _MaximumDegreeOfParallelismGetter();

	private bool SurplusCapacityIsAvailable => SurplusCapacity > 0;

	public event Action<ElasticConsumer, ElasticConsumerEventArgs> ParallelismDecreased;

	public event Action<ElasticConsumer, ElasticConsumerEventArgs> ParallelismIncreased;

	public event Action<ElasticConsumer, EventArgs> Started;

	public event Action<ElasticConsumer, EventArgs> Stopped;

	public ElasticConsumer(Func<IConsumer> consumerCreator, int batchSize, Func<bool, double> predictionConfidenceGetter = null, Func<int> maximumDegreeOfParallelismGetter = null)
	{
		_ConsumerCreator = consumerCreator ?? throw new ArgumentException("Required argument not provided: consumerFactory", "consumerCreator");
		_PredictionConfidenceGetter = predictionConfidenceGetter ?? ((Func<bool, double>)((bool isDegreeOfParallelismIncreasing) => 1.0));
		_MaximumDegreeOfParallelismGetter = maximumDegreeOfParallelismGetter ?? ((Func<int>)(() => int.MaxValue));
		BatchSize = batchSize;
		_Random = new Random(new object().GetHashCode());
	}

	public void Start(int startingNumberOfConsumers = 1)
	{
		if (IsRunning)
		{
			return;
		}
		lock (_Sync)
		{
			if (IsRunning)
			{
				return;
			}
			IsRunning = true;
		}
		ElasticConsumerEventArgs e = new ElasticConsumerEventArgs(0, isThrottled: false);
		this.Started?.Invoke(this, e);
		for (int i = 0; i < startingNumberOfConsumers; i++)
		{
			CreateConsumer(i == 0);
		}
	}

	public void Stop()
	{
		if (!IsRunning)
		{
			return;
		}
		lock (_Sync)
		{
			if (!IsRunning)
			{
				return;
			}
			IsRunning = false;
		}
		foreach (IConsumer consumer in _Consumers.Keys)
		{
			StopConsuming(consumer, removeFromConsumersCollection: false);
		}
		_Consumers.Clear();
		ElasticConsumerEventArgs e = new ElasticConsumerEventArgs(0, isThrottled: false);
		this.Stopped?.Invoke(this, e);
	}

	private bool ShouldStartConsumer(IConsumer consumer)
	{
		if (consumer.MessageDeliveryWasThrottled)
		{
			return false;
		}
		if (SurplusCapacityIsAvailable)
		{
			return false;
		}
		if (IsThrottled)
		{
			return false;
		}
		if (!MoreParallelismIsAvailable)
		{
			return false;
		}
		return _Random.Next(_Consumers.Count) == 0;
	}

	private void Consumer_Worked(BackgroundWorker sender, EventArgs e)
	{
		IConsumer consumer = sender as IConsumer;
		if (!ShouldContinueConsuming(consumer) && ShouldTakeAction(isDegreeOfParallelismIncreasing: false))
		{
			StopConsuming(consumer);
		}
		else if (ShouldStartConsumer(consumer) && ShouldTakeAction(isDegreeOfParallelismIncreasing: true))
		{
			CreateConsumer();
		}
	}

	private void CreateConsumer(bool isAnchored = false)
	{
		IConsumer consumer = _ConsumerCreator();
		consumer.BatchSize = BatchSize;
		consumer.Worked += Consumer_Worked;
		_Consumers.TryAdd(consumer, isAnchored);
		consumer.Start();
		ElasticConsumerEventArgs e = new ElasticConsumerEventArgs(CurrentDegreeOfParallelism, IsThrottled);
		this.ParallelismIncreased?.Invoke(this, e);
	}

	private bool ShouldContinueConsuming(IConsumer consumer)
	{
		_Consumers.TryGetValue(consumer, out var isAnchored);
		if (isAnchored)
		{
			return true;
		}
		if (MaximumParallelismIsExceeded)
		{
			return false;
		}
		if (SurplusCapacity >= BatchSize && _Random.Next(_Consumers.Count) == 0)
		{
			return false;
		}
		if (consumer.MessageDeliveryWasThrottled && _Random.Next(ThrottledConsumersCount) == 0)
		{
			return false;
		}
		return true;
	}

	private bool ShouldTakeAction(bool isDegreeOfParallelismIncreasing)
	{
		double predictionConfidence = _PredictionConfidenceGetter(isDegreeOfParallelismIncreasing);
		if (Math.Abs(predictionConfidence - 1.0) < 0.001)
		{
			return true;
		}
		if (Math.Abs(predictionConfidence) < 0.001)
		{
			return false;
		}
		return _Random.NextDouble() <= predictionConfidence;
	}

	private void StopConsuming(IConsumer consumer, bool removeFromConsumersCollection = true)
	{
		consumer.Stop();
		consumer.Worked -= Consumer_Worked;
		if (removeFromConsumersCollection)
		{
			_Consumers.TryRemove(consumer, out var _);
		}
		ElasticConsumerEventArgs e = new ElasticConsumerEventArgs(CurrentDegreeOfParallelism, IsThrottled);
		this.ParallelismDecreased?.Invoke(this, e);
	}
}
