using System.Collections.Generic;

namespace Roblox.Hashing;

public class ConsistentHashV2<T> : ConsistentHash<T>
{
	public IReadOnlyCollection<T> Nodes { get; private set; }

	public void Init(IReadOnlyCollection<T> nodes)
	{
		Nodes = nodes;
		circle = new SortedDictionary<int, T>();
		Init((IEnumerable<T>)nodes);
	}
}
