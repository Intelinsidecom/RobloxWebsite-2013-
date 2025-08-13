using System;

namespace Roblox.Platform.Membership;

/// <summary>
/// An interface for a helper class that handles age-related checks
/// </summary>
public interface IAgeChecker
{
	/// <summary>
	/// Returns the current age, in whole number years, of a given birthdate, relative to server time (Central Time).
	///
	/// [Warning] Current implementation uses server time (Central Time) to compare against birthdate (no product spec on timezone treatment)<br />
	/// </summary>
	int GetAgeFromDateInWholeNumberYears(DateTime birthdate);

	/// <summary>
	/// Returns the minimum age within the age bracket range.
	/// </summary>
	int GetSafeEffectiveAgeFromAgeBracket(AgeBracket ageBracket);

	/// <summary>
	/// Determines whether a user (or guest) meets the minimum age requirement, relative to server time (Central Time).<br />
	/// Uses lower bound of age bracket as effective age if birthdate is unavailable.<br />
	///
	/// [Warning] Current implementation uses server time (Central Time) to compare against birthdate (no product spec on timezone treatment)<br />
	/// Users in New Zealand with birthdays will not meet age requirement until 17~18 hours into their birthday (5~6pm the day of), depending Daylight Savings Time (different start/end dates for America vs New Zealand).<br />
	/// Users in Hawaii with birthdays will meet age requirement 4~5 hours prior to their birthday (7~8pm the day before) depending on Daylight Savings Time (which Hawaii does not observe).<br />
	/// Users in Chicago with birthdays will have things just right.
	/// </summary>
	bool UserMeetsMinimumAgeRequirement(IUser nullableUser, int minAgeInYears);

	/// <summary>
	/// Determins if a user (or guest) is younger than the specified age, using the user's safe effective age.
	/// </summary>
	bool IsUserYoungerThan(IUser nullableUser, int ageInYears);

	/// <summary>
	/// Approximates the user's age in years.
	///
	/// [Warning] Current implementation is not accurate.  Anything after two decimal places cannot be trusted
	/// [Warning] Current implementation uses server time (Central Time) to compare against birthdate (no product spec on timezone treatment)
	/// A person exactly 365 days old will have age of 0.9993... regardless of whether it is a leap year.
	/// Users in Central Time (eg Chicago) may have their age wrong (too low) by up to 18 hours 
	/// (for New Zealand, up to 36 hours; for Hawaii, up to 13 hours).
	/// </summary>
	double? ApproximateAgeInDoubleYears(IUser user);

	/// <summary>
	/// Returns the number of whole years between two dates. Always rounds down.
	/// </summary>
	/// <param name="dateA">Date A.</param>
	/// <param name="dateB">Date B.</param>
	/// <returns>The number of (positive) whole years between two dates.</returns>
	int GetNumberOfWholeYearsBetweenTwoDates(DateTime dateA, DateTime dateB);

	/// <summary>
	/// Returns the age bracket of a given birthdate, relative to server time (Central Time).
	/// </summary>
	/// <param name="date">The birthdate</param>
	/// <returns>The <see cref="T:Roblox.Platform.Membership.AgeBracket" /></returns>
	AgeBracket GetAgeBracketFromDate(DateTime date);
}
