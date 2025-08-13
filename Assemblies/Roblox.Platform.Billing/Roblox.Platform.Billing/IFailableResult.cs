using System;

namespace Roblox.Platform.Billing;

/// <summary>
/// Result that can potentially fail
/// <typeparam name="T">The error code enum indicating reason for failure</typeparam>
/// </summary>
public interface IFailableResult<T> where T : struct, IConvertible
{
	/// <summary>
	/// Reason for failure
	/// </summary>
	T FailureReason { get; set; }

	/// <summary>
	/// If the operation was successful
	/// </summary>
	bool IsSuccess { get; set; }
}
