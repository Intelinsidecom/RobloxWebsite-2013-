using System;
using Roblox.Data;

namespace Roblox.Platform.Membership;

internal class AgeChecker : IAgeChecker
{
	private static AgeChecker _Singleton;

	public static IAgeChecker GetSingleton()
	{
		if (_Singleton == null)
		{
			_Singleton = new AgeChecker();
		}
		return _Singleton;
	}

	internal static void SetSingleton(AgeChecker singleton)
	{
		_Singleton = singleton;
	}

	internal virtual DateTime GetNow()
	{
		return DateTime.Now;
	}

	public virtual int GetAgeFromDateInWholeNumberYears(DateTime birthdate)
	{
		DateTime now = GetNow();
		int yearDiff = now.Year - birthdate.Year;
		DateTime nYearsAgoToday = now.AddYears(-yearDiff);
		if (birthdate > nYearsAgoToday)
		{
			return yearDiff - 1;
		}
		return yearDiff;
	}

	public virtual int GetSafeEffectiveAgeFromAgeBracket(AgeBracket ageBracket)
	{
		return ageBracket switch
		{
			AgeBracket.Age13OrOver => 13, 
			AgeBracket.AgeUnder13 => 0, 
			_ => throw new ArgumentOutOfRangeException("ageBracket"), 
		};
	}

	internal virtual int GetUserSafeEffectiveAgeInWholeNumberYears(IUser nullableUser)
	{
		int effectiveAge = 0;
		if (nullableUser == null)
		{
			return effectiveAge;
		}
		if (nullableUser.Birthdate.HasValue)
		{
			return GetAgeFromDateInWholeNumberYears(nullableUser.Birthdate.Value);
		}
		try
		{
			return GetSafeEffectiveAgeFromAgeBracket(nullableUser.AgeBracket);
		}
		catch (ArgumentOutOfRangeException)
		{
			throw new DataIntegrityException("age bracket is out of range");
		}
	}

	public bool UserMeetsMinimumAgeRequirement(IUser nullableUser, int minAgeInYears)
	{
		return GetUserSafeEffectiveAgeInWholeNumberYears(nullableUser) >= minAgeInYears;
	}

	public bool IsUserYoungerThan(IUser nullableUser, int ageInYears)
	{
		return GetUserSafeEffectiveAgeInWholeNumberYears(nullableUser) < ageInYears;
	}

	public double? ApproximateAgeInDoubleYears(IUser user)
	{
		if (user == null || !user.Birthdate.HasValue)
		{
			return null;
		}
		DateTime now = GetNow();
		DateTime birthdate = user.Birthdate.Value;
		return (now - birthdate).TotalDays / 365.25;
	}

	/// <inheritdoc />
	public int GetNumberOfWholeYearsBetweenTwoDates(DateTime dateA, DateTime dateB)
	{
		if (dateA > dateB)
		{
			DateTime dateTime = dateA;
			dateA = dateB;
			dateB = dateTime;
		}
		int yearDiff = dateB.Year - dateA.Year;
		DateTime dateBMinusYearDiff = dateB.AddYears(-yearDiff);
		if (dateA > dateBMinusYearDiff)
		{
			return yearDiff - 1;
		}
		return yearDiff;
	}

	/// <inheritdoc />
	public AgeBracket GetAgeBracketFromDate(DateTime date)
	{
		if (GetAgeFromDateInWholeNumberYears(date) >= 13)
		{
			return AgeBracket.Age13OrOver;
		}
		return AgeBracket.AgeUnder13;
	}
}
