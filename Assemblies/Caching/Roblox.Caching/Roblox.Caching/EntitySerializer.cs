using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Roblox.Caching.Interfaces;
using Roblox.Caching.Properties;
using Roblox.Caching.Shared;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Caching;

internal class EntitySerializer : IEntitySerializer
{
	private class NonPublicPropertiesResolver : DefaultContractResolver
	{
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			List<JsonProperty> list = new List<JsonProperty>();
			foreach (PropertyInfo item in from p in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where p.CanRead && p.CanWrite
				select p)
			{
				JsonProperty jsonProperty = CreateProperty(item, memberSerialization);
				jsonProperty.Writable = true;
				jsonProperty.Readable = true;
				list.Add(jsonProperty);
			}
			foreach (FieldInfo item2 in from f in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
				where f.IsPublic || f.IsAssembly
				select f)
			{
				JsonProperty jsonProperty2 = CreateProperty(item2, memberSerialization);
				jsonProperty2.Writable = true;
				jsonProperty2.Readable = true;
				list.Add(jsonProperty2);
			}
			return list;
		}
	}

	private static readonly ConcurrentDictionary<Type, (ConstructorInfo constructor, Type dalType)> _EntityConstructors = new ConcurrentDictionary<Type, (ConstructorInfo, Type)>();

	private const string _Category = "Roblox.Caching.EntitySerializer";

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	private static readonly JsonSerializerSettings _JsonSerializerSettings = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.All,
		ContractResolver = new NonPublicPropertiesResolver()
	};

	private static readonly JsonSerializerSettings _JsonSerializerSettingsIgnoreTypes = new JsonSerializerSettings
	{
		TypeNameHandling = TypeNameHandling.None,
		ContractResolver = new NonPublicPropertiesResolver()
	};

	internal EntitySerializer(ISettings settings, ILogger logger, ICounterRegistry counterRegistry)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public byte[] Serialize<TEntity>(TEntity entity) where TEntity : ICacheableObject
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (!((object)entity is IRemoteCacheableObject remoteCacheableObject))
		{
			return null;
		}
		string s = JsonConvert.SerializeObject(remoteCacheableObject.GetSerializable(), _JsonSerializerSettings);
		return Encoding.UTF8.GetBytes(s);
	}

	public (bool Success, TEntity Entity) TryDeserializeFromRemoteCache<TEntity>(ISharedCacheClient sharedCacheClient, byte[] value, string key) where TEntity : ICacheableObject
	{
		if (sharedCacheClient == null)
		{
			throw new ArgumentNullException("sharedCacheClient");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (string.IsNullOrWhiteSpace(key))
		{
			throw new ArgumentNullException("key");
		}
		var result1 = SafelyInvokeActionAndRemoveKeyAndLogOnFailure(sharedCacheClient, key, () => Encoding.UTF8.GetString(value), () => $"Failed to get string from byte array for for key={key}. Value was {BitConverter.ToString(value)}");
		bool flag = result1.Success;
		string json = result1.Value;
		if (!flag)
		{
			return (false, default(TEntity));
		}
		var result2 = SafelyInvokeActionAndRemoveKeyAndLogOnFailure(sharedCacheClient, key, () => Deserialize<TEntity>(json), () => $"Failed to deserialize data for key:{key}, value:{json}.");
		bool flag2 = result2.Success;
		TEntity item = result2.Value;
		if (!flag2 && _Settings.IsEntityDeserializationFailureCounterEnabled)
		{
			_CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Caching.EntitySerializer", "DeserializationFailures", typeof(TEntity).FullName).Increment();
		}
		return (flag2, item);
	}

	private (bool Success, TReturnType Value) SafelyInvokeActionAndRemoveKeyAndLogOnFailure<TReturnType>(ISharedCacheClient sharedCacheClient, string key, Func<TReturnType> action, Func<string> logMessageGetter)
	{
		try
		{
			TReturnType item = action();
			return (true, item);
		}
		catch (Exception arg)
		{
			sharedCacheClient.Remove(key);
			if (_Settings.IsEntityDeserializationFailureLoggingEnabled)
			{
				_Logger.Error($"Exception: {arg}. Message: {logMessageGetter()}");
			}
			return (false, default(TReturnType));
		}
	}

	private TEntity Deserialize<TEntity>(string json)
	{
		Type typeFromHandle = typeof(TEntity);
		if (_EntityConstructors.TryGetValue(typeFromHandle, out (ConstructorInfo, Type) value))
		{
			object obj = JsonConvert.DeserializeObject(json, value.Item2, _JsonSerializerSettingsIgnoreTypes);
			return (TEntity)value.Item1.Invoke(new object[1] { obj });
		}
		foreach (var t in from t in typeFromHandle.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Select(delegate(ConstructorInfo c)
			{
				ParameterInfo[] parameters = c.GetParameters();
				return (parameters.Length != 1) ? (null, null) : (c, parameters[0].ParameterType);
			})
			where t.Item1 != null
			select t)
		{
			ConstructorInfo constructorInfo = t.Item1;
			Type type = t.Item2;
			try
			{
				object obj2 = JsonConvert.DeserializeObject(json, type, _JsonSerializerSettingsIgnoreTypes);
				TEntity result = (TEntity)constructorInfo.Invoke(new object[1] { obj2 });
				_EntityConstructors[typeFromHandle] = (constructorInfo, type);
				return result;
			}
			catch
			{
			}
		}
		throw new SerializationException($"Entity deserialization failed: {typeFromHandle.FullName}. JSON data: {json}.");
	}
}
