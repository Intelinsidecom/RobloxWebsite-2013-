using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math;

public interface ISeriesStatistics
{
	DateRange DateRange { get; }

	int Count { get; }

	double Maximum { get; }

	double Minimum { get; }

	double Average { get; }

	double StandardDeviation { get; }

	double Sum { get; }

	KeyValuePair<DateTime, double>? LatestDataPoint { get; }

	KeyValuePair<DateTime, double>? MaximumDataPoint { get; }

	KeyValuePair<DateTime, double>? MinimumDataPoint { get; }
}
