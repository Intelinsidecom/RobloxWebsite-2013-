using System;

namespace Roblox.Random;

/// <summary>
/// For invoking an action based on a percentage
/// </summary>
public interface IPercentageInvoker
{
	/// <summary>
	/// Invokes the action only the given percentage of times this method is called.
	/// </summary>
	/// <param name="action">The action</param>
	/// <param name="invokePercentage">The percentage of times to call the action.</param>
	void InvokeAction(Action action, int invokePercentage);
}
