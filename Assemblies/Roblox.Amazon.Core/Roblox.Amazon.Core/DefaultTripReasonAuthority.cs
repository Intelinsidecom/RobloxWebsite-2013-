using System;
using System.Collections.Generic;
using System.Net;
using Amazon.Runtime;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Core;

/// <summary>
/// AWS specific implementation of <see cref="T:Roblox.Sentinels.CircuitBreakerPolicy.ITripReasonAuthority`1" /> for <see cref="T:Roblox.Sentinels.CircuitBreakerPolicy.CircuitBreakerPolicyBase`1" />.
/// </summary>
public class DefaultTripReasonAuthority : TripReasonAuthorityBase<IExecutionContext>
{
	/// <summary>
	/// List of HTTP Status codes codes which are returned as part of the error response.
	/// These status codes can cause circuit break.
	/// </summary>
	private static readonly ISet<HttpStatusCode> _HttpStatusCodesToTripOn = new HashSet<HttpStatusCode>
	{
		HttpStatusCode.BadGateway,
		HttpStatusCode.GatewayTimeout
	};

	/// <summary>
	/// List of AWS specific error codes which are returned as part of the error response.
	/// These error can cause circuit break.
	/// </summary>
	private static readonly ISet<string> _ErrorCodesToTripOn = new HashSet<string> { "RequestTimeout" };

	/// <summary>
	/// List of WebExceptionStatus for a WebException which can cause circuit break.
	/// </summary>
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

	/// <inheritdoc cref="M:Roblox.Sentinels.CircuitBreakerPolicy.TripReasonAuthorityBase`1.IsReasonForTrip(`0,System.Exception)" />
	public override bool IsReasonForTrip(IExecutionContext executionContext, Exception exception)
	{
		AmazonServiceException serviceException;
		if (exception == null || (serviceException = (AmazonServiceException)(object)((exception is AmazonServiceException) ? exception : null)) == null)
		{
			return false;
		}
		if (_HttpStatusCodesToTripOn.Contains(serviceException.StatusCode))
		{
			return true;
		}
		if ((serviceException.StatusCode == HttpStatusCode.BadRequest || serviceException.StatusCode == HttpStatusCode.ServiceUnavailable) && _ErrorCodesToTripOn.Contains(serviceException.ErrorCode))
		{
			return true;
		}
		if (TripReasonAuthorityBase<IExecutionContext>.TryGetInnerExceptionOfType<WebException>(exception, out var webException))
		{
			return _WebExceptionStatusesToTripOn.Contains(webException.Status);
		}
		return false;
	}
}
