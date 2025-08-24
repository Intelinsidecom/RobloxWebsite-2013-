using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Platform.Math;

public static class TimeSplitter
{
	public static IEnumerable<TimeSegment> GetCompleteParts(IEnumerable<TimeSegment> segments, DateTime rangeStartTime, DateTime rangeEndTime)
	{
		return segments.Where((TimeSegment s) => s.StartTime >= rangeStartTime && s.EndTime <= rangeEndTime);
	}

	public static IEnumerable<TimeSegment> SplitIntoParts(DateTime rangeStartTime, DateTime rangeEndTime, AggregationTimeSpan timeSpan, TimeSpan timeZoneOffset)
	{
		DateTime startTime = GetPartStartTime(rangeStartTime, timeSpan, timeZoneOffset);
		TimeSpan partTimeSpan = GetPartTimeSpan(timeSpan);
		DateTime chunkEnd;
		do
		{
			chunkEnd = ((timeSpan == AggregationTimeSpan.MonthPacific) ? startTime.AddMonths(1) : startTime.Add(partTimeSpan));
			yield return new TimeSegment(startTime, chunkEnd);
			startTime = chunkEnd;
		}
		while (chunkEnd < rangeEndTime);
	}

	public static IEnumerable<TimeSegment> SplitIntoCompleteParts(DateTime rangeStartTime, DateTime rangeEndTime, AggregationTimeSpan timeSpan, TimeSpan timeZoneOffset)
	{
		return GetCompleteParts(SplitIntoParts(rangeStartTime, rangeEndTime, timeSpan, timeZoneOffset), rangeStartTime, rangeEndTime);
	}

	private static DateTime GetPartStartTime(DateTime rangeStartTime, AggregationTimeSpan timeSpan, TimeSpan timeZoneOffset)
	{
		return timeSpan switch
		{
			AggregationTimeSpan.FifteenMinutes => rangeStartTime.Date.AddHours(rangeStartTime.Hour).AddMinutes(rangeStartTime.Minute - rangeStartTime.Minute % 15), 
			AggregationTimeSpan.Hour => rangeStartTime.Date.AddHours(rangeStartTime.Hour), 
			AggregationTimeSpan.DayPacific => rangeStartTime.Date.Add(-timeZoneOffset), 
			AggregationTimeSpan.WeekPacific => rangeStartTime.Date.AddDays(0 - rangeStartTime.DayOfWeek + 1).Add(-timeZoneOffset), 
			AggregationTimeSpan.MonthPacific => rangeStartTime.Date.AddDays(-rangeStartTime.Day + 1).Add(-timeZoneOffset), 
			_ => rangeStartTime, 
		};
	}

	private static TimeSpan GetPartTimeSpan(AggregationTimeSpan timeSpan)
	{
		return timeSpan switch
		{
			AggregationTimeSpan.FifteenMinutes => TimeSpan.FromMinutes(15.0), 
			AggregationTimeSpan.Hour => TimeSpan.FromHours(1.0), 
			AggregationTimeSpan.DayPacific => TimeSpan.FromDays(1.0), 
			AggregationTimeSpan.WeekPacific => TimeSpan.FromDays(7.0), 
			AggregationTimeSpan.MonthPacific => TimeSpan.FromDays(30.0), 
			_ => TimeSpan.FromHours(1.0), 
		};
	}
}
