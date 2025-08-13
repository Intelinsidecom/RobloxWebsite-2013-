using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;
using Roblox.RequestContext;

namespace Roblox.Http.ServiceClient;

public class RequestContextHandler : PipelineHandler<IHttpRequest, IHttpResponse>
{
	private readonly IRequestContextLoader _RequestContextLoader;

	public RequestContextHandler(IRequestContextLoader requestContextLoader)
	{
		_RequestContextLoader = requestContextLoader ?? throw new ArgumentNullException("requestContextLoader");
	}

	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		foreach (KeyValuePair<string, string> item in _RequestContextLoader.GetCurrentContext().ToKeyValuePairs())
		{
			context.Input.Headers.Add(item.Key, item.Value);
		}
		base.Invoke(context);
	}

	public override Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		foreach (KeyValuePair<string, string> item in _RequestContextLoader.GetCurrentContext().ToKeyValuePairs())
		{
			context.Input.Headers.Add(item.Key, item.Value);
		}
		return base.InvokeAsync(context, cancellationToken);
	}
}
