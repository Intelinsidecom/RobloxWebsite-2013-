using System;

namespace Roblox.CommunitySift;

internal interface ICommunitySiftPerformanceMonitor
{
	void Increment(TimeSpan requestTime, PerformanceCounterRequestType requestType);

	void IncrementException(object request, TimeSpan requestTime, PerformanceCounterRequestType requestType, Exception ex);

	void IncrementResponseIsFalseHashIsWrong();

	void IncrementResponseIsTrueHashIsSet();

	void IncrementResponseIsTrueHashesCountDiffers();
}
