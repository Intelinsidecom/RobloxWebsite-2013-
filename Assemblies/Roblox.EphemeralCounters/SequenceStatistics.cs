using System.Collections.Generic;

namespace Roblox.EphemeralCounters;

internal class SequenceStatistics : ISequenceStatistics
{
	private readonly IDictionary<string, double> _Dictionary;

	public double Maximum { get; }

	public double Minimum { get; }

	public double Sum { get; }

	public int Count { get; }

	public double Average { get; }

	public double StandardDeviation { get; }

	public double P01 { get; }

	public double P05 { get; }

	public double P25 { get; }

	public double P50 { get; }

	public double P75 { get; }

	public double P95 { get; }

	public double P99 { get; }

	public SequenceStatistics(IDictionary<string, double> dictionary)
	{
		_Dictionary = dictionary;
		Maximum = GetStatisticByName("Maximum");
		Minimum = GetStatisticByName("Minimum");
		Sum = GetStatisticByName("Sum");
		Count = (int)GetStatisticByName("Count");
		Average = GetStatisticByName("Average");
		StandardDeviation = GetStatisticByName("StandardDeviation");
		P01 = GetStatisticByName("P01");
		P05 = GetStatisticByName("P05");
		P25 = GetStatisticByName("P25");
		P50 = GetStatisticByName("P50");
		P75 = GetStatisticByName("P75");
		P95 = GetStatisticByName("P95");
		P99 = GetStatisticByName("P99");
	}

	public double GetStatisticByName(string statisticName)
	{
		_Dictionary.TryGetValue(statisticName, out var value);
		return value;
	}
}
