using System;
using System.Diagnostics;

namespace Roblox.Instrumentation;

[DebuggerDisplay("Category={Category}, Name={Name}, Instance={Instance}")]
public struct CounterKey : IEquatable<CounterKey>
{
	private readonly string _Key;

	public string Category { get; }

	public string Name { get; }

	public string Instance { get; }

	public CounterKey(string category, string name, string instance)
	{
		if (string.IsNullOrWhiteSpace(category))
		{
			throw new ArgumentException("category");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("name");
		}
		Category = category;
		Name = name;
		Instance = instance;
		_Key = string.Join("\t", category, name, instance);
	}

	public bool Equals(CounterKey other)
	{
		return string.Equals(_Key, other._Key);
	}

	public override bool Equals(object obj)
	{
		if (obj is CounterKey other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _Key.GetHashCode();
	}
}
