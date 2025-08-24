namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for a subject that can enroll in an experiment.
/// </summary>
public interface ISubject
{
	/// <summary>
	/// Gets the subject's target ID.
	/// </summary>
	long TargetId { get; }

	/// <summary>
	/// Gets the subject's type.
	/// </summary>
	string Type { get; }

	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> in an experiment.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <remarks>
	/// The <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> will be enrolled in the active, enrolling version of the experiment. Upon successful enrollment <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentSucceeded" /> will be invoked.
	/// </remarks>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> that the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> was enrolled in.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformAlreadyEnrolledException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> is already enrolled in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEnrollmentDeclinationException">Thrown if the enrollment was declined.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformInactiveVersionEnrollmentException">Thrown if there is no active, enrolling version of the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentDoesNotExistException">Thrown if <paramref name="experimentName" /> refers to an experiment that hasn't been created.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if the experiment cannot check eligibility because the check is unsupported.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	IEnrollment Enroll(string experimentName, IVariationSelector variationSelector = null);

	/// <summary>
	/// Forcibly enrolls the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> in an experiment. This method ignores <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />s and the subject will never be left out.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in.</param>
	/// <remarks>
	/// The <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> will be enrolled in the active, enrolling version of the experiment. Upon successful enrollment <see cref="E:Roblox.Platform.AbTesting.Core.EnrollmentEvents.EnrollmentSucceeded" /> will be invoked.
	/// </remarks>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> that the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> was enrolled in.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="variationSelector" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformAlreadyEnrolledException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> is already enrolled in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEnrollmentDeclinationException">Thrown if the enrollment was declined.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformInactiveVersionEnrollmentException">Thrown if there is no active, enrolling version of the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentDoesNotExistException">Thrown if <paramref name="experimentName" /> refers to an experiment that hasn't been created.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	IEnrollment ForceEnroll(string experimentName, IVariationSelector variationSelector);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> of an <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> for the active version of the experiment with the given name.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> of the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> in the active version of the experiment, or null if none existed.
	/// Null is returned in the case that the given experiment doesn't exist or there is no active version of the experiment.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	IEnrollment GetActiveEnrollment(string experimentName);
}
