using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.AbTesting.Core;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting;

/// <summary>
/// Represents a <see cref="T:Roblox.Platform.AbTesting.Core.SubjectBase" /> with additional calls to condense consumer logic.
/// </summary>
public abstract class TranslatedSubjectBase : SubjectBase
{
	private readonly IVariationFactory _VariationFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> class.
	/// </summary>
	protected TranslatedSubjectBase()
		: this(VariationFactory.Instance, new VersionFactory())
	{
	}

	[ExcludeFromCodeCoverage]
	internal TranslatedSubjectBase(IVariationFactory variationFactory, IVersionFactory versionFactory)
		: base(versionFactory)
	{
		if (variationFactory == null)
		{
			throw new PlatformArgumentNullException("variationFactory");
		}
		_VariationFactory = variationFactory;
	}

	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> in an experiment.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <remarks>
	/// The <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> will be enrolled in the active, enrolling version of the experiment.
	/// </remarks>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> that the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> was enrolled in.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformAlreadyEnrolledException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> is already enrolled in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEnrollmentDeclinationException">Thrown if the enrollment was declined.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformInactiveVersionEnrollmentException">Thrown if there is no active, enrolling version of the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentDoesNotExistException">Thrown if <paramref name="experimentName" /> refers to an experiment that hasn't been created.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if the experiment cannot check eligibility because the check is unsupported.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	[ExcludeFromCodeCoverage]
	public new virtual IEnrollment Enroll(string experimentName, IVariationSelector variationSelector = null)
	{
		return base.Enroll(experimentName, variationSelector);
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> of an <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> for the active version of the experiment with the given name.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> of the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> in the active version of the experiment, or null if none existed.
	/// Null is returned in the case that the given experiment doesn't exist or there is no active version of the experiment.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	[ExcludeFromCodeCoverage]
	public new virtual IEnrollment GetActiveEnrollment(string experimentName)
	{
		return base.GetActiveEnrollment(experimentName);
	}

	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> in an experiment, 
	/// returning only the value of the variation that the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> was enrolled into.
	/// The <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> will be enrolled in the running, active version of the experiment.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <returns>
	/// Returns the value of the variation that the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> will be enrolled into.
	/// If the subject was already enrolled in the experiment the <see cref="M:Roblox.Platform.AbTesting.TranslatedSubjectBase.EnrollTranslated(System.String,Roblox.Platform.AbTesting.Core.IVariationSelector)" /> will return the value of the variation that the subject is enrolled in.
	/// If the subject was declined enrollment, if the experiment didn't exist, or if there was no active, running version of the experiment then <see cref="M:Roblox.Platform.AbTesting.TranslatedSubjectBase.EnrollTranslated(System.String,Roblox.Platform.AbTesting.Core.IVariationSelector)" /> will return null.
	/// If the experiment was locked on then the variation value that the experiment was locked onto will be returned.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if the experiment cannot check eligibility because the check is unsupported.</exception>
	public int? EnrollTranslated(string experimentName, IVariationSelector variationSelector = null)
	{
		IEnrollment enrollment;
		try
		{
			enrollment = Enroll(experimentName, variationSelector);
		}
		catch (PlatformAlreadyEnrolledException)
		{
			enrollment = GetActiveEnrollment(experimentName);
		}
		catch (PlatformEnrollmentDeclinationException)
		{
			enrollment = null;
		}
		catch (PlatformExperimentDoesNotExistException)
		{
			enrollment = null;
		}
		catch (PlatformInactiveVersionEnrollmentException)
		{
			enrollment = GetActiveEnrollment(experimentName);
		}
		catch (PlatformExperimentLockedOnException ex5)
		{
			return ex5.VariationValue;
		}
		if (enrollment == null)
		{
			return null;
		}
		return _VariationFactory.GetById(enrollment.VariationId).Value;
	}

	/// <summary>
	/// Gets the variation value that the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> is enrolled into in the active, running version of an experiment.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to get the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> for.</param>
	/// <returns>The variation value that the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> is enrolled into in the active version of the experiment.
	/// Null is returned in the case that the given experiment doesn't exist, if there is no active version of the experiment, or if the <see cref="T:Roblox.Platform.AbTesting.TranslatedSubjectBase" /> is not enrolled.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	public int? GetActiveEnrollmentTranslated(string experimentName)
	{
		IEnrollment enrollment;
		try
		{
			enrollment = GetActiveEnrollment(experimentName);
		}
		catch (PlatformExperimentLockedOnException ex)
		{
			return ex.VariationValue;
		}
		if (enrollment == null)
		{
			return null;
		}
		return _VariationFactory.GetById(enrollment.VariationId).Value;
	}
}
