using System;

namespace Roblox.Time;

public static class DateTimeExtensions
{
	private const int _TicksPerNanosecond = 100;

	private static readonly DateTime _UnixEpochStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public static long ToUnixEpochTimeInMilliseconds(this DateTime startDate)
	{
		return (long)Math.Round((startDate.ToUniversalTime() - _UnixEpochStartTime).TotalMilliseconds);
	}

	public static long ToUnixEpochTimeInNanoseconds(this DateTime startDate)
	{
		return (startDate.ToUniversalTime() - _UnixEpochStartTime).Ticks * 100;
	}

	public static DateTime ToMillisecondsDateTime(this string unixTimeString)
	{
		return long.Parse(unixTimeString).ToMillisecondsDateTime();
	}

	public static DateTime ToMillisecondsDateTime(this long unixTimeLong)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(unixTimeLong);
		return _UnixEpochStartTime + timeSpan;
	}

	public static DateTime ToNanosecondsDateTime(this string unixTimeString)
	{
		return long.Parse(unixTimeString).ToNanosecondsDateTime();
	}

	public static DateTime ToNanosecondsDateTime(this long unixTimeLong)
	{
		TimeSpan timeSpan = TimeSpan.FromTicks(unixTimeLong / 100);
		return _UnixEpochStartTime + timeSpan;
	}
}
