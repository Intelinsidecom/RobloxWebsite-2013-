using System;

namespace Roblox.Diagnostics;

[Obsolete("Use Roblox.Instrumentation instead of Windows Perfmon counters")]
[AttributeUsage(AttributeTargets.Class)]
public class CounterCategory : Attribute
{
	public readonly string CategoryName;

	/// <summary>
	/// Automatically regenerates the performance category if any
	/// any of the counters have changed. You may need to restart
	/// the WMI service afterwards
	/// </summary>
	public bool IsAutoUpdateEnabled;

	public string CategoryHelp = string.Empty;

	public CounterCategory(string name)
	{
		CategoryName = name;
	}
}
