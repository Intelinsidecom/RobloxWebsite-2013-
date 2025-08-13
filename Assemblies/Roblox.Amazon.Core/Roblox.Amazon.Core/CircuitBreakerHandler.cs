using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Roblox.Sentinels.CircuitBreakerPolicy;

namespace Roblox.Amazon.Core;

/// <summary>
/// Wrapes invocation with circuit breaker functionality.
/// </summary>
public class CircuitBreakerHandler : PipelineHandler, IDisposable
{
	private bool _Disposed;

	/// <summary>
	/// The CircuitBreaker policy which specifies when 
	/// a CircuitBreaker should be performed.
	/// </summary>
	public ICircuitBreakerPolicy<IExecutionContext> CircuitBreakerPolicy { get; }

	/// <summary>
	/// Constructor which takes in a CircuitBreaker policy.
	/// </summary>
	/// <param name="circuitBreakerPolicy">CircuitBreaker Policy <see cref="P:Roblox.Amazon.Core.CircuitBreakerHandler.CircuitBreakerPolicy" /></param>
	public CircuitBreakerHandler(ICircuitBreakerPolicy<IExecutionContext> circuitBreakerPolicy)
	{
		CircuitBreakerPolicy = circuitBreakerPolicy ?? throw new ArgumentNullException("circuitBreakerPolicy");
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="executionContext">The execution context which contains both the
	/// requests and response context.</param>
	public override void InvokeSync(IExecutionContext executionContext)
	{
		CircuitBreakerPolicy.ThrowIfTripped(executionContext);
		try
		{
			((PipelineHandler)this).InvokeSync(executionContext);
			CircuitBreakerPolicy.NotifyRequestFinished(executionContext);
		}
		catch (Exception exception)
		{
			CircuitBreakerPolicy.NotifyRequestFinished(executionContext, exception);
			throw;
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="executionContext">The execution context which contains both the
	/// requests and response context.</param>
	public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
	{
		CircuitBreakerPolicy.ThrowIfTripped(executionContext);
		try
		{
			T result = await _003C_003En__0<T>(executionContext).ConfigureAwait(continueOnCapturedContext: false);
			CircuitBreakerPolicy.NotifyRequestFinished(executionContext);
			return result;
		}
		catch (Exception exception)
		{
			CircuitBreakerPolicy.NotifyRequestFinished(executionContext, exception);
			throw;
		}
	}

	/// <summary>
	/// Disposes the current instance.
	/// </summary>
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources.
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_Disposed)
		{
			if (disposing)
			{
				CircuitBreakerPolicy?.Dispose();
			}
			_Disposed = true;
		}
	}
}
