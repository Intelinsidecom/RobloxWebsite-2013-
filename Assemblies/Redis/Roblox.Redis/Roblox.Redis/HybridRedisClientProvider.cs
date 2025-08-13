using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Redis.Properties;
using Roblox.ServiceDiscovery;

namespace Roblox.Redis;

public sealed class HybridRedisClientProvider : IDisposable
{
	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	private readonly IServiceResolver _ServiceResolver;

	private readonly string _PerformanceCategory;

	private readonly RedisClientOptions _ClientOptions;

	private readonly ISingleSetting<bool> _UseServiceDiscovery;

	private readonly ISingleSetting<RedisEndpoints> _RedisEndpoints;

	private readonly object _Lock = new object();

	private readonly TaskCompletionSource<RedisEndpoints> _ResolverEndpoints = new TaskCompletionSource<RedisEndpoints>();

	private RedisClient _RedisClient;

	private RedisEndpoints _CurrentEndpoints;

	private bool _Disposed;

	public IRedisClient Client
	{
		get
		{
			if (_Disposed)
			{
				throw new ObjectDisposedException("HybridRedisClientProvider");
			}
			if (_RedisClient == null)
			{
				lock (_Lock)
				{
					if (_RedisClient == null)
					{
						_RedisClient = CreateRedisClient();
					}
				}
			}
			return _RedisClient;
		}
	}

	public HybridRedisClientProvider(ILogger logger, ICounterRegistry counterRegistry, IServiceResolver serviceResolver, string performanceCategory, ISingleSetting<bool> useServiceDiscovery, ISingleSetting<RedisEndpoints> redisEndpoints, RedisClientOptions clientOptions = null)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_ServiceResolver = serviceResolver ?? throw new ArgumentNullException("serviceResolver");
		_UseServiceDiscovery = useServiceDiscovery ?? throw new ArgumentNullException("useServiceDiscovery");
		_RedisEndpoints = redisEndpoints ?? throw new ArgumentNullException("redisEndpoints");
		_PerformanceCategory = performanceCategory ?? throw new ArgumentNullException("performanceCategory");
		_ClientOptions = clientOptions;
	}

	public void Dispose()
	{
		_Disposed = true;
		_ServiceResolver.PropertyChanged -= OnResolverChange;
		_UseServiceDiscovery.PropertyChanged -= OnSettingsChange;
		_RedisEndpoints.PropertyChanged -= OnSettingsChange;
		lock (_Lock)
		{
			_RedisClient?.Close();
		}
	}

	private RedisClient CreateRedisClient()
	{
		_ServiceResolver.PropertyChanged += OnResolverChange;
		_UseServiceDiscovery.PropertyChanged += OnSettingsChange;
		_RedisEndpoints.PropertyChanged += OnSettingsChange;
		if (_UseServiceDiscovery.Value)
		{
			Task<RedisEndpoints> task = _ResolverEndpoints.Task;
			TimeSpan initialDiscoveryWaitTime = HybridRedisClientProviderSettings.Default.InitialDiscoveryWaitTime;
			if (!task.Wait(initialDiscoveryWaitTime))
			{
				_Logger.Error($"Could not obtain the initial Redis endpoints from the service resolver within {initialDiscoveryWaitTime.TotalSeconds:N0} seconds");
				_CurrentEndpoints = null;
			}
			else
			{
				_CurrentEndpoints = task.Result;
			}
		}
		else
		{
			_CurrentEndpoints = _RedisEndpoints.Value;
		}
		RedisClient result;
		if (_CurrentEndpoints != null)
		{
			result = new RedisClient(_CounterRegistry, _CurrentEndpoints, _PerformanceCategory, _Logger.Error, _ClientOptions);
			_Logger.Info(() => $"Created Redis client with endpoints: {_CurrentEndpoints}");
		}
		else
		{
			result = new RedisClient(_CounterRegistry, Array.Empty<string>(), _PerformanceCategory, _Logger.Error, _ClientOptions);
			_Logger.Warning("Created Redis client with no endpoints");
		}
		return result;
	}

	private void OnResolverChange(object sender, PropertyChangedEventArgs eventArgs)
	{
		RedisEndpoints redisEndpoints = ToRedisEndpoints(_ServiceResolver.EndPoints);
		if (redisEndpoints != null)
		{
			_ResolverEndpoints.TrySetResult(redisEndpoints);
		}
		lock (_Lock)
		{
			if (_RedisClient != null)
			{
				RefreshRedisClient(_RedisClient);
			}
		}
	}

	private void OnSettingsChange(object sender, PropertyChangedEventArgs eventArgs)
	{
		lock (_Lock)
		{
			if (_RedisClient != null)
			{
				RefreshRedisClient(_RedisClient);
			}
		}
	}

	private void RefreshRedisClient(RedisClient client)
	{
		RedisEndpoints newEndpoints = (_UseServiceDiscovery.Value ? ToRedisEndpoints(_ServiceResolver.EndPoints) : _RedisEndpoints.Value);
		if (newEndpoints == null)
		{
			_Logger.Warning(() => $"Ignoring empty Redis endpoint list. Current endpoints: {_CurrentEndpoints}");
		}
		else if (_CurrentEndpoints == null || !_CurrentEndpoints.HasTheSameEndpoints(newEndpoints))
		{
			client.Refresh(newEndpoints);
			_Logger.Info(() => $"Refreshed Redis endpoints. New endpoints: {newEndpoints}");
			_CurrentEndpoints = newEndpoints;
		}
	}

	private static RedisEndpoints ToRedisEndpoints(IEnumerable<IPEndPoint> endpoints)
	{
		if (!endpoints.Any())
		{
			return null;
		}
		return new RedisEndpoints(string.Join(",", endpoints));
	}
}
