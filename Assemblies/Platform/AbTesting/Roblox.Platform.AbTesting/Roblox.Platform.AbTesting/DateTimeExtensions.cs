using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting;

public static class DateTimeExtensions
{
	/// <summary>
	/// Calculates the number of days left (ceiling) until a day limit is reached.
	/// </summary>
	/// <param name="baseDate">The DateTime to call this function on.</param>
	/// <param name="currentDate">The DateTime to calculate from the base date.</param>
	/// <param name="dayLimit">The day limit.</param>
	/// <returns>The number of days left until the day limit.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="currentDate" /> is before <paramref name="baseDate" /></exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="dayLimit" /> is negative.</exception>
	public static int CalculateDaysLeft(this DateTime baseDate, DateTime currentDate, int dayLimit)
	{
		if (DateTime.Compare(baseDate, currentDate) > 0)
		{
			throw new PlatformArgumentException("'currentDate' must be later than 'baseDate'.");
		}
		if (dayLimit < 0)
		{
			throw new PlatformArgumentException("'dayLimit' cannot be negative.");
		}
		int diff = (int)Math.Floor((currentDate - baseDate).TotalDays);
		return dayLimit - diff;
	}
}
