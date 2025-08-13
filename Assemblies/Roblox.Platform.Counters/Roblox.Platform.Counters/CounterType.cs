using System;

namespace Roblox.Platform.Counters;

/// <summary>
/// Represents the time bucket of a counter
/// </summary>
[Flags]
public enum CounterType
{
	/// <summary>
	/// An hourly counter
	/// </summary>
	Hourly = 4,
	/// <summary>
	/// A daily counter
	/// </summary>
	Daily = 8,
	/// <summary>
	/// A monthly counter
	/// </summary>
	Monthly = 0x10,
	/// <summary>
	/// An all-time counter
	/// </summary>
	AllTime = 0x20
}
