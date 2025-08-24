using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Roblox.CachingV2.Core;

public class NewtonsoftJsonSerializer : ISerializer
{
	private class GuidToBase64StringJsonConverter : JsonConverter
	{
		public static GuidToBase64StringJsonConverter Instance { get; } = new GuidToBase64StringJsonConverter();


		private GuidToBase64StringJsonConverter()
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Guid);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.String)
			{
				throw new JsonSerializationException();
			}
			try
			{
				return new Guid(Convert.FromBase64String(string.Concat(reader.Value, "==")));
			}
			catch (Exception innerException)
			{
				throw new JsonSerializationException($"Failed to deserialize value to GUID: {reader.Value}.", innerException);
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			string text = Convert.ToBase64String(((Guid)value).ToByteArray());
			text = text.Substring(0, text.Length - 2);
			writer.WriteValue(text);
		}
	}

	private readonly JsonSerializerSettings _JsonSerializerSettings;

	public NewtonsoftJsonSerializer()
	{
		_JsonSerializerSettings = new JsonSerializerSettings
		{
			Converters = new List<JsonConverter>
			{
				GuidToBase64StringJsonConverter.Instance,
				CacheVersionToken.CacheVersionTokenJsonConverter.Instance
			},
			DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
		};
	}

	public byte[] Serialize<T>(T value)
	{
		string s;
		try
		{
			s = JsonConvert.SerializeObject(value, _JsonSerializerSettings);
		}
		catch (JsonException innerException)
		{
			throw new SerializationException($"JSON serializer failed to serialize object of type '{typeof(T).Name}'.", innerException);
		}
		return Encoding.UTF8.GetBytes(s);
	}

	public T Deserialize<T>(byte[] bytes)
	{
		NullChecker.ThrowIfNull(bytes, "bytes");
		string @string = Encoding.UTF8.GetString(bytes);
		try
		{
			return JsonConvert.DeserializeObject<T>(@string, _JsonSerializerSettings);
		}
		catch (JsonException innerException)
		{
			throw new SerializationException($"JSON serializer failed to deserialize to object of type '{typeof(T).Name}'.", innerException);
		}
	}
}
