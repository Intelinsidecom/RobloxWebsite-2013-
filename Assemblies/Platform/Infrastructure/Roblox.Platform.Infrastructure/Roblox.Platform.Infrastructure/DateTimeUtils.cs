using System;

namespace Roblox.Platform.Infrastructure;

/// <summary>
/// The DateTime columns in InfraDb are all in Central time zone. This class can be used to convert those to UTC before returning the data.
/// </summary>
internal static class DateTimeUtils
{
	private static readonly TimeZoneInfo _CstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");

	internal static DateTime ConvertCentralDateTimeToUtc(DateTime dateTimeInCentralTimeZone)
	{
		return TimeZoneInfo.ConvertTimeToUtc(dateTimeInCentralTimeZone, _CstTimeZone);
	}
}
