using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Math.Statistics;

public sealed class ContinuousSample
{
	private readonly IReadOnlyCollection<double> _Values;

	public ContinuousSample(IEnumerable<double> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values", "ContinuousSample constructor requires a non-null list of values");
		}
		_Values = new List<double>(values);
	}

	public ContinuousSample(IReadOnlyCollection<double> values)
	{
		_Values = values ?? throw new ArgumentNullException("values", "ContinuousSample constructor requires a non-null list of values");
	}

	public DescriptiveStatistics<double> CalculateStatistics()
	{
		return DoCalculateStatistics(_Values);
	}

	public DescriptiveStatistics<double> CalculateStatisticsWithoutOutliers(Confidence outlierThreshold)
	{
		DescriptiveStatistics<double> dummy;
		return CalculateStatisticsWithoutOutliers(outlierThreshold, out dummy);
	}

	public DescriptiveStatistics<double> CalculateStatisticsWithoutOutliers(Confidence outlierThreshold, out DescriptiveStatistics<double> statisticsWithOutliers)
	{
		List<double> sanitizedValues = new List<double>();
		DescriptiveStatistics<double> stats = DoCalculateStatistics(_Values);
		foreach (double val in _Values)
		{
			if (!TTest.SampleMeanIsStatisticallyDifferent(val, stats.Average, stats.Count, stats.StandardDeviation, outlierThreshold))
			{
				sanitizedValues.Add(val);
			}
		}
		statisticsWithOutliers = stats;
		return DoCalculateStatistics(sanitizedValues);
	}

	public static double StandardDeviation(IReadOnlyCollection<double> values)
	{
		int count = values.Count;
		if (count > 2)
		{
			double average = values.Average();
			double varianceAggregator = 0.0;
			foreach (double val in values)
			{
				varianceAggregator += System.Math.Pow(val - average, 2.0);
			}
			return System.Math.Sqrt(varianceAggregator / (double)(count - 1));
		}
		return 0.0;
	}

	private DescriptiveStatistics<double> DoCalculateStatistics(IReadOnlyCollection<double> data)
	{
		try
		{
			int count = 0;
			double max = double.MinValue;
			double min = double.MaxValue;
			double average = 0.0;
			double l2Norm = 0.0;
			foreach (double val2 in data)
			{
				count++;
				max = ((max < val2) ? val2 : max);
				min = ((min > val2) ? val2 : min);
				average += val2;
				l2Norm += val2 * val2;
			}
			max = ((count > 0) ? max : 0.0);
			min = ((count > 0) ? min : 0.0);
			double sum = average;
			average = ((count > 0) ? (average / (double)count) : 0.0);
			l2Norm = System.Math.Sqrt(l2Norm);
			double standardDeviation = 0.0;
			double meanDeviation = 0.0;
			foreach (double val in data)
			{
				standardDeviation += System.Math.Pow(val - average, 2.0);
				meanDeviation += System.Math.Abs(val - average);
			}
			standardDeviation = ((count > 2) ? System.Math.Sqrt(standardDeviation / (double)(count - 1)) : 0.0);
			meanDeviation = ((count > 0) ? (meanDeviation / (double)count) : 0.0);
			return new DescriptiveStatistics<double>(max, min, sum, count, average, l2Norm, standardDeviation, meanDeviation);
		}
		catch (Exception ex)
		{
			throw new MathException("CalculateStatistics Exception: ", ex);
		}
	}
}
