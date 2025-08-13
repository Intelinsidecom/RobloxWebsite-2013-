namespace Roblox.FloodCheckers.Core;

public interface IBasicFloodChecker
{
	/// <summary>
	/// Indicates where or not the current count has reached or exceeded the limit
	/// </summary>
	/// <returns></returns>
	bool IsFlooded();

	/// <summary>
	/// Increases the current count of the FloodChecker by one
	/// </summary>
	void UpdateCount();

	/// <summary>
	/// Resets the count of the FloodChecker to zero
	/// </summary>
	void Reset();
}
