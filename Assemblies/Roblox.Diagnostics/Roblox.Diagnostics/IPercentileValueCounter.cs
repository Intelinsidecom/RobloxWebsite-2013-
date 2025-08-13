using System;

namespace Roblox.Diagnostics;

public interface IPercentileValueCounter : IDisposable
{
	void Sample(double value);
}
