using System;
using Newtonsoft.Json;

namespace Roblox.Time;

/// <summary>
/// Represents an instant in time, specified in UTC time. This is a useful alternative to the
/// DateTime class to ensure that all times are explicitly in UTC and treated consistently
/// </summary>
public class UtcInstant : IComparable<UtcInstant>
{
	private readonly DateTime _DateTime;

	public long Ticks
	{
		get
		{
			DateTime dateTime = _DateTime;
			return dateTime.Ticks;
		}
	}

	/// <summary>
	/// Constructs a new UtcInstant from the DateTime provided
	/// </summary>
	/// <param name="dateTime">UTC Kind DateTime to be represented by the Instant</param>
	/// <exception cref="T:Roblox.Time.NonUtcDateTimeArgumentException">Thrown when dateTime is not a UTC DateTime</exception>
	public UtcInstant(DateTime dateTime)
	{
		_DateTime = dateTime;
		if (dateTime.Kind != DateTimeKind.Utc)
		{
			throw new NonUtcDateTimeArgumentException();
		}
	}

	/// <summary>
	/// Constructs a new UtcInstant from the <see cref="T:System.DateTimeOffset" /> provided.
	/// </summary>
	/// <param name="dateTimeOffset"></param>
	public UtcInstant(DateTimeOffset dateTimeOffset)
	{
		_DateTime = dateTimeOffset.UtcDateTime;
	}

	/// <summary>
	/// Constructs a new UtcInstant from the provided ticks
	/// </summary>
	/// <param name="ticks"></param>
	[JsonConstructor]
	public UtcInstant(long ticks)
	{
		_DateTime = new DateTime(ticks, DateTimeKind.Utc);
	}

	public DateTime ToDateTime()
	{
		return _DateTime;
	}

	public DateTimeOffset ToDateTimeOffset()
	{
		return new DateTimeOffset(_DateTime);
	}

	public int CompareTo(UtcInstant other)
	{
		if ((object)this == other)
		{
			return 0;
		}
		if ((object)other == null)
		{
			return 1;
		}
		return ToDateTime().CompareTo(other.ToDateTime());
	}

	public override string ToString()
	{
		DateTime dateTime = _DateTime;
		return dateTime.ToString();
	}

	public override int GetHashCode()
	{
		DateTime dateTime = _DateTime;
		return dateTime.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		UtcInstant instant = obj as UtcInstant;
		if (instant == null)
		{
			return false;
		}
		return Ticks == instant.Ticks;
	}

	public static implicit operator DateTime(UtcInstant utcInstant)
	{
		return utcInstant._DateTime;
	}

	public static implicit operator DateTimeOffset(UtcInstant utcInstant)
	{
		return new DateTimeOffset(utcInstant._DateTime);
	}

	public static bool operator ==(UtcInstant left, UtcInstant right)
	{
		if ((object)left == right)
		{
			return true;
		}
		if ((object)left == null || (object)right == null)
		{
			return false;
		}
		return left.Equals(right);
	}

	public static bool operator !=(UtcInstant left, UtcInstant right)
	{
		return !(left == right);
	}

	/// <summary>
	/// Method to coerce a DateTime into a UtcInstant, even if provided with a non-UTC time. Note that this
	/// may produce an incorrect result if an Unspecified type of DateTime is provided - that is unavoidable
	/// </summary>
	/// <param name="dateTime"></param>
	/// <param name="onDateTimeCoerced">an Action that will be called if a DateTime coercion occurs, passing in the DateTimeKind of the DateTime provided</param>
	/// <returns></returns>
	public static UtcInstant CoerceFrom(DateTime dateTime, Action<DateTimeKind> onDateTimeCoerced = null)
	{
		switch (dateTime.Kind)
		{
		case DateTimeKind.Utc:
			return new UtcInstant(dateTime);
		default:
			onDateTimeCoerced?.Invoke(dateTime.Kind);
			return new UtcInstant(dateTime.ToUniversalTime());
		}
	}
}
