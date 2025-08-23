using System;

namespace Roblox.Web.Code.Util;

public static class DateTimeExtensions
{
	private static readonly long UnixEpochTicks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;

	/// <summary>
	/// .NET Ticks are different from JSON Ticks.
	/// http://www.codeproject.com/Tips/467697/Converting-a-NET-DateTime-object-to-a-JavaScript-D
	/// </summary>
	/// <param name="value"></param>
	/// <returns></returns>
	public static long? ToJsonTicks(this DateTime? value)
	{
		if (value.HasValue)
		{
			return value.Value.ToJsonTicks();
		}
		return null;
	}

	public static long ToJsonTicks(this DateTime value)
	{
		return (value.ToUniversalTime().Ticks - UnixEpochTicks) / 10000;
	}
}
