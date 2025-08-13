using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Roblox.Amazon.Core;

/// <summary>
/// Overrides default InvokeAsync with proper timeout implementation.
/// </summary>
public class AsyncInvokeTimeoutHandler : PipelineHandler
{
	private readonly IAsyncInvokeTimeoutHandlerConfig _Config;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Core.AsyncInvokeTimeoutHandler" /> class.
	/// </summary>
	/// <param name="config">The configuration.</param>
	/// <exception cref="T:System.ArgumentNullException">config</exception>
	public AsyncInvokeTimeoutHandler(IAsyncInvokeTimeoutHandlerConfig config)
	{
		_Config = config ?? throw new ArgumentNullException("config");
	}

	/// <summary>
	/// Invokes handler in async way
	/// </summary>
	/// <param name="executionContext">The execution context which contains both the
	/// requests and response context.</param>
	public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
	{
		IRequestContext requestContext2 = executionContext.RequestContext;
		RequestContext requestContext = (RequestContext)(object)((requestContext2 is RequestContext) ? requestContext2 : null);
		if (requestContext == null)
		{
			return await _003C_003En__0<T>(executionContext);
		}
		using CancellationTokenSource timeoutTokenSource = new CancellationTokenSource(_Config.Timeout);
		CancellationToken initialCancellationToken = requestContext.CancellationToken;
		if (initialCancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(initialCancellationToken);
		}
		using CancellationTokenSource linkedCancelationSource = CancellationTokenSource.CreateLinkedTokenSource(initialCancellationToken, timeoutTokenSource.Token);
		_ = 1;
		try
		{
			requestContext.CancellationToken = linkedCancelationSource.Token;
			return await _003C_003En__1<T>(executionContext).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (OperationCanceledException ex)
		{
			if (timeoutTokenSource.IsCancellationRequested)
			{
				throw new AmazonServiceException("A WebException with status Timeout was thrown.", (Exception)new WebException("The operation has timed out", WebExceptionStatus.Timeout));
			}
			if (ex.CancellationToken != linkedCancelationSource.Token)
			{
				throw;
			}
			throw new OperationCanceledException(initialCancellationToken);
		}
		finally
		{
			requestContext.CancellationToken = initialCancellationToken;
		}
	}
}
