using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Roblox.Serialization.Json;

public class DefinedPropertyTrackableImplConverter : JsonConverter
{
	private static ConcurrentDictionary<Type, IReadOnlyDictionary<string, PropertyInfo>> JsonFieldNameToPropertyMappings { get; } = new ConcurrentDictionary<Type, IReadOnlyDictionary<string, PropertyInfo>>();


	public override bool CanWrite => false;

	public override bool CanConvert(Type objectType)
	{
		if (objectType.IsClass)
		{
			return objectType.GetInterfaces().Any((Type i) => i == typeof(IDefinedPropertyTrackable));
		}
		return false;
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JObject jObject = JObject.Load(reader);
		IDefinedPropertyTrackable definedPropertyTrackable = ((IDefinedPropertyTrackable)existingValue) ?? ((IDefinedPropertyTrackable)Activator.CreateInstance(objectType));
		definedPropertyTrackable.DefinedPropertyNames.Clear();
		foreach (KeyValuePair<string, PropertyInfo> jsonFieldToPropertyMapping in GetJsonFieldToPropertyMappings(objectType))
		{
			string key = jsonFieldToPropertyMapping.Key;
			PropertyInfo value = jsonFieldToPropertyMapping.Value;
			if (jObject.TryGetValue(key, out var value2))
			{
				if (value2.Type != JTokenType.Null)
				{
					value.SetValue(definedPropertyTrackable, value2.ToObject(value.PropertyType, serializer));
				}
				definedPropertyTrackable.DefinedPropertyNames.Add(value.Name);
			}
		}
		return definedPropertyTrackable;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		throw new NotImplementedException();
	}

	private IReadOnlyDictionary<string, PropertyInfo> GetJsonFieldToPropertyMappings(Type objectType)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (JsonFieldNameToPropertyMappings.TryGetValue(objectType, out var value))
		{
			return value;
		}
		Dictionary<string, PropertyInfo> dictionary = new Dictionary<string, PropertyInfo>();
		PropertyInfo[] properties = objectType.GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			DataMemberAttribute customAttribute = ((MemberInfo)propertyInfo).GetCustomAttribute<DataMemberAttribute>();
			if (customAttribute != null && propertyInfo.CanWrite && !(propertyInfo.Name == "DefinedPropertyNames"))
			{
				if (dictionary.ContainsKey(customAttribute.Name))
				{
					throw new InvalidDataContractException(string.Format("{0} with {1} property value equal to {2} specified more than once.", "DataMemberAttribute", "Name", customAttribute.Name));
				}
				dictionary.Add(customAttribute.Name, propertyInfo);
			}
		}
		JsonFieldNameToPropertyMappings.TryAdd(objectType, dictionary);
		return new ReadOnlyDictionary<string, PropertyInfo>(dictionary);
	}
}
