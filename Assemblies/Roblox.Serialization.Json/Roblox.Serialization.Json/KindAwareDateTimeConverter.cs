using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Serialization.Json;

public class KindAwareDateTimeConverter : IsoDateTimeConverter
{
	private const string _CstZoneId = "Central Standard Time";

	private const string _NotSupportedKindExceptionMessage = "DateTimeKind Unspecified is not supported.";

	public DateTimeKind TargetReadDateTimeKind { get; }

	public DateTimeKind TargetWriteDateTimeKind { get; }

	public KindAwareDateTimeConverter()
		: this(DateTimeKind.Utc, DateTimeKind.Utc)
	{
	}

	public KindAwareDateTimeConverter(DateTimeKind targetReadDateTimeKind)
		: this(targetReadDateTimeKind, DateTimeKind.Utc)
	{
	}

	public KindAwareDateTimeConverter(DateTimeKind targetReadDateTimeKind, DateTimeKind targetWriteDateTimeKind)
	{
		if (targetReadDateTimeKind == DateTimeKind.Unspecified)
		{
			throw new ArgumentException("DateTimeKind Unspecified is not supported.", "targetReadDateTimeKind");
		}
		TargetReadDateTimeKind = targetReadDateTimeKind;
		if (targetWriteDateTimeKind == DateTimeKind.Unspecified)
		{
			throw new ArgumentException("DateTimeKind Unspecified is not supported.", "targetWriteDateTimeKind");
		}
		TargetWriteDateTimeKind = targetWriteDateTimeKind;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		object obj = base.ReadJson(reader, objectType, existingValue, serializer);
		if (obj != null && obj is DateTime dateTime)
		{
			return (TargetReadDateTimeKind == DateTimeKind.Utc) ? TranslateToUtc(dateTime) : TranslateToLocal(dateTime);
		}
		return obj;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		if (value != null && value is DateTime dateTime)
		{
			DateTime dateTime2 = ((TargetWriteDateTimeKind == DateTimeKind.Utc) ? TranslateToUtc(dateTime) : TranslateToLocal(dateTime));
			base.WriteJson(writer, (object)dateTime2, serializer);
		}
		else
		{
			base.WriteJson(writer, value, serializer);
		}
	}

	private static DateTime TranslateToUtc(DateTime dateTime)
	{
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return dateTime;
		}
		if (dateTime.Kind != 0)
		{
			return dateTime.ToUniversalTime();
		}
		return TimeZoneInfo.ConvertTimeToUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time"));
	}

	private static DateTime TranslateToLocal(DateTime dateTime)
	{
		if (dateTime.Kind == DateTimeKind.Local)
		{
			return dateTime;
		}
		if (dateTime.Kind != 0)
		{
			return dateTime.ToLocalTime();
		}
		return DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
	}
}
