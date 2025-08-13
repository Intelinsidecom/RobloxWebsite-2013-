using System;

namespace Roblox.Platform.Membership.Commands;

internal class BirthdateValidator : IBirthdateValidator
{
	private const int _MaxAge = 100;

	public bool IsBirthdateValid(DateTime nowDate, DateTime date)
	{
		DateTime minDate = nowDate.AddYears(-100);
		if (date <= nowDate)
		{
			return date > minDate;
		}
		return false;
	}

	public bool IsBirthdateValid(DateTime nowDate, int year, int month, int day)
	{
		try
		{
			DateTime date = new DateTime(year, month, day);
			return IsBirthdateValid(nowDate, date);
		}
		catch
		{
			return false;
		}
	}
}
