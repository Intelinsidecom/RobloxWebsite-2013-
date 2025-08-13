using System;

namespace Roblox.Platform.Membership.Commands;

/// <summary>
/// A platform object used to validate birthdates.
/// </summary>
public interface IBirthdateValidator
{
	/// <summary>
	/// Determines whether the date is a valid birthdate based on the given dates.
	/// </summary>
	/// <param name="nowDate">The current date.</param>
	/// <param name="date">The date to validate.</param>
	/// <returns>True if it's a valid birthdate, otherwise false</returns>
	bool IsBirthdateValid(DateTime nowDate, DateTime date);

	/// <summary>
	/// Determines whether the date is a valid birthdate based on the given nowDate, year, month and day.
	/// </summary>
	/// <param name="nowDate">The current date.</param>
	/// <param name="year">The year.</param>
	/// <param name="month">The month.</param>
	/// <param name="day">The day.</param>
	/// <returns>True if it is a valid birthdate, otherwise false.</returns>
	bool IsBirthdateValid(DateTime nowDate, int year, int month, int day);
}
