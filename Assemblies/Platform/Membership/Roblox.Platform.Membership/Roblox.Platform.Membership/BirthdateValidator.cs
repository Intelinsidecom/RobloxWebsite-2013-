using System;

namespace Roblox.Platform.Membership;

public class BirthdateValidator : IBirthdateValidator
{
	private const int _MaxAge = 100;

	public bool IsValidBirthdate(DateTime date)
	{
		DateTime minDate = DateTime.Now.AddYears(-100);
		if (date <= DateTime.Now)
		{
			return date > minDate;
		}
		return false;
	}

	public bool IsValidBirthdate(int year, int month, int day)
	{
		try
		{
			DateTime date = new DateTime(year, month, day);
			return IsValidBirthdate(date);
		}
		catch
		{
			return false;
		}
	}
}
