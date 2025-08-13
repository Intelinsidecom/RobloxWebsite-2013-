using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using Newtonsoft.Json;
using Roblox.Redis;
using Roblox.Redis.Lru;
using StackExchange.Redis;

namespace Roblox.Platform.Infrastructure;

internal static class InfrastructureCache
{
	private static readonly MemoryCache _Cache = new MemoryCache("InfrastructureCache");

	private static readonly IRedisClient _RedisClient = RedisLruClient.GetInstance();

	internal static T FetchItem<T>(string key, TimeSpan cacheDuration, Func<T> getter)
	{
		object result = _Cache.Get(key);
		if (result == null)
		{
			result = getter();
			if (result != null)
			{
				DateTime absoluteExpiration = DateTime.Now + cacheDuration;
				_Cache.Add(key, result, absoluteExpiration);
			}
		}
		return (T)result;
	}

	internal static string[] GetStringArrayFromRedis(string redisKey)
	{
		try
		{
			string json = _RedisClient.Execute(redisKey, (IDatabase db) => db.StringGet(redisKey));
			if (string.IsNullOrEmpty(json))
			{
				return null;
			}
			return JsonConvert.DeserializeObject<string[]>(json);
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
	}

	internal static void WriteStringArrayToRedis(string redisKey, IEnumerable<string> values, TimeSpan expiration)
	{
		try
		{
			string json = JsonConvert.SerializeObject(values);
			_RedisClient.Execute(redisKey, (IDatabase db) => db.StringSet(redisKey, json, expiration));
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	internal static IDictionary<string, int> ReadDictionaryFromRedis(string redisKey)
	{
		try
		{
			HashEntry[] hashEntries = _RedisClient.Execute(redisKey, (IDatabase db) => db.HashGetAll(redisKey));
			if (hashEntries == null || hashEntries.Length == 0)
			{
				return null;
			}
			return ((IEnumerable<HashEntry>)hashEntries).ToDictionary((Func<HashEntry, string>)((HashEntry e) => e.Name), (Func<HashEntry, int>)((HashEntry e) => (int)e.Value));
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return null;
		}
	}

	internal static void WriteDictionaryToRedis(string redisKey, IDictionary<string, int> dictionary, TimeSpan expiration)
	{
		try
		{
			HashEntry[] hashEntries = dictionary.Select((KeyValuePair<string, int> kvp) => new HashEntry(kvp.Key, kvp.Value)).ToArray();
			_RedisClient.Execute(redisKey, delegate(IDatabase db)
			{
				db.HashSet(redisKey, hashEntries);
			});
			_RedisClient.Execute(redisKey, (IDatabase db) => db.KeyExpire(redisKey, expiration, CommandFlags.FireAndForget));
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}
}
