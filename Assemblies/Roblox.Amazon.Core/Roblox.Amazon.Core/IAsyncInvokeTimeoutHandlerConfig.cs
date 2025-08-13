using System;

namespace Roblox.Amazon.Core;

/// <summary>
/// <see cref="T:Roblox.Amazon.Core.AsyncInvokeTimeoutHandler" /> configuration.
/// </summary>
public interface IAsyncInvokeTimeoutHandlerConfig
{
	/// <summary>
	/// Gets the timeout.
	/// </summary>
	TimeSpan Timeout { get; }
}
