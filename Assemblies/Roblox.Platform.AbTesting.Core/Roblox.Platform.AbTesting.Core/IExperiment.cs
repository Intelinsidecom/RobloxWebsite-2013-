using System;

namespace Roblox.Platform.AbTesting.Core;

public interface IExperiment
{
	int Id { get; }

	string Name { get; }

	int Variations { get; }

	byte Version { get; }

	bool IsEnrollmentExclusive { get; }

	DateTime Created { get; }

	DateTime Updated { get; }

	/// <summary>
	/// Creates a new version for the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> and makes it the active version.
	/// </summary>
	/// <param name="enrollmentPeriod">The amount of time to enroll subjects in the version of the experiment.</param>
	/// <param name="runPeriod">The amount of time to run the version of the experiment.</param>
	/// <param name="variationPercentages">The values to set the variation percentages to. Must add up to 100.</param>
	/// <param name="percentOfSubjectsToEnroll">The percentage of subjects that will be enrolled into the version.</param>
	/// <returns>Returns the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> that was created.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> already has an active, running version.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> has been locked on.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="variationPercentages" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="enrollmentPeriod" /> or <paramref name="runPeriod" /> is negative.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="runPeriod" /> is longer than <paramref name="enrollmentPeriod" />.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="variationPercentages" /> does not add up to 100, the number of percentages 
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="percentOfSubjectsToEnroll" /> is less than or equal to 0 or greater than 100.</exception>
	/// does not match the number of variations the experiment has, or a percentage is less than 0.</exception>
	IVersion CreateNewVersion(TimeSpan enrollmentPeriod, TimeSpan runPeriod, int[] variationPercentages, byte percentOfSubjectsToEnroll);

	/// <summary>
	/// Gets the variation value that the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> is locked onto, or null if the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> is not locked on.
	/// </summary>
	/// <returns>The variation value that the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> is locked onto, or null if the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> is not locked on.</returns>
	byte? GetLockedOnVariationValue();

	/// <summary>
	/// Locks the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> onto the given variation value.
	/// </summary>
	/// <param name="variationValue">The variation value to lock the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> onto.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="variationValue" /> is greater than or equal to the number of variations in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> has a running, active version.</exception>
	void LockToVariationValue(byte variationValue);

	/// <summary>
	/// Unlocks the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" />.
	/// </summary>
	void Unlock();
}
