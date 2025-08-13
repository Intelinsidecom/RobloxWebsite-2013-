using System;

namespace Roblox.Time;

/// <summary>
/// An Implmenetation of IInstantProvider based on the local server time
/// </summary>
public class InstantProvider : IInstantProvider
{
	public UtcInstant GetCurrentUtcInstant()
	{
		return new UtcInstant(DateTime.UtcNow);
	}
}
