using System;

namespace Roblox.Platform.Throttling;

/// <summary>
/// Represents context of a request as how it should be recorded
/// and how many requests per timespan it is allowed.
/// </summary>
public interface IRequest
{
	/// <summary>
	/// Returns whether or not this request should be recorded or throttled. Used
	/// if no default throttling should be applied for example.
	/// </summary>
	bool IsEnabled();

	/// <summary>
	/// Returns the key under which this request should be recorded in the
	/// datastore used by the <see cref="T:Roblox.Platform.Throttling.IThrottler">IThrottler</see>
	/// </summary>
	string GetKey();

	/// <summary>
	/// Returns timespan after which throttling should expire
	/// when the budget has been exceeded.
	/// </summary>
	TimeSpan GetExpirationInterval();

	/// <summary>
	/// The amount of attempts allowed for this context
	/// before throttling should be applied
	/// </summary>
	long GetBudget();
}
