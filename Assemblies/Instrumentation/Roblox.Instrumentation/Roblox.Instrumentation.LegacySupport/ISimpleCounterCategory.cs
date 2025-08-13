namespace Roblox.Instrumentation.LegacySupport;

public interface ISimpleCounterCategory
{
	void IncrementTotal(string counterName);

	void IncrementInstance(string counterName, string instanceName);

	void IncrementTotalAndInstance(string counterName, string instanceName);
}
