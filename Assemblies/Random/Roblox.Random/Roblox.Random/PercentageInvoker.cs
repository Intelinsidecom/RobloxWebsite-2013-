using System;

namespace Roblox.Random;

/// <inheritdoc />
public class PercentageInvoker : IPercentageInvoker
{
	private readonly IRandom _Random;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Random.PercentageInvoker" /> class
	/// </summary>
	/// <param name="random"></param>
	public PercentageInvoker(IRandom random)
	{
		_Random = random ?? throw new ArgumentNullException("random");
	}

	/// <inheritdoc />
	public void InvokeAction(Action action, int invokePercentage)
	{
		if (invokePercentage < 0 || invokePercentage > 100)
		{
			throw new ArgumentOutOfRangeException(string.Format("{0} must be between 0 and 100.", "invokePercentage"));
		}
		if (_Random.Next() % 100 < invokePercentage)
		{
			action();
		}
	}
}
