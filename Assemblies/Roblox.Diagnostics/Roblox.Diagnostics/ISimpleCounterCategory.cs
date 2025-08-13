namespace Roblox.Diagnostics;

public interface ISimpleCounterCategory
{
	/// <summary>
	/// Increment the Total instance for the specified counter
	/// </summary>
	/// <param name="counterName"></param>
	void IncrementTotal(string counterName);

	/// <summary>
	/// Increments the specified instance (or creates it if it doesn't exist) for the specifed counter
	/// </summary>
	/// <param name="counterName"></param>
	/// <param name="instanceName"></param>
	void IncrementInstance(string counterName, string instanceName);

	/// <summary>
	/// Increments both the Total instance and the specified instance for the specified counter. 
	/// Equivalent to calling both IncrementTotal and IncrementInstance
	/// </summary>
	/// <param name="counterName"></param>
	/// <param name="instanceName"></param>
	void IncrementTotalAndInstance(string counterName, string instanceName);
}
