using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.Instrumentation;
using StackExchange.Redis;

namespace Roblox.Redis;

public class RlecRedisClient : RedisClientBase<RedisClientOptions>
{
	private readonly object _MultiplexerCreationSync = new object();

	private readonly Random _Random = new Random();

	private string[] _RedisEndpoints;

	private IConnectionMultiplexer _Multiplexer;

	public RlecRedisClient(ICounterRegistry counterRegistry, IEnumerable<string> redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisClientOptions clientOptions = null)
		: base(counterRegistry, performanceMonitorCategory, clientOptions, exceptionHandler)
	{
		_RedisEndpoints = redisEndpoints.ToArray();
		PickRandomEndpoint(null);
	}

	public RlecRedisClient(ICounterRegistry counterRegistry, RedisEndpoints redisEndpoints, string performanceMonitorCategory, Action<Exception> exceptionHandler = null, RedisClientOptions clientOptions = null)
		: this(counterRegistry, redisEndpoints.Endpoints, performanceMonitorCategory, exceptionHandler, clientOptions)
	{
	}

	public override void Refresh(string[] redisEndpoints)
	{
		_RedisEndpoints = redisEndpoints;
		PickRandomEndpoint(null);
		OnRefreshed();
	}

	public override IServer GetServer(string partitionKey)
	{
		return RedisClientBase<RedisClientOptions>.GetServerFromMultiplexer(_Multiplexer);
	}

	public override IReadOnlyCollection<IServer> GetAllServers()
	{
		return (IReadOnlyCollection<IServer>)(object)new IServer[1] { RedisClientBase<RedisClientOptions>.GetServerFromMultiplexer(_Multiplexer) };
	}

	public override IDatabase GetDatabase(string partitionKey)
	{
		return _Multiplexer.GetDatabase();
	}

	public override ISubscriber GetSubscriber(string partitionKey)
	{
		return _Multiplexer.GetSubscriber();
	}

	public override IDictionary<IDatabase, IReadOnlyCollection<string>> GetDatabases(IReadOnlyCollection<string> partitionKeys)
	{
		if (partitionKeys == null || partitionKeys.Any((string pk) => pk == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		IDatabase database = _Multiplexer.GetDatabase();
		return new Dictionary<IDatabase, IReadOnlyCollection<string>>(1) { [database] = partitionKeys };
	}

	public override IReadOnlyCollection<IDatabase> GetAllDatabases()
	{
		return (IReadOnlyCollection<IDatabase>)(object)new IDatabase[1] { _Multiplexer.GetDatabase() };
	}

	public override IReadOnlyCollection<ISubscriber> GetAllSubscribers()
	{
		return (IReadOnlyCollection<ISubscriber>)(object)new ISubscriber[1] { _Multiplexer.GetSubscriber() };
	}

	public override void Close()
	{
		_Multiplexer.Close(allowCommandsToComplete: false);
	}

	private void MultiplexerOnConnectionFailed(object sender, ConnectionFailedEventArgs args)
	{
		string excludedEndpoint = ConfigurationOptions.Parse(((ConnectionMultiplexer)sender).Configuration).EndPoints[0].ToString();
		PickRandomEndpoint(excludedEndpoint);
	}

	private void PickRandomEndpoint(string excludedEndpoint)
	{
		IConnectionMultiplexer multiplexer = _Multiplexer;
		_Multiplexer = CreateMultiplexer();
		DisposeMultiplexer(multiplexer, delayedDisposal: true);
		IConnectionMultiplexer CreateMultiplexer()
		{
			lock (_MultiplexerCreationSync)
			{
				HashSet<string> hashSet = new HashSet<string>(_RedisEndpoints);
				if (excludedEndpoint != null)
				{
					hashSet.Remove(excludedEndpoint);
				}
				while (hashSet.Count > 0)
				{
					string[] array = hashSet.ToArray();
					int num = _Random.Next(0, array.Length);
					string text = array[num];
					IConnectionMultiplexer connectionMultiplexer = ConnectMultiplexer(text);
					if (connectionMultiplexer.IsConnected)
					{
						connectionMultiplexer.ConnectionFailed += MultiplexerOnConnectionFailed;
						return connectionMultiplexer;
					}
					DisposeMultiplexer(connectionMultiplexer, delayedDisposal: false);
					hashSet.Remove(text);
				}
				int num2 = _Random.Next(0, _RedisEndpoints.Length);
				string redisEndpoint = _RedisEndpoints[num2];
				IConnectionMultiplexer connectionMultiplexer2 = ConnectMultiplexer(redisEndpoint);
				connectionMultiplexer2.ConnectionFailed += MultiplexerOnConnectionFailed;
				return connectionMultiplexer2;
			}
		}
	}

	private void DisposeMultiplexer(IConnectionMultiplexer multiplexer, bool delayedDisposal)
	{
		if (multiplexer == null)
		{
			return;
		}
		multiplexer.ConnectionFailed -= MultiplexerOnConnectionFailed;
		if (!delayedDisposal)
		{
			multiplexer.Dispose();
			return;
		}
		Task.Delay(5000).ContinueWith(delegate
		{
			try
			{
				multiplexer.Dispose();
			}
			catch
			{
			}
		});
	}
}
