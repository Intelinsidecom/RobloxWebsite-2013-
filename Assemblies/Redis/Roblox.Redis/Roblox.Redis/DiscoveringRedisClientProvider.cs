using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.ServiceDiscovery;

namespace Roblox.Redis;

public class DiscoveringRedisClientProvider : IRedisClientProvider
{
	private readonly ILogger _Logger;

	private readonly IServiceResolver _ServiceResolver;

	private readonly Lazy<IRedisClient> _RedisClient;

	public IRedisClient Client => _RedisClient.Value;

	public DiscoveringRedisClientProvider(ILogger logger, IServiceResolver serviceResolver, ICounterRegistry counterRegistry, string performanceMonitorCategory, bool useConnectionPooling = false, RedisPooledClientOptions redisPooledClientOptions = null, RedisClientOptions clientOptions = null)
	{
		DiscoveringRedisClientProvider discoveringRedisClientProvider = this;
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_ServiceResolver = serviceResolver ?? throw new ArgumentNullException("serviceResolver");
		if (string.IsNullOrEmpty(performanceMonitorCategory))
		{
			throw new ArgumentNullException("performanceMonitorCategory");
		}
		_RedisClient = new Lazy<IRedisClient>(delegate
		{
			IRedisClient client;
			if (useConnectionPooling)
			{
				client = new RedisPooledClient(counterRegistry, ConvertEndPoints(discoveringRedisClientProvider._ServiceResolver.EndPoints), performanceMonitorCategory, logger.Error, redisPooledClientOptions);
			}
			else
			{
				client = new RedisClient(counterRegistry, ConvertEndPoints(discoveringRedisClientProvider._ServiceResolver.EndPoints), performanceMonitorCategory, logger.Error, clientOptions);
			}
			discoveringRedisClientProvider._ServiceResolver.PropertyChanged += delegate
			{
				discoveringRedisClientProvider.RefreshRedisEndPoints(client);
			};
			discoveringRedisClientProvider.RefreshRedisEndPoints(client);
			return client;
		}, LazyThreadSafetyMode.ExecutionAndPublication);
	}

	private void RefreshRedisEndPoints(IRedisClient client)
	{
		string[] newEndPoints = ConvertEndPoints(_ServiceResolver.EndPoints).ToArray();
		client.Refresh(newEndPoints);
		_Logger.Info(() => string.Format("Refreshed redis endpoints. New endpoints: {0}", string.Join(", ", newEndPoints)));
	}

	private static IEnumerable<string> ConvertEndPoints(IEnumerable<IPEndPoint> endPoints)
	{
		return from e in endPoints
			orderby e.Address.Address, e.Port
			select e.ToString();
	}
}
