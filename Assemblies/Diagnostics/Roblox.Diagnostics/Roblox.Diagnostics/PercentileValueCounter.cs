using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Roblox.Diagnostics;

public class PercentileValueCounter : IPercentileValueCounter, IDisposable
{
	private readonly IDictionary<int, PerformanceCounter> _PercentileCounters;

	private readonly Timer _Timer;

	private ConcurrentBag<double> _Values;

	public event Action<Exception> ExceptionOccured;

	public PercentileValueCounter(IDictionary<int, PerformanceCounter> percentileCounters, TimeSpan updateInterval)
	{
		_PercentileCounters = percentileCounters;
		_Values = new ConcurrentBag<double>();
		_Timer = new Timer(UpdateCounter);
		_Timer.Change(updateInterval, updateInterval);
	}

	public void Sample(double value)
	{
		_Values.Add(value);
	}

	public void Dispose()
	{
		_Timer?.Dispose();
	}

	internal static double GetPercentile(IReadOnlyList<double> sortedValues, int percentile)
	{
		if (percentile < 0 || percentile > 100)
		{
			throw new ArgumentOutOfRangeException("percentile", "Percentile.GetPercentile argument must be between 0 and 100");
		}
		int count = sortedValues.Count;
		if (count == 0)
		{
			return 0.0;
		}
		int index = 0;
		try
		{
			index = (int)((double)(count - 1) * ((double)percentile / 100.0));
			if (index < 0 || index >= count)
			{
				throw new ApplicationException("Attempting to get an index out of range: " + index + " while list count was " + count);
			}
			return sortedValues[index];
		}
		catch (Exception ex)
		{
			throw new ApplicationException("Error getting percentile with index: " + index + " and count " + count + ". Exception: " + ex);
		}
	}

	private void UpdateCounter(object o)
	{
		ConcurrentBag<double> newBag = new ConcurrentBag<double>();
		List<double> elements = Interlocked.Exchange(ref _Values, newBag).ToList();
		elements.Sort();
		foreach (KeyValuePair<int, PerformanceCounter> kvp in _PercentileCounters)
		{
			int percentile = kvp.Key;
			PerformanceCounter counter = kvp.Value;
			double percentileValue = GetPercentile(elements, percentile);
			try
			{
				counter.RawValue = (long)Math.Round(percentileValue);
			}
			catch (Exception e)
			{
				if (this.ExceptionOccured != null)
				{
					try
					{
						this.ExceptionOccured(e);
					}
					catch
					{
					}
				}
			}
		}
	}
}
