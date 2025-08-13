using System;
using Amazon.DynamoDBv2;
using Roblox.EventLog;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal static class MessageDataAccessorFactory
{
	private static Func<IChatRedisClients, IAmazonDynamoDB, ILogger, IInstantProvider, IMessageDataAccessor> _DataAccessorCreator;

	static MessageDataAccessorFactory()
	{
		_DataAccessorCreator = (IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, ILogger logger, IInstantProvider instantProvider) => new MessageDataAccessor(chatRedisClients, dynamoDbClient, logger, instantProvider);
	}

	public static IMessageDataAccessor GetMessageDataAccessor(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, ILogger logger, IInstantProvider instantProvider)
	{
		return _DataAccessorCreator(chatRedisClients, dynamoDbClient, logger, instantProvider);
	}

	internal static void SetDataAccessorCreator(Func<IChatRedisClients, IAmazonDynamoDB, ILogger, IInstantProvider, IMessageDataAccessor> dataAccessorCreator)
	{
		_DataAccessorCreator = dataAccessorCreator;
	}
}
