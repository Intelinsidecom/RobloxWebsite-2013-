using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Platform.Chat;

internal class RedisConversationTitleCache : IConversationTitleCache
{
	private readonly IRedisClient _RedisClient;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	public RedisConversationTitleCache(IRedisClient redisClient, ILogger logger)
		: this(redisClient, logger, Settings.Default)
	{
	}

	internal RedisConversationTitleCache(IRedisClient redisClient, ILogger logger, ISettings settings)
	{
		_RedisClient = redisClient;
		_Logger = logger;
		_Settings = settings;
	}

	public void CacheConversationTitleForUnder13(long conversationId, string under13ConversationTitle)
	{
		try
		{
			string key = GetKey(conversationId);
			if (string.IsNullOrEmpty(under13ConversationTitle))
			{
				_RedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key, CommandFlags.FireAndForget));
			}
			else
			{
				_RedisClient.Execute(key, (IDatabase db) => db.StringSet(key, under13ConversationTitle, _Settings.ConversationTitleCacheExpiry, When.Always, CommandFlags.FireAndForget));
			}
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
	}

	public void ClearConversationTitleForUnder13(long conversationId)
	{
		string key = GetKey(conversationId);
		_RedisClient.Execute(key, (IDatabase db) => db.KeyDelete(key, CommandFlags.FireAndForget));
	}

	public string GetConversationTitleForUnder13(long conversationId)
	{
		string key = GetKey(conversationId);
		return _RedisClient.Execute(key, (IDatabase db) => db.StringGet(key));
	}

	private string GetKey(long conversationId)
	{
		return $"ConvU13Title:{conversationId}";
	}
}
