using System;
using Newtonsoft.Json;

namespace Roblox.Platform.Chat.Events;

public class ChatEventMessageSourceJsonConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return true;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		return serializer.Deserialize<ChatEventMessageSource>(reader);
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
