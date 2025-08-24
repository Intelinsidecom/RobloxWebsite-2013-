using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;

namespace Roblox.Http.Client;

public class RequestFailureThrowsHandler : PipelineHandler<IHttpRequest, IHttpResponse>
{
	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		try
		{
			base.Invoke(context);
		}
		catch (Exception innerException)
		{
			throw new HttpRequestFailedException(innerException);
		}
		CheckResponse(context.Output, context.Input);
	}

	public override async Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		try
		{
			await base.InvokeAsync(context, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (Exception innerException)
		{
			throw new HttpRequestFailedException(innerException);
		}
		CheckResponse(context.Output, context.Input);
	}

	protected virtual void CheckResponse(IHttpResponse httpResponse, IHttpRequest httpRequest)
	{
		if (httpResponse == null || httpResponse.IsSuccessful)
		{
			return;
		}
		throw new HttpRequestFailedException(httpResponse);
	}
}
