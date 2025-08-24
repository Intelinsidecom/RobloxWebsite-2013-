using System;
using System.Diagnostics;

namespace Roblox.Platform.Math;

[DebuggerDisplay("'{StartTime}' to '{EndTime}'")]
public struct TimeSegment
{
	public DateTime StartTime { get; }

	public DateTime EndTime { get; }

	public TimeSegment(DateTime startTime, DateTime endTime)
	{
		this = default(TimeSegment);
		StartTime = startTime;
		EndTime = endTime;
	}

	public bool ContainsDateTime(DateTime dateTime)
	{
		if (StartTime >= dateTime)
		{
			return dateTime <= EndTime;
		}
		return false;
	}
}
