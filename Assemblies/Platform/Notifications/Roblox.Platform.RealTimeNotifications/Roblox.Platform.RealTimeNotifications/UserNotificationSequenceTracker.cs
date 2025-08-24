using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.RealTimeNotifications.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.RealTimeNotifications;

public class UserNotificationSequenceTracker
{
	private const string UserKeyFormat = "RealTimeNotifications_User:{0}";

	private const string UserNamespacesKeyFormat = "RealTimeNotifications_User_Namespaces:{0}";

	private IRedisClient _RedisClient;

	private ILogger _Logger;

	public bool IsUserNotificationNamespaceSequenceEnabled => Settings.Default.IsUserNotificationNamespaceSequenceEnabled;

	public UserNotificationSequenceTracker(IRedisClient redisClient, ILogger logger)
	{
		_RedisClient = redisClient;
		_Logger = logger;
	}

	public string GetKeyFromUserId(long userId)
	{
		return $"RealTimeNotifications_User:{userId}";
	}

	public long IncrementUserNotificationSequenceNumber(long userId)
	{
		if (!Settings.Default.IsUserNotificationGlobalSequenceEnabled)
		{
			return 0L;
		}
		string key = GetKeyFromUserId(userId);
		try
		{
			return _RedisClient.Execute(key, (IDatabase db) => db.StringIncrement(key, 1L));
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return 0L;
		}
	}

	public long GetUserNotificationSequenceNumber(long userId)
	{
		string key = GetKeyFromUserId(userId);
		try
		{
			RedisValue redisValue = _RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
			long count = 0L;
			long.TryParse(redisValue, out count);
			return count;
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return 0L;
		}
	}

	public string GetNamespacesKeyFromUserId(long userId)
	{
		return $"RealTimeNotifications_User_Namespaces:{userId}";
	}

	public long IncrementUserNotificationNamespaceSequenceNumber(string notificationNamespace, long userId)
	{
		if (!IsUserNotificationNamespaceSequenceEnabled)
		{
			return 0L;
		}
		string key = GetNamespacesKeyFromUserId(userId);
		try
		{
			return _RedisClient.Execute(key, (IDatabase db) => db.HashIncrement(key, notificationNamespace, 1L));
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return 0L;
		}
	}

	public long GetUserNotificationNamespaceSequenceNumber(string notificationNamespace, long userId)
	{
		string key = GetNamespacesKeyFromUserId(userId);
		try
		{
			RedisValue redisValue = _RedisClient.Execute(key, (IDatabase db) => db.HashGet(key, notificationNamespace));
			long count = 0L;
			long.TryParse(redisValue, out count);
			return count;
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return 0L;
		}
	}

	/// <summary>
	/// Reads all namespace specific sequence numbers for a user and returns them as a dictionary.
	/// </summary>
	/// <param name="userId"></param>
	/// <returns>A dictionary of all namespace specific sequence numbers or null.</returns>
	public Dictionary<string, long> GetAllUserNotificationNamespaceSequenceNumbers(long userId)
	{
		string key = GetNamespacesKeyFromUserId(userId);
		try
		{
			HashEntry[] array = _RedisClient.Execute(key, (IDatabase db) => db.HashGetAll(key));
			Dictionary<string, long> result = new Dictionary<string, long>(array.Length);
			long value = 0L;
			HashEntry[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				HashEntry entry = array2[i];
				if (long.TryParse(entry.Value, out value))
				{
					result.Add(entry.Name, value);
				}
			}
			return result;
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			return null;
		}
	}
}
