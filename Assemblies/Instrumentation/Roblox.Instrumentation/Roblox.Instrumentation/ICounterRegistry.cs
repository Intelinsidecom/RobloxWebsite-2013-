using System.Collections.Generic;

namespace Roblox.Instrumentation;

public interface ICounterRegistry
{
	IRateOfCountsPerSecondCounter GetRateOfCountsPerSecondCounter(string category, string name, string instance = null);

	IAverageValueCounter GetAverageValueCounter(string category, string name, string instance = null);

	IMaximumValueCounter GetMaximumValueCounter(string category, string name, string instance = null);

	IRawValueCounter GetRawValueCounter(string category, string name, string instance = null);

	IFractionCounter GetFractionCounter(string category, string name, string instance = null);

	IPercentileCounter GetPercentileCounter(string category, string nameFormatString, byte[] percentiles, string instance = null);

	IPercentileCounter GetPercentileCounter(string category, string name, string instanceFormatString, byte[] percentiles);

	IReadOnlyCollection<KeyValuePair<CounterKey, double>> FlushCounters();

	IReadOnlyCollection<KeyValuePair<CounterKey, double>> GetCounterValues();

	IReadOnlyCollection<byte> GetDefaultPercentiles();
}
