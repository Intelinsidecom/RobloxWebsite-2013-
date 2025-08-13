using System;
using System.Collections.Generic;

namespace Roblox.Platform.Math.Numerics;

/// <summary>
/// Sorted list of evenly spaced DateTime points. The list is sorted by
/// construct, and is always returned in a sorted state.
/// </summary>
public sealed class DateTimeGrid
{
	private readonly List<DateTime> _Grid = new List<DateTime>();

	public DateTime StartDate { get; }

	public TimeSpan Interval { get; }

	public int Count { get; }

	/// <summary>
	/// Returns an ICollection instead of an IEnumerable because the expected usage
	/// is mathematical: we will want to know count and be able to go to count-1.
	/// </summary>
	public ICollection<DateTime> GridPoints => new List<DateTime>(_Grid);

	/// <summary>
	/// Construct a uniform DateTime grid
	/// </summary>
	/// <param name="startDate">The grid starting point</param>
	/// <param name="interval">The timespan between grid points</param>
	/// <param name="numberOfGridPoints">The number of grid points, inclusive. The number of intervals is numberOfGridPoints-1</param>
	public DateTimeGrid(DateTime startDate, TimeSpan interval, int numberOfGridPoints)
	{
		StartDate = startDate;
		Interval = interval;
		Count = numberOfGridPoints;
		if (Count > 0)
		{
			DateTime lastPoint = startDate;
			_Grid.Add(StartDate);
			for (int i = 1; i < numberOfGridPoints; i++)
			{
				lastPoint = lastPoint.Add(interval);
				_Grid.Add(lastPoint);
			}
		}
	}

	public static IList<DateTime> BuildGridPoints(DateTime startDate, DateTime endDate, int numberOfGridPoints)
	{
		long ticks = (endDate - startDate).Ticks / numberOfGridPoints;
		List<DateTime> points = new List<DateTime>(numberOfGridPoints);
		DateTime lastPoint = startDate;
		points.Add(startDate);
		for (int i = 1; i < numberOfGridPoints; i++)
		{
			lastPoint = lastPoint.AddTicks(ticks);
			points.Add(lastPoint);
		}
		return points;
	}
}
