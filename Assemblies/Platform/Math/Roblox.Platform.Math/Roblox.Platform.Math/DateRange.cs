using System;

namespace Roblox.Platform.Math;

public sealed class DateRange : IEquatable<DateRange>
{
	private DateTime _StartDate;

	private DateTime _EndDate;

	public DateTime StartDate
	{
		get
		{
			return _StartDate;
		}
		set
		{
			AssertStartDateFollowsEndDate(value, _EndDate);
			_StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return _EndDate;
		}
		set
		{
			AssertStartDateFollowsEndDate(_StartDate, value);
			_EndDate = value;
		}
	}

	public DateRange(DateTime startDate, DateTime endDate)
	{
		AssertStartDateFollowsEndDate(startDate, endDate);
		_StartDate = startDate;
		_EndDate = endDate;
	}

	public bool Update(DateTime possibleNewEndpoint)
	{
		if (possibleNewEndpoint < _StartDate)
		{
			StartDate = possibleNewEndpoint;
			return true;
		}
		if (possibleNewEndpoint > _EndDate)
		{
			EndDate = possibleNewEndpoint;
			return true;
		}
		return false;
	}

	public bool Equals(DateRange other)
	{
		if (other == null)
		{
			return false;
		}
		if (_StartDate == other.StartDate)
		{
			return _EndDate == other.EndDate;
		}
		return false;
	}

	private void AssertStartDateFollowsEndDate(DateTime startDate, DateTime endDate)
	{
		if (endDate < startDate)
		{
			throw new InvalidOperationException("Start Date must be less than or equal to End Date");
		}
	}
}
