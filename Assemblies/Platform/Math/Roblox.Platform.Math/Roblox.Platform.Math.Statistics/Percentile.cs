using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math.Statistics;

public sealed class Percentile
{
	private readonly List<double> _Values;

	public Percentile(IEnumerable<double> values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values", "Percentile requires non-null values");
		}
		_Values = new List<double>(values);
		_Values.Sort();
	}

	public double GetPercentile(int percentile)
	{
		if (percentile < 0 || percentile > 100)
		{
			throw new ArgumentOutOfRangeException("percentile", "Percentile.GetPercentile argument must be between 0 and 100");
		}
		int count = _Values.Count;
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
				throw new ApplicationException("Attempting to get an endix out of range: " + index + " while list count was " + count);
			}
			return _Values[index];
		}
		catch (Exception ex)
		{
			throw new ApplicationException("Error getting percentile with index: " + index + " and count " + count + " EX: " + ex);
		}
	}

	public IStandardPercentiles GetStandardPercentiles()
	{
		double percentile = GetPercentile(1);
		double p5 = GetPercentile(5);
		double p6 = GetPercentile(10);
		double p7 = GetPercentile(25);
		double p8 = GetPercentile(50);
		double p9 = GetPercentile(75);
		double p10 = GetPercentile(95);
		double p11 = GetPercentile(99);
		return new StandardPercentiles(percentile, p5, p6, p7, p8, p9, p10, p11);
	}
}
