using System;

namespace Roblox.GameInstances.Client;

[Flags]
public enum PlaySessionFlags : long
{
	None = 0L,
	IsPremium = 1L,
	IsPaying = 2L
}
