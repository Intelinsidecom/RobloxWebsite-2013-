using System;

namespace Roblox.Platform.Membership;

public interface IBirthdateValidator
{
	/// <summary>
	/// Determines whether it is a valid birthdate based on the given date.
	/// </summary>
	/// <param name="date">The date.</param>
	/// <returns>True if it's a valid birthdate, otherwise false</returns>
	bool IsValidBirthdate(DateTime date);

	/// <summary>
	/// Determines whether it is a valid birthdate based on the given year, month and day.
	/// </summary>
	/// <param name="year">The year.</param>
	/// <param name="month">The month.</param>
	/// <param name="day">The day.</param>
	/// <returns>True if it is a valid birthdate, otherwise false.</returns>
	bool IsValidBirthdate(int year, int month, int day);
}
