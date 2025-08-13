using System;

namespace Roblox.Platform.Throttling;

/// <summary>
/// Managers allowing or blocking requests and recording request counts.
/// </summary>
public interface IThrottler
{
	/// <summary>
	/// Based on the budget, expiration, and record of previous recorded requests for the
	/// input <see cref="T:Roblox.Platform.Throttling.IRequest">request</see> determines if the request should be throttled.
	/// </summary>
	/// <param name="request"></param>
	/// <returns></returns>
	bool IsRequestAllowed(IRequest request);

	/// <summary>
	/// Increments the stored count of the input <see cref="T:Roblox.Platform.Throttling.IRequest">request</see>.
	/// </summary>
	/// <param name="request"></param>
	/// <param name="executionDateTime"></param>
	void RecordRequest(IRequest request, DateTime executionDateTime);
}
