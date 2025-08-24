namespace Roblox.FloodCheckers.Core;

public interface IFloodChecker : IBasicFloodChecker
{
	/// <summary>
	/// Returns the current state of the FloodChecker
	/// </summary>
	/// <returns></returns>
	IFloodCheckerStatus Check();

	/// <summary>
	/// Gets the current count of the FloodChecker
	/// </summary>
	/// <returns></returns>
	int GetCount();

	/// <summary>
	/// Gets the magnitude that count currently exceeds the limit.
	/// If the count is currently at or below the limit this will return zero.
	/// </summary>
	/// <returns></returns>
	int GetCountOverLimit();
}
