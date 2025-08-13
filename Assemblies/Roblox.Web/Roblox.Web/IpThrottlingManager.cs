using System;
using System.Collections.Generic;
using System.Web;
using Roblox.Instrumentation;
using Roblox.Platform.Throttling;
using Roblox.Platform.Throttling.Implementation;

namespace Roblox.Web;

public class IpThrottlingManager : WebThrottlingManager
{
	public IpThrottlingManager(ICounterRegistry counterRegistry, IThrottler throttler, IRequestFactory requestFactory, string throttleNamespace, Func<int> throttlePercentageGetter, Func<long?> currentUserIdGetter, IGameServerRequestValidator gameServerRequestValidator)
		: base(counterRegistry, throttler, requestFactory, throttleNamespace, throttlePercentageGetter, currentUserIdGetter, gameServerRequestValidator)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
	}

	protected internal IpThrottlingManager(ICounterRegistry counterRegistry, IThrottler throttler, IRequestFactory requestFactory, string throttleNamespace, Func<int> throttlePercentageGetter, Func<long?> currentUserIdGetter, IThrottlingPerformanceMonitor throttlingPerformanceMonitor, IFlaggedIpAddressAuthority flaggedIpRangesAuthority, IGameServerRequestValidator gameServerRequestValidator)
		: base(counterRegistry, throttler, requestFactory, throttleNamespace, throttlePercentageGetter, currentUserIdGetter, throttlingPerformanceMonitor, flaggedIpRangesAuthority, gameServerRequestValidator)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
	}

	public override List<IRequest> GetRequestListForCurrentContext(RequesterType requester, HttpRequestBase requestBase, string originIp, string actionName)
	{
		List<IRequest> requestsForCurrentContext = new List<IRequest>();
		if (requester == RequesterType.GameServer)
		{
			return requestsForCurrentContext;
		}
		requestsForCurrentContext.Add(RequestFactory.GetIpRequestByIpAddress(originIp, ThrottleNamespace, actionName));
		if (FlaggedIpRangesAuthority.IsIpAddressStringFlagged(originIp))
		{
			requestsForCurrentContext.Add(RequestFactory.GetFlaggedIpRangesRequest(ThrottleNamespace, actionName));
		}
		return requestsForCurrentContext;
	}

	protected override void IncrementRequestCounter(RequesterType requester, string actionName)
	{
	}
}
