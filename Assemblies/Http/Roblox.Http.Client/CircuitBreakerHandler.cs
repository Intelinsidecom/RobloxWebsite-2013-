using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Http.Client;

public sealed class CircuitBreakerHandler : PipelineHandler<IHttpRequest, IHttpResponse>, IDisposable
{
	private readonly ICircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>> _CircuitBreakerPolicy;

	private bool _Disposed;

	public CircuitBreakerHandler(ICircuitBreakerPolicy<IExecutionContext<IHttpRequest, IHttpResponse>> circuitBreakerPolicy)
	{
		_CircuitBreakerPolicy = circuitBreakerPolicy ?? throw new ArgumentNullException("circuitBreakerPolicy");
	}

	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		_CircuitBreakerPolicy.ThrowIfTripped(context);
		try
		{
			base.Invoke(context);
			_CircuitBreakerPolicy.NotifyRequestFinished(context);
		}
		catch (Exception exception)
		{
			_CircuitBreakerPolicy.NotifyRequestFinished(context, exception);
			throw;
		}
	}

	public override async Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		_CircuitBreakerPolicy.ThrowIfTripped(context);
		try
		{
			await base.InvokeAsync(context, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			_CircuitBreakerPolicy.NotifyRequestFinished(context);
		}
		catch (Exception exception)
		{
			_CircuitBreakerPolicy.NotifyRequestFinished(context, exception);
			throw;
		}
	}

	public void Dispose()
	{
		if (!_Disposed)
		{
			_CircuitBreakerPolicy?.Dispose();
			_Disposed = true;
		}
	}
}
