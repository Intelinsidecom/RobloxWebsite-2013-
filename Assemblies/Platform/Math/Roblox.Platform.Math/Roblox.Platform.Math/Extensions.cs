using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Math.Numerics;
using Roblox.Platform.Math.Series;
using Roblox.Platform.Math.Statistics;

namespace Roblox.Platform.Math;

public static class Extensions
{
	public static IStandardPercentiles GetStandardPercentiles(this IEnumerable<KeyValuePair<DateTime, double>> pairs)
	{
		return new Percentile(pairs.Select((KeyValuePair<DateTime, double> p) => p.Value)).GetStandardPercentiles();
	}

	public static ISeriesStatistics GetStatistics(this IEnumerable<KeyValuePair<DateTime, double>> pairs)
	{
		TimeSeries s = new TimeSeries();
		s.AddDataPoints(pairs);
		return new SeriesStatistics(s.DateRange, s.Count, s.Maximum, s.Minimum, s.Average, s.StandardDeviation, s.Sum, s.LatestDataPoint, s.MaximumDataPoint, s.MinimumDataPoint);
	}

	public static int NumberOfTimesGreaterThanThreshhold(this IEnumerable<KeyValuePair<DateTime, double>> pairs, double threshhold)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.NumberOfTimesGreaterThanThreshhold(threshhold);
	}

	public static int NumberOfTimesLessThanThreshhold(this IEnumerable<KeyValuePair<DateTime, double>> pairs, double threshhold)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.NumberOfTimesLessThanThreshhold(threshhold);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> TimeShift(this IEnumerable<KeyValuePair<DateTime, double>> pairs, TimeSpan shiftAmount)
	{
		return pairs.Select((KeyValuePair<DateTime, double> e) => new KeyValuePair<DateTime, double>(e.Key + shiftAmount, e.Value));
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeFirstDerivative(this IEnumerable<KeyValuePair<DateTime, double>> pairs, TimeUnits units)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.ComputeFirstDerivative(units).KeyValuePairs;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeSecondDerivative(this IEnumerable<KeyValuePair<DateTime, double>> pairs, TimeUnits units)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.ComputeSecondDerivative(units).KeyValuePairs;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeRelativeIncreaseInPercent(this IEnumerable<KeyValuePair<DateTime, double>> pairs)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.ComputeRelativeIncreaseInPercent().KeyValuePairs;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeRelativeDecreaseInPercent(this IEnumerable<KeyValuePair<DateTime, double>> pairs)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.ComputeRelativeDecreaseInPercent().KeyValuePairs;
	}

	public static double? InterpolateValueAt(this IEnumerable<KeyValuePair<DateTime, double>> pairs, DateTime timestamp)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.InterpolateValueAt(timestamp);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> InterpolateOntoGrid(this IEnumerable<KeyValuePair<DateTime, double>> pairs, ICollection<DateTime> gridPoints)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.InterpolateOntoGrid(gridPoints).KeyValuePairs;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> InterpolateOrderedOntoOrderedGrid(this IEnumerable<KeyValuePair<DateTime, double>> pairsOrdered, IList<DateTime> gridPointsOrdered)
	{
		IList<KeyValuePair<DateTime, double>> entries = pairsOrdered as IList<KeyValuePair<DateTime, double>>;
		if (entries == null)
		{
			entries = pairsOrdered.ToList();
		}
		int countOfEntries = entries.Count;
		int gridCount = gridPointsOrdered.Count;
		List<KeyValuePair<DateTime, double>> interpolatedTimeSeries = new List<KeyValuePair<DateTime, double>>(gridCount);
		if (gridCount == 0 || countOfEntries < 2)
		{
			return interpolatedTimeSeries;
		}
		int startIndex = 1;
		for (int gridPosition = 0; gridPosition < gridCount; gridPosition++)
		{
			DateTime gridPoint = gridPointsOrdered[gridPosition];
			for (int i = startIndex; i < countOfEntries; i++)
			{
				KeyValuePair<DateTime, double> previousTimeSeriesEntry = entries[i - 1];
				DateTime xIm1 = previousTimeSeriesEntry.Key;
				double yIm1 = previousTimeSeriesEntry.Value;
				KeyValuePair<DateTime, double> currentTimeSeriesEntry = entries[i];
				DateTime xI = currentTimeSeriesEntry.Key;
				double yI = currentTimeSeriesEntry.Value;
				if (gridPoint.CompareTo(xIm1) > 0 && gridPoint.CompareTo(xI) <= 0)
				{
					double yInterpolated = Interpolation.LinearlyInterpolate(yI, yIm1, xI, xIm1, gridPoint);
					interpolatedTimeSeries.Add(new KeyValuePair<DateTime, double>(gridPoint, yInterpolated));
					startIndex = ((i == 1) ? 1 : (i - 1));
					break;
				}
			}
		}
		return interpolatedTimeSeries;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeTimeRangeAverages(this IEnumerable<KeyValuePair<DateTime, double>> pairsOrdered, AggregationTimeSpan timeSpan)
	{
		List<KeyValuePair<DateTime, double>> entries = pairsOrdered.ToList();
		if (!entries.Any())
		{
			return entries;
		}
		DateTime key = entries.First().Key;
		DateTime rangeEndTime = entries.Last().Key;
		TimeSpan dayStartUtcOffset = TimeSpan.FromHours(-7.0);
		IEnumerable<TimeSegment> enumerable = TimeSplitter.SplitIntoParts(key, rangeEndTime, timeSpan, dayStartUtcOffset);
		List<KeyValuePair<DateTime, double>> transformed = new List<KeyValuePair<DateTime, double>>();
		foreach (TimeSegment currentSegment in enumerable)
		{
			KeyValuePair<DateTime, double>[] entriesInSegmentRange = entries.Where((KeyValuePair<DateTime, double> e) => e.Key > currentSegment.StartTime && e.Key <= currentSegment.EndTime).ToArray();
			if (entriesInSegmentRange.Any())
			{
				double averageValue = entriesInSegmentRange.Select((KeyValuePair<DateTime, double> e) => e.Value).Average();
				DateTime time = currentSegment.StartTime;
				KeyValuePair<DateTime, double> kvp = new KeyValuePair<DateTime, double>(time, averageValue);
				transformed.Add(kvp);
			}
		}
		return transformed;
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> MultiplyBy(this IEnumerable<KeyValuePair<DateTime, double>> x, IEnumerable<KeyValuePair<DateTime, double>> y)
	{
		return PerformMathOperation(x, y, MathOperation.Multiply);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> MultiplyByValue(this IEnumerable<KeyValuePair<DateTime, double>> pairs, double multiplier)
	{
		return pairs.Select((KeyValuePair<DateTime, double> e) => new KeyValuePair<DateTime, double>(e.Key, e.Value * multiplier));
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> DivideBy(this IEnumerable<KeyValuePair<DateTime, double>> x, IEnumerable<KeyValuePair<DateTime, double>> y)
	{
		return PerformMathOperation(x, y, MathOperation.Divide);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> AddTo(this IEnumerable<KeyValuePair<DateTime, double>> x, IEnumerable<KeyValuePair<DateTime, double>> y)
	{
		return PerformMathOperation(x, y, MathOperation.Add);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> Subtract(this IEnumerable<KeyValuePair<DateTime, double>> x, IEnumerable<KeyValuePair<DateTime, double>> y)
	{
		return PerformMathOperation(x, y, MathOperation.Subtract);
	}

	public static IEnumerable<KeyValuePair<DateTime, double>> ComputeForwardRollingAverage(this IEnumerable<KeyValuePair<DateTime, double>> pairs, int intervalToAverage)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(pairs);
		return timeSeries.ComputeForwardRollingAverage(intervalToAverage).KeyValuePairs;
	}

	private static IEnumerable<KeyValuePair<DateTime, double>> PerformMathOperation(IEnumerable<KeyValuePair<DateTime, double>> x, IEnumerable<KeyValuePair<DateTime, double>> y, MathOperation operation)
	{
		TimeSeries timeSeries = new TimeSeries();
		timeSeries.AddDataPoints(x);
		TimeSeries ySeries = new TimeSeries();
		ySeries.AddDataPoints(y);
		return timeSeries.PerformMathOn(ySeries, operation).KeyValuePairs;
	}
}
