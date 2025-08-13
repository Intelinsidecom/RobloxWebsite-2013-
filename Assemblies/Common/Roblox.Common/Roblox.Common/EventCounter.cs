using System;
using System.Threading;

namespace Roblox.Common;

/// <summary>
/// Stores event counts in power-of-2 time buckets
/// </summary>
[Obsolete("This class yields inaccurate results when sampled over a timespan.")]
public class EventCounter : IDisposable
{
	private class Bucket
	{
		private long eventCount;

		public long EventCount => eventCount;

		public Bucket(long value)
		{
			eventCount = value;
		}

		public void LogEvent()
		{
			Interlocked.Increment(ref eventCount);
		}
	}

	private class BucketAggregation
	{
		private Bucket current;

		private BucketAggregation next;

		public readonly TimeSpan Span;

		public BucketAggregation(TimeSpan span)
		{
			Span = span;
		}

		public void AddBucket(Bucket bucket)
		{
			if (current == null)
			{
				current = bucket;
				return;
			}
			if (next == null)
			{
				next = new BucketAggregation(Span + Span);
			}
			next.AddBucket(new Bucket(current.EventCount + bucket.EventCount));
			current = null;
		}

		public long GetEventCount(TimeSpan span)
		{
			if (current != null)
			{
				if (span == Span)
				{
					return current.EventCount;
				}
				if (span > Span && next != null)
				{
					return current.EventCount + next.GetEventCount(span - Span);
				}
				return current.EventCount * span.Ticks / Span.Ticks;
			}
			if (next != null)
			{
				return next.GetEventCount(span);
			}
			span = TimeSpan.Zero;
			return 0L;
		}

		public long GetTotalEventCount()
		{
			long result = 0L;
			if (current != null)
			{
				result += current.EventCount;
			}
			if (next != null)
			{
				result += next.GetTotalEventCount();
			}
			return result;
		}
	}

	private Bucket currentBucket;

	private readonly BucketAggregation head = new BucketAggregation(SmallestInterval);

	private readonly Timer timer;

	public static readonly TimeSpan SmallestInterval = TimeSpan.FromSeconds(2.0);

	public EventCounter()
	{
		currentBucket = new Bucket(0L);
		timer = new Timer(delegate
		{
			head.AddBucket(currentBucket);
			currentBucket = new Bucket(0L);
		}, null, SmallestInterval, SmallestInterval);
	}

	public long GetEventCount(TimeSpan sample)
	{
		if (sample == TimeSpan.MaxValue)
		{
			return GetTotalEventCount();
		}
		return head.GetEventCount(sample);
	}

	public double GetEventsPerSecond(TimeSpan sample)
	{
		long events = GetEventCount(sample);
		if (!(sample != TimeSpan.Zero))
		{
			return 0.0;
		}
		return (double)events / sample.TotalSeconds;
	}

	public long GetTotalEventCount()
	{
		return head.GetTotalEventCount();
	}

	public void LogEvent()
	{
		currentBucket.LogEvent();
	}

	public void Dispose()
	{
		timer.Dispose();
	}
}
