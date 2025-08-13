using System;

namespace Roblox.Kickbox.PerformanceCounters;

internal interface IKickboxPerformanceMonitorBase
{
	void Increment(TimeSpan requestTime);

	void IncrementException(object request, TimeSpan requestTime, Exception ex);
}
