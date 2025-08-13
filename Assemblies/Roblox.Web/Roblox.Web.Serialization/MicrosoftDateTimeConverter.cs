using System;
using Newtonsoft.Json;

namespace Roblox.Web.Serialization;

/// <summary>
/// Class used to make DateTime serialization compatible with consumers of endpoints that previously used the JavascriptSerializer
/// </summary>
[Obsolete("Only use this when converting existing .NET MVC endpoints to using Json.NET when it is not possible to change consumer behavior. Otherwise use default Json.NET DateTime serialization.")]
public class MicrosoftDateTimeConverter : JsonConverter
{
	private static readonly long _DatetimeMinTimeTicks = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;

	public override bool CanRead => false;

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		object obj;
		if ((obj = value) is DateTime)
		{
			writer.WriteRawValue($"\"\\/Date({(((DateTime)obj).ToUniversalTime().Ticks - _DatetimeMinTimeTicks) / 10000})\\/\"");
		}
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(DateTime);
	}
}
