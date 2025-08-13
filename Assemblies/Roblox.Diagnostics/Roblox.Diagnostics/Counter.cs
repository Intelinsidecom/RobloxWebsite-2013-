using System;
using System.Diagnostics;

namespace Roblox.Diagnostics;

[AttributeUsage(AttributeTargets.Field)]
public class Counter : Attribute
{
	public readonly string Name;

	public string Help = string.Empty;

	public readonly PerformanceCounterType Type;

	public Counter(string name, PerformanceCounterType type)
	{
		Name = name;
		Type = type;
	}
}
