using System;
using System.Collections.Generic;

namespace Roblox.Diagnostics;

public class InstanceNameTruncatedEventArgs : EventArgs
{
	public string Category { get; }

	public string OldInstanceName { get; }

	public string NewInstanceName { get; }

	public IReadOnlyCollection<string> CounterNames { get; }

	public InstanceNameTruncatedEventArgs(string category, string oldInstanceName, string newInstanceName, IReadOnlyCollection<string> counterNames)
	{
		Category = category;
		OldInstanceName = oldInstanceName;
		NewInstanceName = newInstanceName;
		CounterNames = counterNames;
	}
}
