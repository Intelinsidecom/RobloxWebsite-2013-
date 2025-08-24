using System;

namespace Roblox.Platform.AbTesting.Core;

public interface IVersion
{
	int Id { get; }

	int ExperimentId { get; }

	byte VersionNumber { get; }

	TimeSpan EnrollmentPeriod { get; }

	DateTime Started { get; }

	DateTime EndDate { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	bool IsActive { get; }

	byte PercentOfSubjectsToEnroll { get; }

	/// <summary>
	/// Deactivates the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> if it's active.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	void Deactivate(DateTime currentTime);

	/// <summary>
	/// Determines whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> is currently running.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> is currently running.</returns>
	bool IsRunning(DateTime currentTime);

	/// <summary>
	/// Determines whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> is currently enrolling.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> is currently enrolling.</returns>
	bool IsEnrolling(DateTime currentTime);

	/// <summary>
	/// Updates the enrollment end date for the version.
	/// </summary>
	/// <param name="enrollmentEndDate">The date at which enrollment in the version should end.</param>
	/// <param name="currentTime">The current time.</param>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformUnmodifiableVersionException">Thrown if the version's enrollment period can no longer be modified.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="enrollmentEndDate" /> is incompatible with the version's start and end dates.</exception>
	void SetEnrollmentEndDate(DateTime enrollmentEndDate, DateTime currentTime);

	/// <summary>
	/// Updates the run end date for the version.
	/// </summary>
	/// <param name="endDate">The date at which the version should end.</param>
	/// <param name="currentTime">The current time.</param>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformUnmodifiableVersionException">Thrown if the version's end date can no longer be set.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="endDate" /> is incompatible with the version's start and enrollment end dates, or if the end date would be extended.</exception>
	void SetEndDate(DateTime endDate, DateTime currentTime);
}
