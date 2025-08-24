using System;

namespace Roblox.Diagnostics;

public interface IAverageValueCounter : IDisposable
{
	void Sample(long value);
}
