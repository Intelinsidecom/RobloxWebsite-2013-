using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Hashing;

public class ConsistentHash<T>
{
	protected SortedDictionary<int, T> circle = new SortedDictionary<int, T>();

	private int _replicate = 100;

	private int[] ayKeys;

	public void Init(IEnumerable<T> nodes)
	{
		Init(nodes, _replicate);
	}

	public void Init(IEnumerable<T> nodes, int replicate)
	{
		_replicate = replicate;
		foreach (T node in nodes)
		{
			Add(node, updateKeyArray: false);
		}
		ayKeys = circle.Keys.ToArray();
	}

	public void Add(T node)
	{
		Add(node, updateKeyArray: true);
	}

	private void Add(T node, bool updateKeyArray)
	{
		for (int i = 0; i < _replicate; i++)
		{
			int key = BetterHash(node.GetHashCode().ToString() + i);
			circle[key] = node;
		}
		if (updateKeyArray)
		{
			ayKeys = circle.Keys.ToArray();
		}
	}

	public void Remove(T node)
	{
		for (int i = 0; i < _replicate; i++)
		{
			int key = BetterHash(node.GetHashCode().ToString() + i);
			if (!circle.Remove(key))
			{
				throw new Exception("can not remove a node that not added");
			}
		}
		ayKeys = circle.Keys.ToArray();
	}

	private T GetNode_slow(string key)
	{
		int hash = BetterHash(key);
		if (circle.ContainsKey(hash))
		{
			return circle[hash];
		}
		int num = circle.Keys.FirstOrDefault((int h) => h >= hash);
		if (num == 0)
		{
			num = ayKeys[0];
		}
		return circle[num];
	}

	private int First_ge(int[] ay, int val)
	{
		int num = 0;
		int num2 = ay.Length - 1;
		if (ay[num2] < val || ay[0] > val)
		{
			return 0;
		}
		int num3 = num;
		while (num2 - num > 1)
		{
			num3 = (num2 + num) / 2;
			if (ay[num3] >= val)
			{
				num2 = num3;
			}
			else
			{
				num = num3;
			}
		}
		if (ay[num] > val || ay[num2] < val)
		{
			throw new Exception("should not happen");
		}
		return num2;
	}

	public T GetNode(string key)
	{
		int val = BetterHash(key);
		int num = First_ge(ayKeys, val);
		return circle[ayKeys[num]];
	}

	public static int BetterHash(string key)
	{
		return (int)MurmurHash2.Hash(Encoding.ASCII.GetBytes(key));
	}
}
