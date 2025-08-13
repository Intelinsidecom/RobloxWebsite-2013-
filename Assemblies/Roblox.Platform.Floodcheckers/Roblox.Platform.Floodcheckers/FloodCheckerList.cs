using System.Collections.Generic;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;

namespace Roblox.Platform.Floodcheckers;

public class FloodCheckerList : List<IFloodChecker>, IFloodChecker, IBasicFloodChecker
{
	public FloodCheckerList()
	{
	}

	public FloodCheckerList(int capacity)
		: base(capacity)
	{
	}

	public FloodCheckerList(IEnumerable<IFloodChecker> collection)
		: base(collection)
	{
	}

	/// <summary>
	/// Checks all the floodcheckers in the list and returns status of first flooded floodchecker.
	/// If none are flooded returns the result of the first floodchecker in the list.
	/// </summary>
	/// <returns><see cref="T:Roblox.FloodCheckers.Core.FloodCheckerStatus" /> of the first flooded floodchecker or if none are flooded then the first floodchecker in the list</returns>
	public IFloodCheckerStatus Check()
	{
		if (base.Count <= 0)
		{
			throw new PlatformException("List is empty.");
		}
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IFloodCheckerStatus status = enumerator.Current.Check();
				if (status.IsFlooded)
				{
					return status;
				}
			}
		}
		return base[0].Check();
	}

	/// <summary>
	/// Gets count of the first flooded floodchecker in the list
	/// </summary>
	/// <returns>count of the first flooded floodchecker in the list of if none are flooded then the count of the first floodchecker in the list</returns>
	public int GetCount()
	{
		return Check().Count;
	}

	/// <summary>
	/// Gets count over limit of the first flooded floodchecker in the list
	/// </summary>
	/// <returns>count over limit of the first flooded floodchecker in the list of if none are flooded then the count over limit of the first floodchecker in the list</returns>
	public int GetCountOverLimit()
	{
		return Check().CountOverLimit;
	}

	/// <summary>
	/// Checks if any floodchecker in the list is flooded
	/// </summary>
	/// <returns>returns true if it finds any flooded floodcheckers in the list</returns>
	public bool IsFlooded()
	{
		return Check().IsFlooded;
	}

	/// <summary>
	/// Updates count of each floodchecker in the list
	/// </summary>
	public void UpdateCount()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.UpdateCount();
		}
	}

	/// <summary>
	/// Resets count to zero for every floodchecker in the list
	/// </summary>
	public void Reset()
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Reset();
		}
	}
}
