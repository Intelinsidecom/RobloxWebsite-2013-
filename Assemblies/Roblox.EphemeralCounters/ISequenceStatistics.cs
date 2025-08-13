namespace Roblox.EphemeralCounters;

public interface ISequenceStatistics
{
	double Maximum { get; }

	double Minimum { get; }

	double Sum { get; }

	int Count { get; }

	double Average { get; }

	double StandardDeviation { get; }

	double P01 { get; }

	double P05 { get; }

	double P25 { get; }

	double P50 { get; }

	double P75 { get; }

	double P95 { get; }

	double P99 { get; }

	double GetStatisticByName(string statisticName);
}
