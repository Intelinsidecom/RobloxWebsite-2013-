using System;
using Roblox.Platform.AbTesting.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AbTesting;

/// <summary>
/// Provides extensions methods on the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> interface.
/// </summary>
public static class UserIdentifierExtensions
{
	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> in an experiment.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to enroll in the experiment.</param>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <remarks>
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> will be enrolled in the active, enrolling version of the experiment.
	/// </remarks>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> that the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> was enrolled in.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformAlreadyEnrolledException">Thrown if the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> is already enrolled in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEnrollmentDeclinationException">Thrown if the enrollment was declined.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformInactiveVersionEnrollmentException">Thrown if there is no active, enrolling version of the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentDoesNotExistException">Thrown if <paramref name="experimentName" /> refers to an experiment that hasn't been created.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if the experiment cannot check eligibility because the check is unsupported.</exception>
	public static IEnrollment Enroll(this IUserIdentifier user, string experimentName, IVariationSelector variationSelector = null)
	{
		if (user == null)
		{
			throw new NullReferenceException();
		}
		return new UserSubject(user).Enroll(experimentName, variationSelector);
	}

	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> in an experiment, 
	/// returning only the value of the variation that the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> was enrolled into.
	/// The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> will be enrolled in the running, active version of the experiment.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to enroll.</param>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <returns>
	/// Returns the value of the variation that the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> will be enrolled into.
	/// If the subject was already enrolled in the experiment the <see cref="M:Roblox.Platform.AbTesting.UserIdentifierExtensions.EnrollTranslated(Roblox.Platform.MembershipCore.IUserIdentifier,System.String,Roblox.Platform.AbTesting.Core.IVariationSelector)" /> will return the value of the variation that the subject is enrolled in.
	/// If the subject was declined enrollment, if the experiment didn't exist, or if there was no active, running version of the experiment then <see cref="M:Roblox.Platform.AbTesting.UserIdentifierExtensions.EnrollTranslated(Roblox.Platform.MembershipCore.IUserIdentifier,System.String,Roblox.Platform.AbTesting.Core.IVariationSelector)" /> will return null.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if the experiment cannot check eligibility because the check is unsupported.</exception>
	public static int? EnrollTranslated(this IUserIdentifier user, string experimentName, IVariationSelector variationSelector = null)
	{
		if (user == null)
		{
			throw new NullReferenceException();
		}
		return new UserSubject(user).EnrollTranslated(experimentName, variationSelector);
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />'s <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> for the active version of the experiment with the given name.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <param name="experimentName">The name of the experiment to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> of the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> in the active version of the experiment, or null if none existed.
	/// Null is returned in the case that the given experiment doesn't exist or there is no active version of the experiment.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	public static IEnrollment GetActiveEnrollment(this IUserIdentifier user, string experimentName)
	{
		if (user == null)
		{
			throw new NullReferenceException();
		}
		return new UserSubject(user).GetActiveEnrollment(experimentName);
	}

	/// <summary>
	/// Gets the variation value that the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> is enrolled into in the active, running version of an experiment.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to get the active enrollment for.</param>
	/// <param name="experimentName">The name of the experiment to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <returns>The variation value that the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> is enrolled into in the active version of the experiment.
	/// Null is returned in the case that the given experiment doesn't exist, if there is no active version of the experiment, or if the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> is not enrolled.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	public static int? GetActiveEnrollmentTranslated(this IUserIdentifier user, string experimentName)
	{
		if (user == null)
		{
			throw new NullReferenceException();
		}
		return new UserSubject(user).GetActiveEnrollmentTranslated(experimentName);
	}
}
