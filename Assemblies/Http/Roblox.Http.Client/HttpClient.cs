using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;

namespace Roblox.Http.Client;

public class HttpClient : IHttpClient
{
	internal CookieContainer CookieContainer { get; }

	public IExecutionPlan<IHttpRequest, IHttpResponse> HttpExecutionPlan { get; internal set; }

	public HttpClient(CookieContainer cookieContainer = null, IHttpClientSettings httpClientSettings = null)
	{
		cookieContainer = cookieContainer ?? new CookieContainer();
		httpClientSettings = httpClientSettings ?? new DefaultHttpClientSettings();
		ExecutionPlan<IHttpRequest, IHttpResponse> executionPlan = new ExecutionPlan<IHttpRequest, IHttpResponse>();
		executionPlan.AppendHandler(new SendHttpRequestHandler(cookieContainer, httpClientSettings));
		CookieContainer = cookieContainer;
		HttpExecutionPlan = executionPlan;
	}

	public IHttpResponse Send(IHttpRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return HttpExecutionPlan.Execute(request);
	}

	public Task<IHttpResponse> SendAsync(IHttpRequest request, CancellationToken cancellationToken)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		return HttpExecutionPlan.ExecuteAsync(request, cancellationToken);
	}
}
