using System;
using Roblox.EventLog;
using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Universes;
using Roblox.Redis;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal static class ConversationDataAccessorFactory
{
	private static Func<IRedisClient, ILogger, IUniverseFactory, IConversationDataAccessor> _DataAccessorCreator;

	static ConversationDataAccessorFactory()
	{
		ConversationUniverseEntityFactory conversationUniverseEntityFactory = new ConversationUniverseEntityFactory();
		_DataAccessorCreator = (IRedisClient redisClient, ILogger logger, IUniverseFactory universeFactory) => new ConversationDataAccessor(redisClient, new InstantProvider(), Settings.Default, logger, conversationUniverseEntityFactory);
	}

	public static IConversationDataAccessor GetConversationDataAccessor(IRedisClient redisClient, ILogger logger, IUniverseFactory universeFactory)
	{
		return _DataAccessorCreator(redisClient, logger, universeFactory);
	}

	internal static void SetDataAccessorCreator(Func<IRedisClient, ILogger, IUniverseFactory, IConversationDataAccessor> dataAccessorCreator)
	{
		_DataAccessorCreator = dataAccessorCreator;
	}
}
