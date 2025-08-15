using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Hashing;
using Roblox.Instrumentation;
using StackExchange.Redis;

namespace Roblox.Redis;

public abstract class RedisClientBase<TOptions> : IRedisClient where TOptions : RedisClientOptionsBase
{
	private const string _RedisExceptionNoScriptMessageKeyword = "NOSCRIPT";

	private static readonly HashSet<string> _SubscriptionCommands = new HashSet<string> { "SUBSCRIBE", "UNSUBSCRIBE", "PSUBSCRIBE", "PUNSUBSCRIBE" };

	private readonly PerformanceMonitor _PerformanceMonitor;

	protected TOptions RedisClientOptions { get; }

	public event EventHandler Refreshed;

	public abstract void Close();

	public abstract ISubscriber GetSubscriber(string partitionKey);

	public abstract void Refresh(string[] redisEndpoints);

	public abstract IDatabase GetDatabase(string partitionKey);

	public abstract IServer GetServer(string partitionKey);

	public abstract IDictionary<IDatabase, IReadOnlyCollection<string>> GetDatabases(IReadOnlyCollection<string> partitionKeys);

	public abstract IReadOnlyCollection<IDatabase> GetAllDatabases();

	public abstract IReadOnlyCollection<IServer> GetAllServers();

	protected RedisClientBase(ICounterRegistry counterRegistry, string performanceMonitorCategory, TOptions redisClientOptions, Action<Exception> exceptionHandler = null)
	{
		RedisClientOptions = redisClientOptions ?? throw new ArgumentNullException("redisClientOptions");
		try
		{
			_PerformanceMonitor = new PerformanceMonitor(counterRegistry, performanceMonitorCategory);
		}
		catch (Exception innerException)
		{
			exceptionHandler?.Invoke(new Exception("Unable to initialize redis performance monitor.", innerException));
		}
	}

	public void Execute(string partitionKey, DatabaseAction databaseAction)
	{
		if (string.IsNullOrEmpty(partitionKey))
		{
			throw new ArgumentException("Partition key cannot be null or empty in call to RedisClient.Execute");
		}
		IDatabase database = GetDatabase(partitionKey);
		Stopwatch stopWatch = Stopwatch.StartNew();
		PreDatabaseExecute();
		try
		{
			databaseAction(database);
		}
		catch (Exception)
		{
			OnDatabaseError(database);
			throw;
		}
		finally
		{
			PostDatabaseExecute(stopWatch);
		}
	}

	public TResult Execute<TResult>(string keyToBePartitioned, IPartitionedKeyGenerator partitionedKeyGenerator, DatabaseAction<TResult> databaseAction)
	{
		string partitionKey = partitionedKeyGenerator.GetPartitionKey(keyToBePartitioned);
		return Execute(partitionKey, databaseAction);
	}

	public TResult Execute<TResult>(string partitionKey, DatabaseAction<TResult> databaseAction)
	{
		if (string.IsNullOrEmpty(partitionKey))
		{
			throw new ArgumentException("Partition key cannot be null or empty in call to RedisClient.Execute");
		}
		IDatabase database = GetDatabase(partitionKey);
		Stopwatch stopWatch = Stopwatch.StartNew();
		PreDatabaseExecute();
		try
		{
			return databaseAction(database);
		}
		catch (Exception)
		{
			OnDatabaseError(database);
			throw;
		}
		finally
		{
			PostDatabaseExecute(stopWatch);
		}
	}

	public async Task ExecuteAsync(string partitionKey, DatabaseActionAsync databaseAction, CancellationToken cancellationToken)
	{
		if (partitionKey == null)
		{
			throw new ArgumentNullException("partitionKey");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		IDatabase database = GetDatabase(partitionKey);
		Stopwatch stopwatch = Stopwatch.StartNew();
		PreDatabaseExecute();
		try
		{
			await databaseAction(database, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception)
		{
			OnDatabaseError(database);
			throw;
		}
		finally
		{
			PostDatabaseExecute(stopwatch);
		}
	}

	public async Task<TResult> ExecuteAsync<TResult>(string partitionKey, DatabaseActionAsync<TResult> databaseAction, CancellationToken cancellationToken)
	{
		if (partitionKey == null)
		{
			throw new ArgumentNullException("partitionKey");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		IDatabase database = GetDatabase(partitionKey);
		Stopwatch stopwatch = Stopwatch.StartNew();
		PreDatabaseExecute();
		try
		{
			return await databaseAction(database, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception)
		{
			OnDatabaseError(database);
			throw;
		}
		finally
		{
			PostDatabaseExecute(stopwatch);
		}
	}

	public IEnumerable<KeyValuePair<string, TResult>> ExecuteMulti<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiAction<TResult> databaseAction)
	{
		if (partitionKeys == null || partitionKeys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		IDictionary<IDatabase, IReadOnlyCollection<string>> databases = GetDatabases(partitionKeys);
		List<KeyValuePair<string, TResult>> list = new List<KeyValuePair<string, TResult>>(partitionKeys.Count);
		foreach (KeyValuePair<IDatabase, IReadOnlyCollection<string>> item in databases)
		{
			Stopwatch stopWatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			IEnumerable<TResult> enumerable;
			try
			{
				enumerable = databaseAction(item.Key, item.Value);
			}
			catch (Exception)
			{
				OnDatabaseError(item.Key);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopWatch);
			}
			using IEnumerator<string> enumerator2 = item.Value.AsEnumerable().GetEnumerator();
			using IEnumerator<TResult> enumerator3 = enumerable.GetEnumerator();
			while (enumerator2.MoveNext() && enumerator3.MoveNext())
			{
				list.Add(new KeyValuePair<string, TResult>(enumerator2.Current, enumerator3.Current));
			}
		}
		return list;
	}

	public IEnumerable<KeyValuePair<string, TResult>> ExecuteMulti<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionWithKeys<TResult> databaseAction)
	{
		if (partitionKeys == null || partitionKeys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		IDictionary<IDatabase, IReadOnlyCollection<string>> databases = GetDatabases(partitionKeys);
		List<KeyValuePair<string, TResult>> list = new List<KeyValuePair<string, TResult>>(partitionKeys.Count);
		foreach (KeyValuePair<IDatabase, IReadOnlyCollection<string>> item in databases)
		{
			Stopwatch stopWatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			IEnumerable<string> enumerable;
			IEnumerable<TResult> enumerable2;
			try
			{
				(enumerable, enumerable2) = databaseAction(item.Key, item.Value);
			}
			catch (Exception)
			{
				OnDatabaseError(item.Key);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopWatch);
			}
			using IEnumerator<string> enumerator2 = enumerable.GetEnumerator();
			using IEnumerator<TResult> enumerator3 = enumerable2.GetEnumerator();
			while (enumerator2.MoveNext() && enumerator3.MoveNext())
			{
				list.Add(new KeyValuePair<string, TResult>(enumerator2.Current, enumerator3.Current));
			}
		}
		return list;
	}

	public async Task<IEnumerable<KeyValuePair<string, TResult>>> ExecuteMultiAsync<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionAsync<TResult> databaseAction, CancellationToken cancellationToken)
	{
		if (partitionKeys == null || partitionKeys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		cancellationToken.ThrowIfCancellationRequested();
		IDictionary<IDatabase, IReadOnlyCollection<string>> databases = GetDatabases(partitionKeys);
		List<KeyValuePair<string, TResult>> allResults = new List<KeyValuePair<string, TResult>>(partitionKeys.Count);
		foreach (KeyValuePair<IDatabase, IReadOnlyCollection<string>> databaseBucketMapping in databases)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			IEnumerable<TResult> enumerable;
			try
			{
				enumerable = await databaseAction(databaseBucketMapping.Key, databaseBucketMapping.Value, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception)
			{
				OnDatabaseError(databaseBucketMapping.Key);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopwatch);
			}
			using IEnumerator<string> enumerator2 = databaseBucketMapping.Value.AsEnumerable().GetEnumerator();
			using IEnumerator<TResult> enumerator3 = enumerable.GetEnumerator();
			while (enumerator2.MoveNext() && enumerator3.MoveNext())
			{
				allResults.Add(new KeyValuePair<string, TResult>(enumerator2.Current, enumerator3.Current));
			}
		}
		return allResults;
	}

	public void ExecuteMulti(IReadOnlyCollection<string> partitionKeys, DatabaseMultiAction databaseAction)
	{
		if (partitionKeys == null || partitionKeys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		foreach (KeyValuePair<IDatabase, IReadOnlyCollection<string>> database in GetDatabases(partitionKeys))
		{
			Stopwatch stopWatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				databaseAction(database.Key, database.Value);
			}
			catch (Exception)
			{
				OnDatabaseError(database.Key);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopWatch);
			}
		}
	}

	public async Task ExecuteMultiAsync(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionAsync databaseAction, CancellationToken cancellationToken)
	{
		if (partitionKeys == null || partitionKeys.Any((string k) => k == null))
		{
			throw new ArgumentNullException("partitionKeys");
		}
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		cancellationToken.ThrowIfCancellationRequested();
		IDictionary<IDatabase, IReadOnlyCollection<string>> databases = GetDatabases(partitionKeys);
		foreach (KeyValuePair<IDatabase, IReadOnlyCollection<string>> databaseBucketMapping in databases)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				await databaseAction(databaseBucketMapping.Key, databaseBucketMapping.Value, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception)
			{
				OnDatabaseError(databaseBucketMapping.Key);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopwatch);
			}
		}
	}

	public void ExecuteOnNodes(DatabaseAction databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null)
	{
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		foreach (IDatabase allDatabase in GetAllDatabases())
		{
			if (shouldExecuteOnNode != null && !shouldExecuteOnNode(allDatabase))
			{
				continue;
			}
			Stopwatch stopWatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				databaseAction(allDatabase);
			}
			catch (Exception)
			{
				OnDatabaseError(allDatabase);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopWatch);
			}
		}
	}

	public async Task ExecuteOnNodesAsync(DatabaseActionAsync databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		cancellationToken.ThrowIfCancellationRequested();
		IReadOnlyCollection<IDatabase> allDatabases = GetAllDatabases();
		List<Task> list = new List<Task>(allDatabases.Count);
		foreach (IDatabase item in allDatabases)
		{
			if (shouldExecuteOnNode == null || shouldExecuteOnNode(item))
			{
				list.Add(DatabaseActionWrapperAsync(item));
			}
		}
		await Task.WhenAll(list).ConfigureAwait(continueOnCapturedContext: false);
		async Task DatabaseActionWrapperAsync(IDatabase db)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				await databaseAction(db, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception)
			{
				OnDatabaseError(db);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopwatch);
			}
		}
	}

	public IEnumerable<TResult> ExecuteOnNodes<TResult>(DatabaseAction<TResult> databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null)
	{
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		IReadOnlyCollection<IDatabase> allDatabases = GetAllDatabases();
		List<TResult> list = new List<TResult>();
		foreach (IDatabase item2 in allDatabases)
		{
			if (shouldExecuteOnNode != null && !shouldExecuteOnNode(item2))
			{
				continue;
			}
			Stopwatch stopWatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				TResult item = databaseAction(item2);
				list.Add(item);
			}
			catch (Exception)
			{
				OnDatabaseError(item2);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopWatch);
			}
		}
		return list;
	}

	public async Task<TResult[]> ExecuteOnNodesAsync<TResult>(DatabaseActionAsync<TResult> databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (databaseAction == null)
		{
			throw new ArgumentNullException("databaseAction");
		}
		cancellationToken.ThrowIfCancellationRequested();
		IReadOnlyCollection<IDatabase> allDatabases = GetAllDatabases();
		List<Task<TResult>> list = new List<Task<TResult>>(allDatabases.Count);
		foreach (IDatabase item in allDatabases)
		{
			if (shouldExecuteOnNode == null || shouldExecuteOnNode(item))
			{
				list.Add(DatabaseActionWrapperAsync(item));
			}
		}
		return await Task.WhenAll(list).ConfigureAwait(continueOnCapturedContext: false);
		async Task<TResult> DatabaseActionWrapperAsync(IDatabase db)
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			PreDatabaseExecute();
			try
			{
				return await databaseAction(db, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception)
			{
				OnDatabaseError(db);
				throw;
			}
			finally
			{
				PostDatabaseExecute(stopwatch);
			}
		}
	}

	public void ExecuteScript(IDatabase database, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
	{
		database.ScriptEvaluate(script, keys, values, flags);
	}

	public Task ExecuteScriptAsync(IDatabase database, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken))
	{
		cancellationToken.ThrowIfCancellationRequested();
		return database.ScriptEvaluateAsync(script, keys, values, flags);
	}

	public TResult ExecuteScript<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
	{
		RedisResult redisResult = database.ScriptEvaluate(script, keys, values, flags);
		return convertRedisResult(redisResult);
	}

	public async Task<TResult> ExecuteScriptAsync<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken))
	{
		cancellationToken.ThrowIfCancellationRequested();
		return convertRedisResult(await database.ScriptEvaluateAsync(script, keys, values, flags).ConfigureAwait(continueOnCapturedContext: false));
	}

	public void ExecuteLoadedScript(IDatabase database, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
	{
		ExecuteLoadedScript(database, (RedisResult s) => s, script, scriptHash, keys, values, flags);
	}

	public Task ExecuteLoadedScriptAsync(IDatabase database, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken))
	{
		cancellationToken.ThrowIfCancellationRequested();
		return ExecuteLoadedScriptAsync(database, (RedisResult s) => s, script, scriptHash, keys, values, flags, cancellationToken);
	}

	public TResult ExecuteLoadedScript<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None)
	{
		try
		{
			RedisResult redisResult = database.ScriptEvaluate(scriptHash, keys, values, flags);
			return convertRedisResult(redisResult);
		}
		catch (RedisServerException ex)
		{
			if (ex.Message.Contains("NOSCRIPT"))
			{
				LoadScript(database, scriptHash, script);
				RedisResult redisResult = database.ScriptEvaluate(scriptHash, keys, values, flags);
				return convertRedisResult(redisResult);
			}
			throw;
		}
	}

	public async Task<TResult> ExecuteLoadedScriptAsync<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken))
	{
		cancellationToken.ThrowIfCancellationRequested();
		TResult result = default(TResult);
		object obj;
		int num;
		try
		{
			result = convertRedisResult(await database.ScriptEvaluateAsync(scriptHash, keys, values, flags).ConfigureAwait(continueOnCapturedContext: false));
			return result;
		}
		catch (RedisServerException ex)
		{
			obj = ex;
			num = 1;
		}
		if (num != 1)
		{
			return result;
		}
		if (((RedisServerException)obj).Message.Contains("NOSCRIPT"))
		{
			cancellationToken.ThrowIfCancellationRequested();
			LoadScript(database, scriptHash, script);
			return convertRedisResult(await database.ScriptEvaluateAsync(scriptHash, keys, values, flags).ConfigureAwait(continueOnCapturedContext: false));
		}
		ExceptionDispatchInfo.Capture((obj as Exception) ?? new Exception(obj.ToString())).Throw();
		return result;
	}

	public byte[] GetScriptHash(string script)
	{
		return LuaScriptHasher.GetScriptHash(script);
	}

	public void Refresh(RedisEndpoints redisEndpoints)
	{
		Refresh(redisEndpoints.Endpoints.ToArray());
	}

	public void PingAllDatabases()
	{
		Parallel.ForEach(GetAllDatabases(), delegate(IDatabase database)
		{
			database.Ping();
		});
	}

	public abstract IReadOnlyCollection<ISubscriber> GetAllSubscribers();

	protected Task<IConnectionMultiplexer> ConnectMultiplexerAsync(string redisEndpoint)
	{
		ConfigurationOptions configurationOptions = GetConfigurationOptions(redisEndpoint);
		return (RedisClientOptions.ConnectionBuilder ?? new DefaultConnectionBuilder()).CreateConnectionMultiplexerAsync(configurationOptions);
	}

	protected ConfigurationOptions GetConfigurationOptions(string redisEndpoint)
	{
		ConfigurationOptions configurationOptions = ConfigurationOptions.Parse(redisEndpoint);
		configurationOptions.ConnectTimeout = (int)RedisClientOptions.ConnectTimeout().TotalMilliseconds;
		configurationOptions.ResponseTimeout = (int)RedisClientOptions.ResponseTimeout().TotalMilliseconds;
		configurationOptions.AbortOnConnectFail = false;
		configurationOptions.ReconnectRetryPolicy = RedisClientOptions.ReconnectRetryPolicy;
		if (RedisClientOptions.SyncTimeout.HasValue)
		{
			configurationOptions.SyncTimeout = (int)RedisClientOptions.SyncTimeout.Value.TotalMilliseconds;
		}
		if (RedisClientOptions.DisableSubscriptions)
		{
			configurationOptions.CommandMap = CommandMap.Create(_SubscriptionCommands, available: false);
		}
		return configurationOptions;
	}

	protected IConnectionMultiplexer ConnectMultiplexer(string redisEndpoint)
	{
		return Task.Run(() => ConnectMultiplexerAsync(redisEndpoint)).GetAwaiter().GetResult();
	}

	protected void OnRefreshed()
	{
		this.Refreshed?.Invoke(this, EventArgs.Empty);
	}

	private void PreDatabaseExecute()
	{
		_PerformanceMonitor?.OutstandingRequestCount.Increment();
	}

	private void OnDatabaseError(IDatabase database)
	{
		_PerformanceMonitor?.ErrorsPerSecond.Increment();
		string ipPortCombo = database.Multiplexer.GetIpPortCombo();
		_PerformanceMonitor?.GetPerEndpointErrorCounter(ipPortCombo).Increment();
	}

	private void PostDatabaseExecute(Stopwatch stopWatch)
	{
		stopWatch.Stop();
		if (_PerformanceMonitor != null)
		{
			_PerformanceMonitor.AverageResponseTime.Sample(stopWatch.Elapsed.TotalMilliseconds);
			_PerformanceMonitor.RequestsPerSecond.Increment();
			_PerformanceMonitor.OutstandingRequestCount.Decrement();
		}
	}

	private void LoadScript(IDatabase database, byte[] scriptHash, string script)
	{
		if (!GetServerFromMultiplexer(database.Multiplexer).ScriptLoad(script).SequenceEqual(scriptHash))
		{
			throw new ArgumentException("scriptHash is not correct for the script.");
		}
	}

	public static IServer GetServerFromMultiplexer(IConnectionMultiplexer connectionMultiplexer)
	{
		if (connectionMultiplexer == null)
		{
			throw new ArgumentNullException("connectionMultiplexer");
		}
		EndPoint endpoint = connectionMultiplexer.GetEndPoints()[0];
		return connectionMultiplexer.GetServer(endpoint);
	}
}
