using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Hashing;
using StackExchange.Redis;

namespace Roblox.Redis;

internal abstract class ConsistentHashConnectionWrapperBase
{
	private readonly int _Hash;

	public abstract IDatabase Database { get; }

	public abstract ISubscriber Subscriber { get; }

	public abstract IServer Server { get; }

	internal ConsistentHashConnectionWrapperBase(ConfigurationOptions configuration)
	{
		uint hash = MurmurHash2.Hash(Encoding.ASCII.GetBytes(string.Join("_", configuration.EndPoints)));
		_Hash = (int)hash;
	}

	public override int GetHashCode()
	{
		return _Hash;
	}

	internal static IDictionary<IDatabase, IReadOnlyCollection<string>> GetDatabasesByConsistentHashingAlgorithm(IEnumerable<string> keys, ConsistentHash<ConsistentHashConnectionWrapperBase> wrapperProvider)
	{
		Dictionary<ConsistentHashConnectionWrapperBase, ICollection<string>> redisConnectionToBucketMapping = new Dictionary<ConsistentHashConnectionWrapperBase, ICollection<string>>();
		foreach (string key in keys)
		{
			ConsistentHashConnectionWrapperBase node = wrapperProvider.GetNode(key);
			ICollection<string> collection;
			if (!redisConnectionToBucketMapping.ContainsKey(node))
			{
				collection = new List<string>();
				redisConnectionToBucketMapping.Add(node, collection);
			}
			else
			{
				collection = redisConnectionToBucketMapping[node];
			}
			collection.Add(key);
		}
		return ((IEnumerable<KeyValuePair<ConsistentHashConnectionWrapperBase, ICollection<string>>>)redisConnectionToBucketMapping).ToDictionary((Func<KeyValuePair<ConsistentHashConnectionWrapperBase, ICollection<string>>, IDatabase>)((KeyValuePair<ConsistentHashConnectionWrapperBase, ICollection<string>> kvp) => kvp.Key.Database), (Func<KeyValuePair<ConsistentHashConnectionWrapperBase, ICollection<string>>, IReadOnlyCollection<string>>)((KeyValuePair<ConsistentHashConnectionWrapperBase, ICollection<string>> kvp) => redisConnectionToBucketMapping[kvp.Key].ToList().AsReadOnly()));
	}
}
