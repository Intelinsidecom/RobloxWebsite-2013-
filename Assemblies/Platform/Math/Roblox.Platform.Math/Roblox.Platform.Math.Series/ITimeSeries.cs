using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math.Series;

internal interface ITimeSeries : IDataSeries<DateTime, double>
{
	DateRange DateRange { get; }

	KeyValuePair<DateTime, double>? LatestDataPoint { get; }

	KeyValuePair<DateTime, double>? MaximumDataPoint { get; }

	KeyValuePair<DateTime, double>? MinimumDataPoint { get; }

	int Count { get; }

	double Maximum { get; }

	double Minimum { get; }

	double Average { get; }

	double StandardDeviation { get; }

	double Sum { get; }

	int NumberOfTimesGreaterThanThreshhold(double threshhold);

	int NumberOfTimesLessThanThreshhold(double threshhold);

	ITimeSeries ComputeFirstDerivative(TimeUnits units);

	ITimeSeries ComputeSecondDerivative(TimeUnits units);

	double? InterpolateValueAt(DateTime timestamp);

	ITimeSeries InterpolateOntoGrid(ICollection<DateTime> gridPoints);

	ITimeSeries MultiplyBy(double constant);

	ITimeSeries MultiplyBy(ITimeSeries otherSeries);

	ITimeSeries DivideBy(ITimeSeries otherSeries);

	ITimeSeries AddTo(ITimeSeries otherSeries);

	ITimeSeries Subtract(ITimeSeries otherSeries);

	ITimeSeries ComputeForwardRollingAverage(int intervalToAverage);
}
