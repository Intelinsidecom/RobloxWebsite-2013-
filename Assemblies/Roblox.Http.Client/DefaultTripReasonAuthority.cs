using System;
using System.Collections.Generic;
using System.Net;
using Roblox.Pipeline;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Http.Client;

public class DefaultTripReasonAuthority : TripReasonAuthorityBase<IExecutionContext<IHttpRequest, IHttpResponse>>
{
	private static readonly ISet<HttpStatusCode> _HttpStatusCodesToTripOn = new HashSet<HttpStatusCode>
	{
		HttpStatusCode.BadGateway,
		HttpStatusCode.GatewayTimeout,
		HttpStatusCode.RequestTimeout
	};

	private static readonly ISet<WebExceptionStatus> _WebExceptionStatusesToTripOn = new HashSet<WebExceptionStatus>
	{
		WebExceptionStatus.ConnectFailure,
		WebExceptionStatus.ConnectionClosed,
		WebExceptionStatus.KeepAliveFailure,
		WebExceptionStatus.NameResolutionFailure,
		WebExceptionStatus.ReceiveFailure,
		WebExceptionStatus.SendFailure,
		WebExceptionStatus.ProxyNameResolutionFailure,
		WebExceptionStatus.RequestCanceled,
		WebExceptionStatus.Timeout
	};

	public override bool IsReasonForTrip(IExecutionContext<IHttpRequest, IHttpResponse> executionContext, Exception exception)
	{
		if (exception != null)
		{
			if (exception is HttpException && TripReasonAuthorityBase<IExecutionContext<IHttpRequest, IHttpResponse>>.TryGetInnerExceptionOfType<WebException>(exception, out var inner))
			{
				return _WebExceptionStatusesToTripOn.Contains(inner.Status);
			}
		}
		else if (executionContext?.Output != null && !executionContext.Output.IsSuccessful)
		{
			return _HttpStatusCodesToTripOn.Contains(executionContext.Output.StatusCode);
		}
		return false;
	}
}
