using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Hashing;
using StackExchange.Redis;

namespace Roblox.Redis;

public interface IRedisClient
{
	event EventHandler Refreshed;

	void Execute(string key, DatabaseAction databaseAction);

	TResult Execute<TResult>(string keyToBePartitioned, IPartitionedKeyGenerator partitionedKeyGenerator, DatabaseAction<TResult> databaseAction);

	TResult Execute<TResult>(string partitionKey, DatabaseAction<TResult> databaseAction);

	Task ExecuteAsync(string key, DatabaseActionAsync databaseAction, CancellationToken cancellationToken);

	Task<TResult> ExecuteAsync<TResult>(string key, DatabaseActionAsync<TResult> databaseAction, CancellationToken cancellationToken);

	void ExecuteMulti(IReadOnlyCollection<string> partitionKeys, DatabaseMultiAction databaseAction);

	IEnumerable<KeyValuePair<string, TResult>> ExecuteMulti<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiAction<TResult> databaseAction);

	IEnumerable<KeyValuePair<string, TResult>> ExecuteMulti<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionWithKeys<TResult> databaseAction);

	Task<IEnumerable<KeyValuePair<string, TResult>>> ExecuteMultiAsync<TResult>(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionAsync<TResult> databaseAction, CancellationToken cancellationToken);

	Task ExecuteMultiAsync(IReadOnlyCollection<string> partitionKeys, DatabaseMultiActionAsync databaseAction, CancellationToken cancellationToken);

	void ExecuteOnNodes(DatabaseAction databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null);

	Task ExecuteOnNodesAsync(DatabaseActionAsync databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null, CancellationToken cancellationToken = default(CancellationToken));

	IEnumerable<TResult> ExecuteOnNodes<TResult>(DatabaseAction<TResult> databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null);

	Task<TResult[]> ExecuteOnNodesAsync<TResult>(DatabaseActionAsync<TResult> databaseAction, Func<IDatabase, bool> shouldExecuteOnNode = null, CancellationToken cancellationToken = default(CancellationToken));

	void ExecuteScript(IDatabase database, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None);

	Task ExecuteScriptAsync(IDatabase database, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken));

	TResult ExecuteScript<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None);

	Task<TResult> ExecuteScriptAsync<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken));

	void ExecuteLoadedScript(IDatabase database, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None);

	Task ExecuteLoadedScriptAsync(IDatabase database, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken));

	TResult ExecuteLoadedScript<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None);

	Task<TResult> ExecuteLoadedScriptAsync<TResult>(IDatabase database, ConvertRedisResult<TResult> convertRedisResult, string script, byte[] scriptHash, RedisKey[] keys = null, RedisValue[] values = null, CommandFlags flags = CommandFlags.None, CancellationToken cancellationToken = default(CancellationToken));

	[Obsolete("Use LuaScriptHasher class")]
	byte[] GetScriptHash(string script);

	ISubscriber GetSubscriber(string partitionKey);

	void Refresh(RedisEndpoints redisEndpoints);

	void Refresh(string[] redisEndpoints);

	IServer GetServer(string partitionKey);

	IReadOnlyCollection<IServer> GetAllServers();

	IDatabase GetDatabase(string partitionKey);

	IDictionary<IDatabase, IReadOnlyCollection<string>> GetDatabases(IReadOnlyCollection<string> partitionKeys);

	IReadOnlyCollection<IDatabase> GetAllDatabases();

	void PingAllDatabases();

	IReadOnlyCollection<ISubscriber> GetAllSubscribers();

	void Close();
}
