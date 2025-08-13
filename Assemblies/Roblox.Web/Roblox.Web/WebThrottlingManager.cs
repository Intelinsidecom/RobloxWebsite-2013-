using System;
using System.Collections.Generic;
using System.Web;
using Roblox.Instrumentation;
using Roblox.Platform.Throttling;
using Roblox.Platform.Throttling.Implementation;

namespace Roblox.Web;

/// <summary>
/// THis class maintains the throttling characteristics of the requests. This can be used in Web MVC as well as Web API 2.0.
/// </summary>
public class WebThrottlingManager : IThrottlingManager
{
	private const string _PerformanceMonitorSuffix = ".MultiInstance";

	protected readonly string ThrottleNamespace;

	protected readonly IRequestFactory RequestFactory;

	private readonly IThrottler _Throttler;

	private readonly Func<int> _ThrottlePercentageGetter;

	private readonly Func<long?> _CurrentUserIdGetter;

	private readonly IGameServerRequestValidator _GameServerRequestValidator;

	protected readonly IThrottlingPerformanceMonitor PerformanceMonitor;

	protected readonly IFlaggedIpAddressAuthority FlaggedIpRangesAuthority;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.WebThrottlingManager" /> class.
	/// </summary>
	/// <param name="counterRegistry">The <see cref="T:Roblox.Instrumentation.ICounterRegistry" />The counter registry injected.</param>
	/// <param name="throttler">The <see cref="T:Roblox.Platform.Throttling.IThrottler" />.</param>
	/// <param name="requestFactory">The <see cref="T:Roblox.Platform.Throttling.IRequestFactory" />.</param>
	/// <param name="throttleNamespace">The throttle namespace.</param>
	/// <param name="throttlePercentageGetter">The throttle percentage getter.</param>
	/// <param name="currentUserIdGetter">The current user identifier getter.</param>
	/// <param name="gameServerRequestValidator">The <see cref="T:Roblox.Web.IGameServerRequestValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">throttler
	/// or
	/// requestFactory
	/// or
	/// throttlePercentageGetter
	/// or
	/// currentUserIdGetter</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if the <paramref name="throttleNamespace" /> is null or empty.</exception>
	public WebThrottlingManager(ICounterRegistry counterRegistry, IThrottler throttler, IRequestFactory requestFactory, string throttleNamespace, Func<int> throttlePercentageGetter, Func<long?> currentUserIdGetter, IGameServerRequestValidator gameServerRequestValidator)
		: this(counterRegistry, throttler, requestFactory, throttleNamespace, throttlePercentageGetter, currentUserIdGetter, new ThrottlingPerformanceMonitor(counterRegistry, throttleNamespace + ".MultiInstance"), new FlaggedIpRangesAuthority(), gameServerRequestValidator)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrEmpty(throttleNamespace))
		{
			throw new ArgumentException("throttleNamespace");
		}
	}

	protected internal WebThrottlingManager(ICounterRegistry counterRegistry, IThrottler throttler, IRequestFactory requestFactory, string throttleNamespace, Func<int> throttlePercentageGetter, Func<long?> currentUserIdGetter, IThrottlingPerformanceMonitor throttlingPerformanceMonitor, IFlaggedIpAddressAuthority flaggedIpRangesAuthority, IGameServerRequestValidator gameServerRequestValidator)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrEmpty(throttleNamespace))
		{
			throw new ArgumentException("throttleNamespace");
		}
		_Throttler = throttler ?? throw new ArgumentNullException("throttler");
		RequestFactory = requestFactory ?? throw new ArgumentNullException("requestFactory");
		ThrottleNamespace = throttleNamespace;
		_ThrottlePercentageGetter = throttlePercentageGetter ?? throw new ArgumentNullException("throttlePercentageGetter");
		_CurrentUserIdGetter = currentUserIdGetter ?? throw new ArgumentNullException("currentUserIdGetter");
		PerformanceMonitor = throttlingPerformanceMonitor ?? throw new ArgumentNullException("throttlingPerformanceMonitor");
		FlaggedIpRangesAuthority = flaggedIpRangesAuthority ?? throw new ArgumentNullException("flaggedIpRangesAuthority");
		_GameServerRequestValidator = gameServerRequestValidator ?? throw new ArgumentNullException("gameServerRequestValidator");
	}

	/// <summary>
	/// Returns whether the current request is throttled or not.
	/// </summary>
	/// <param name="requestsForCurrentContext">The <see cref="T:Roblox.Platform.Throttling.IRequest" />.</param>
	/// <param name="executionDateTime">The execution date time.</param>
	/// <param name="requester">The <see cref="T:Roblox.Web.RequesterType" /></param>
	/// <param name="actionName">Name of the action or the route.</param>
	/// <returns>
	/// True if the request is throttled, false otherwise.
	/// </returns>
	public bool IsRequestAllowed(List<IRequest> requestsForCurrentContext, DateTime executionDateTime, RequesterType requester, string actionName)
	{
		IncrementRequestCounter(requester, actionName);
		bool isRequestAllowed = true;
		foreach (IRequest request in requestsForCurrentContext)
		{
			if (request.IsEnabled())
			{
				if (_Throttler.IsRequestAllowed(request))
				{
					_Throttler.RecordRequest(request, executionDateTime);
				}
				else
				{
					isRequestAllowed = false;
				}
			}
		}
		if (!isRequestAllowed)
		{
			IncrementThrottledRequestCounter(requester, actionName);
		}
		return isRequestAllowed;
	}

	/// <summary>
	/// Determines whether [is local throttling enabled].
	/// </summary>
	/// <returns>
	/// True if Local Throttling was enabled, false otherwise.
	/// </returns>
	public bool IsLocalThrottlingEnabled()
	{
		int throttlePercentage = _ThrottlePercentageGetter();
		return throttlePercentage switch
		{
			100 => true, 
			0 => false, 
			_ => new Random(new object().GetHashCode()).Next(0, 100) <= throttlePercentage, 
		};
	}

	/// <summary>
	/// Gets <see cref="T:Roblox.Platform.Throttling.IRequest" /> for current context.
	/// </summary>
	/// <param name="requester">The <see cref="!:RequesterIdentifier.Requester" />.</param>
	/// <param name="requestBase">The requestBase.</param>
	/// <param name="originIp">The origin ip.</param>
	/// <param name="actionName">Name of the action or the route.</param>
	/// <returns>
	/// The <see cref="T:Roblox.Platform.Throttling.IRequest" /> for the current request made.
	/// </returns>
	/// <exception cref="T:System.ArgumentException">No authenticated user found for authenticated request.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException"></exception>
	public virtual List<IRequest> GetRequestListForCurrentContext(RequesterType requester, HttpRequestBase requestBase, string originIp, string actionName)
	{
		List<IRequest> requestsForCurrentContext = new List<IRequest>();
		switch (requester)
		{
		case RequesterType.GameServer:
		{
			Guid gameInstanceId = _GameServerRequestValidator.GetGameInstanceId(requestBase.Headers);
			int currentNumberOfPlayers = _GameServerRequestValidator.GetCurrentNumberOfPlayers(requestBase.Headers);
			IRequest request = RequestFactory.GetGameServerRequest(gameInstanceId.ToString(), currentNumberOfPlayers, ThrottleNamespace, actionName);
			requestsForCurrentContext.Add(request);
			return requestsForCurrentContext;
		}
		case RequesterType.AuthenticatedUser:
		{
			long? userId = _CurrentUserIdGetter();
			if (!userId.HasValue)
			{
				throw new ArgumentException("No authenticated user found for authenticated request.");
			}
			requestsForCurrentContext.Add(RequestFactory.GetUserRequestByUserId(userId.Value, ThrottleNamespace, actionName));
			break;
		}
		case RequesterType.UnauthenticatedUser:
			requestsForCurrentContext.Add(RequestFactory.GetUserRequestByIpAddress(originIp, ThrottleNamespace, actionName));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		requestsForCurrentContext.Add(RequestFactory.GetIpRequestByIpAddress(originIp, ThrottleNamespace, actionName));
		if (FlaggedIpRangesAuthority.IsIpAddressStringFlagged(originIp))
		{
			requestsForCurrentContext.Add(RequestFactory.GetFlaggedIpRangesRequest(ThrottleNamespace, actionName));
		}
		return requestsForCurrentContext;
	}

	/// <summary>
	/// Records a request for telemetry.
	/// </summary>
	/// <param name="requester"></param>
	/// <param name="actionName"></param>
	protected virtual void IncrementRequestCounter(RequesterType requester, string actionName)
	{
		PerformanceMonitor.IncrementTotalRequests(requester, actionName);
	}

	/// <summary>
	/// Records a throttled request for telemetry.
	/// </summary>
	/// <param name="requester"></param>
	/// <param name="actionName"></param>
	protected virtual void IncrementThrottledRequestCounter(RequesterType requester, string actionName)
	{
		PerformanceMonitor.IncrementThrottledRequests(requester, actionName);
	}
}
