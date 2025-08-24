using System;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Chat.Properties;
using Roblox.Redis;

namespace Roblox.Platform.Chat;

public static class ChatRedisClientProvider
{
	private const string _ChatConversationPerformanceCategory = "Roblox.Platform.Chat.Conversation.Redis";

	private const string _ChatMessagePerformanceCategory = "Roblox.Platform.Chat.Message.Redis";

	private const string _ChatInteractionsPerformanceCategory = "Roblox.Platform.Chat.Interactions.Redis";

	private static readonly RedisClientFactory _RedisClientFactoryForChatConversation = new RedisClientFactory(StaticCounterRegistry.Instance);

	private static readonly RedisClientFactory _RedisClientFactoryForChatMessage = new RedisClientFactory(StaticCounterRegistry.Instance);

	private static readonly RedisClientFactory _RedisClientFactoryForChatInteractions = new RedisClientFactory(StaticCounterRegistry.Instance);

	private static readonly ChatRedisClients _ChatRedisClients = new ChatRedisClients();

	public static IChatRedisClients GetRedisClients(ILogger logger)
	{
		_ChatRedisClients.ChatConversationRedisClient = _RedisClientFactoryForChatConversation.GetRedisClient(Settings.Default.RedisEndpointsForChatConversation, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsForChatConversation, refresh);
		}, "Roblox.Platform.Chat.Conversation.Redis", logger.Error);
		_ChatRedisClients.ChatMessageRedisClient = _RedisClientFactoryForChatMessage.GetRedisClient(Settings.Default.RedisEndpointsForChatMessage, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsForChatMessage, refresh);
		}, "Roblox.Platform.Chat.Message.Redis", logger.Error);
		return _ChatRedisClients;
	}

	public static IRedisClient GetChatInteractionsRedisClient(ILogger logger)
	{
		return _RedisClientFactoryForChatInteractions.GetRedisClient(Settings.Default.RedisEndpointsForChatInteractions, delegate(Action<RedisEndpoints> refresh)
		{
			Settings.Default.MonitorChanges((Settings s) => s.RedisEndpointsForChatInteractions, refresh);
		}, "Roblox.Platform.Chat.Interactions.Redis", logger.Error);
	}
}
