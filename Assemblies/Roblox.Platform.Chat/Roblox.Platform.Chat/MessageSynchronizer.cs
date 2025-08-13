using System;
using Amazon.DynamoDBv2;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Time;

namespace Roblox.Platform.Chat;

/// <summary>
/// This class is used in the background processor to automatically correct the sortedset list in case of cache misses in message Ids
/// </summary>
public class MessageSynchronizer : IMessageSynchronizer
{
	private readonly IMessageDataAccessor _MessageDataAccessor;

	public MessageSynchronizer(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbAccessor, ILogger logger)
	{
		_MessageDataAccessor = MessageDataAccessorFactory.GetMessageDataAccessor(chatRedisClients, dynamoDbAccessor, logger, new InstantProvider());
	}

	public void SynchronizeCacheWithPersistentStorage(long conversationId)
	{
		if (!Settings.Default.IsCacheSyncEnabled)
		{
			return;
		}
		int maxPages = Settings.Default.MaxRowsToFetchForCacheSync;
		Guid? currentMessageId = _MessageDataAccessor.SynchronizeCacheWithPersistentStorage(conversationId);
		for (int i = 1; i < maxPages; i++)
		{
			if (!currentMessageId.HasValue)
			{
				break;
			}
			currentMessageId = _MessageDataAccessor.SynchronizeCacheWithPersistentStorage(conversationId, currentMessageId);
		}
	}
}
