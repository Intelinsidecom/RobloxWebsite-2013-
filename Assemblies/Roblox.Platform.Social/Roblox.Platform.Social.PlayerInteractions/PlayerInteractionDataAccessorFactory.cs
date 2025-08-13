using System;
using Roblox.EventLog;
using Roblox.Redis;

namespace Roblox.Platform.Social.PlayerInteractions;

public class PlayerInteractionDataAccessorFactory : IPlayerInteractionDataAccessorFactory
{
	private readonly ILogger _Logger;

	private readonly IPlayerInteractionDataAccessor _PlayerInteractionDataAccessor;

	public PlayerInteractionDataAccessorFactory(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		IRedisClient redisClient = GetRedisClient(logger, useConnectionPool: false);
		IRedisClient redisClientWithConnectionPool = GetRedisClient(logger, useConnectionPool: true);
		_PlayerInteractionDataAccessor = new PlayerInteractionRedisAccessor(redisClient, redisClientWithConnectionPool);
	}

	private IRedisClient GetRedisClient(ILogger logger, bool useConnectionPool)
	{
		try
		{
			return PlayerInteractionsRedisClientFactory.GetRedisClient(logger, useConnectionPool);
		}
		catch (Exception ex2)
		{
			Exception ex3 = ex2;
			Exception ex = ex3;
			logger?.Error(() => $"Error when getting redis client - {ex}");
			return null;
		}
	}

	public IPlayerInteractionDataAccessor GetPlayerInteractionDataAccessor()
	{
		return _PlayerInteractionDataAccessor;
	}
}
