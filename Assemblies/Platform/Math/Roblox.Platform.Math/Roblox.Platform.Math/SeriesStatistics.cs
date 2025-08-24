using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math;

internal sealed class SeriesStatistics : ISeriesStatistics
{
	public DateRange DateRange { get; }

	public int Count { get; }

	public double Maximum { get; }

	public double Minimum { get; }

	public double Average { get; }

	public double StandardDeviation { get; }

	public double Sum { get; }

	public KeyValuePair<DateTime, double>? LatestDataPoint { get; }

	public KeyValuePair<DateTime, double>? MaximumDataPoint { get; }

	public KeyValuePair<DateTime, double>? MinimumDataPoint { get; }

	public SeriesStatistics(DateRange range, int count, double max, double min, double avg, double stdev, double sum, KeyValuePair<DateTime, double>? latestPoint, KeyValuePair<DateTime, double>? maxPoint, KeyValuePair<DateTime, double>? minPoint)
	{
		DateRange = range;
		Count = count;
		Maximum = max;
		Minimum = min;
		Average = avg;
		StandardDeviation = stdev;
		Sum = sum;
		LatestDataPoint = latestPoint;
		MaximumDataPoint = maxPoint;
		MinimumDataPoint = minPoint;
	}
}
