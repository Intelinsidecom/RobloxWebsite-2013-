using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Marketing;

internal static class EligibilityExtensions
{
	internal static bool CreatedWithinTimePeriod(this IUser user, IBrowserTracker browserTracker, DateTime? startDate, DateTime? endDate)
	{
		if (browserTracker == null)
		{
			return false;
		}
		DateTime visitorCreatedDate = user?.Created ?? browserTracker.Created;
		if (!startDate.HasValue && !endDate.HasValue)
		{
			return true;
		}
		DateTime value;
		DateTime? dateTime;
		if (startDate.HasValue && !endDate.HasValue)
		{
			value = visitorCreatedDate;
			dateTime = startDate;
			return value > dateTime;
		}
		if (!startDate.HasValue && endDate.HasValue)
		{
			value = visitorCreatedDate;
			dateTime = endDate;
			return value < dateTime;
		}
		value = visitorCreatedDate;
		dateTime = startDate;
		if (value > dateTime)
		{
			value = visitorCreatedDate;
			dateTime = endDate;
			return value < dateTime;
		}
		return false;
	}

	internal static bool CreatedBeforeDate(this IUser user, IBrowserTracker browserTracker, DateTime date)
	{
		if (browserTracker == null)
		{
			return false;
		}
		return (user?.Created ?? browserTracker.Created) < date;
	}
}
