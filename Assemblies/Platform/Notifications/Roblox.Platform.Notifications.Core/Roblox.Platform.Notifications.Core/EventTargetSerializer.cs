using System;
using Newtonsoft.Json;

namespace Roblox.Platform.Notifications.Core;

/// <summary>
/// This implements a custom <see cref="T:Newtonsoft.Json.JsonConverter" /> to convert the <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> to and from a simple string.
/// </summary>
/// <remarks>
/// This is required to retain the backwards compability with consumers who are seralizing their notification.
/// </remarks>
public class EventTargetSerializer : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(EventTarget);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		EventTarget eventTarget = value as EventTarget;
		if (eventTarget == null)
		{
			throw new ArgumentException("This seralizer can only seralize objects of type EventTarget.", "value");
		}
		if (long.TryParse(eventTarget, out var eventTargetId))
		{
			writer.WriteValue(eventTargetId);
		}
		else
		{
			writer.WriteValue(eventTarget.ToString());
		}
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.String)
		{
			return new EventTarget((string)reader.Value);
		}
		if (reader.TokenType == JsonToken.Integer)
		{
			return new EventTarget((long)reader.Value);
		}
		return null;
	}
}
