using System;

namespace Roblox.Amazon.Core;

/// <summary>
/// <see cref="T:Roblox.Amazon.Core.AsyncInvokeTimeoutHandler" /> configuration.
/// </summary>
/// <seealso cref="T:Roblox.Amazon.Core.IAsyncInvokeTimeoutHandlerConfig" />
public class AsyncInvokeTimeoutHandlerConfig : IAsyncInvokeTimeoutHandlerConfig
{
	/// <summary>
	/// Gets the timeout.
	/// </summary>
	public TimeSpan Timeout { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Core.AsyncInvokeTimeoutHandlerConfig" /> class.
	/// </summary>
	/// <param name="timeout">The timeout.</param>
	public AsyncInvokeTimeoutHandlerConfig(TimeSpan timeout)
	{
		Timeout = timeout;
	}
}
