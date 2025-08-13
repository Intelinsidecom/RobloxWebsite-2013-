namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for an object that has enrollment performance counters.
/// </summary>
public interface IEnrollmentPerformanceMonitor
{
	/// <summary>
	/// Increments the counter used to track attempted enrollments.
	/// </summary>
	void IncrementEnrollmentAttemptCounter();

	/// <summary>
	/// Increments the counter used to track successful enrollments.
	/// </summary>
	void IncrementEnrollmentSuccessCounter();

	/// <summary>
	/// Increments the counter used to track newly declined enrollments.
	/// </summary>
	void IncrementEnrollmentDeclinationCounter();

	/// <summary>
	/// Increments the counter used to track enrollment checks.
	/// </summary>
	void IncrementEnrollmentCheckCounter();
}
