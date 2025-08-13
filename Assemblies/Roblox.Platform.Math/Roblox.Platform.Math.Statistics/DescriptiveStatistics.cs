namespace Roblox.Platform.Math.Statistics;

public sealed class DescriptiveStatistics<TVal>
{
	public TVal Maximum { get; }

	public TVal Minimum { get; }

	public TVal Sum { get; }

	public int Count { get; }

	public double Average { get; }

	public double L2Norm { get; }

	public double StandardDeviation { get; }

	public double MeanDeviation { get; }

	public DescriptiveStatistics(TVal max, TVal min, TVal sum, int count, double avg, double l2Norm, double standardDeviation, double meanDeviation)
	{
		Maximum = max;
		Minimum = min;
		Sum = sum;
		Count = count;
		Average = avg;
		L2Norm = l2Norm;
		StandardDeviation = standardDeviation;
		MeanDeviation = meanDeviation;
	}
}
