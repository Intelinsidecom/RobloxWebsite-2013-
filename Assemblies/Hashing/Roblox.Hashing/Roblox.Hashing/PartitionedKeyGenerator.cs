using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Hashing;

public class PartitionedKeyGenerator : IPartitionedKeyGenerator
{
	private readonly ConsistentHash<PartitionWrapper> _ConsistentHash;

	private readonly IReadOnlyCollection<string> _PartitionKeys;

	public PartitionedKeyGenerator(int numberOfPartitions, string partitionPrefix)
	{
		if (numberOfPartitions <= 0)
		{
			throw new ArgumentException("numberOfPartitions");
		}
		if (string.IsNullOrEmpty(partitionPrefix))
		{
			throw new ArgumentException("partitionPrefix");
		}
		List<PartitionWrapper> list = new List<PartitionWrapper>(numberOfPartitions);
		for (int i = 1; i <= numberOfPartitions; i++)
		{
			PartitionWrapper item = new PartitionWrapper($"{partitionPrefix}_{i}");
			list.Add(item);
		}
		_PartitionKeys = new ReadOnlyCollection<string>(list.Select((PartitionWrapper p) => p.PartitionKey).ToList());
		_ConsistentHash = new ConsistentHash<PartitionWrapper>();
		_ConsistentHash.Init(list);
	}

	public string GetPartitionKey(string keyToBePartitioned)
	{
		return _ConsistentHash.GetNode(keyToBePartitioned).PartitionKey;
	}

	public IReadOnlyCollection<string> GetAllPartitionKeys()
	{
		return _PartitionKeys;
	}
}
