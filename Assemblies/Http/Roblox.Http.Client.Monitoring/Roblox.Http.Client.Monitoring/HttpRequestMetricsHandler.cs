using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Instrumentation;
using Roblox.Pipeline;

namespace Roblox.Http.Client.Monitoring;

public sealed class HttpRequestMetricsHandler : PipelineHandler<IHttpRequest, IHttpResponse>
{
	private readonly Lazy<ClientRequestsMonitor> _ClientMonitor;

	public HttpRequestMetricsHandler(ICounterRegistry counterRegistry, string metricsCategoryName, string clientName)
	{
		if (string.IsNullOrWhiteSpace(metricsCategoryName))
		{
			throw new ArgumentException("Must be something like Roblox.Http.ServiceClient", "metricsCategoryName");
		}
		if (string.IsNullOrWhiteSpace(clientName))
		{
			throw new ArgumentException("Must identify the client like MyServiceClient", "clientName");
		}
		_ClientMonitor = new Lazy<ClientRequestsMonitor>(() => ClientRequestsMonitor.GetOrCreate(counterRegistry, metricsCategoryName, clientName));
	}

	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		Stopwatch stopwatch = RequestStarted(context.Input);
		try
		{
			base.Invoke(context);
			EvaluateResponse(context);
		}
		catch (Exception)
		{
			RequestFailed(context.Input);
			throw;
		}
		finally
		{
			RequestFinished(context.Input, stopwatch);
		}
	}

	public override async Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		Stopwatch requestTimer = RequestStarted(context.Input);
		try
		{
			await base.InvokeAsync(context, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			EvaluateResponse(context);
		}
		catch (Exception)
		{
			RequestFailed(context.Input);
			throw;
		}
		finally
		{
			RequestFinished(context.Input, requestTimer);
		}
	}

	private void EvaluateResponse(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		if (context.Output.IsSuccessful)
		{
			RequestSucceeded(context.Input);
		}
		else
		{
			RequestFailed(context.Input);
		}
	}

	private Stopwatch RequestStarted(IHttpRequest request)
	{
		string absolutePath = request.Url.AbsolutePath;
		_ClientMonitor.Value.AddOutstandingRequest(absolutePath);
		return Stopwatch.StartNew();
	}

	private void RequestFinished(IHttpRequest request, Stopwatch stopwatch)
	{
		string absolutePath = request.Url.AbsolutePath;
		stopwatch.Stop();
		_ClientMonitor.Value.AddResponseTime(absolutePath, stopwatch);
		_ClientMonitor.Value.RemoveOutstandingRequest(absolutePath);
	}

	private void RequestSucceeded(IHttpRequest request)
	{
		string absolutePath = request.Url.AbsolutePath;
		_ClientMonitor.Value.AddRequestSuccess(absolutePath);
	}

	private void RequestFailed(IHttpRequest request)
	{
		string absolutePath = request.Url.AbsolutePath;
		_ClientMonitor.Value.AddRequestFailure(absolutePath);
	}
}
