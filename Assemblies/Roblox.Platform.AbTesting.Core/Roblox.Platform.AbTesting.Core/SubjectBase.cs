using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Represents a base class for a subject that can enroll in an experiment.
/// </summary>
public abstract class SubjectBase : ISubject
{
	private const string _ExclusivityDeclinationMessage = "Subject is enrolled in an exclusive experiment";

	private const string _LeftOutDeclinationMessage = "Subject was left out of version";

	private readonly IExperimentFactory _ExperimentFactory;

	private readonly IVersionFactory _VersionFactory;

	private readonly IEnrollmentFactory _EnrollmentFactory;

	private readonly IEnrollmentDeclinationFactory _EnrollmentDeclinationFactory;

	private readonly IEligibilityCriterionTypeFactory _EligibilityCriterionTypeFactory;

	private readonly IEligibilityCheckerRegistry _EligibilityCheckerRegistry;

	private int? _TypeId;

	public abstract long TargetId { get; }

	public abstract string Type { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.SubjectBase" /> class.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="versionFactory" /> is null.</exception>
	protected SubjectBase(IVersionFactory versionFactory)
		: this(new ExperimentFactory(versionFactory), versionFactory, new EnrollmentFactory(), new EnrollmentDeclinationFactory(), new EligibilityCriterionTypeFactory(), EligibilityCheckerRegistry.Instance)
	{
	}

	internal SubjectBase(IExperimentFactory experimentFactory, IVersionFactory versionFactory, IEnrollmentFactory enrollmentFactory, IEnrollmentDeclinationFactory enrollmentDeclinationFactory, IEligibilityCriterionTypeFactory eligibilityCriterionTypeFactory, IEligibilityCheckerRegistry eligibilityCheckerRegistry)
	{
		if (versionFactory == null)
		{
			throw new PlatformArgumentNullException("versionFactory");
		}
		_ExperimentFactory = experimentFactory;
		_VersionFactory = versionFactory;
		_EnrollmentFactory = enrollmentFactory;
		_EnrollmentDeclinationFactory = enrollmentDeclinationFactory;
		_EligibilityCriterionTypeFactory = eligibilityCriterionTypeFactory;
		_EligibilityCheckerRegistry = eligibilityCheckerRegistry;
	}

	public IEnrollment Enroll(string experimentName, IVariationSelector variationSelector = null)
	{
		if (variationSelector == null)
		{
			variationSelector = PercentageVariationSelector.Instance;
		}
		return Enroll(experimentName, variationSelector, forceEnroll: false);
	}

	public IEnrollment ForceEnroll(string experimentName, IVariationSelector variationSelector)
	{
		return Enroll(experimentName, variationSelector, forceEnroll: true);
	}

	public IEnrollment GetActiveEnrollment(string experimentName)
	{
		try
		{
			IExperiment experiment = _ExperimentFactory.GetByName(experimentName);
			if (experiment == null)
			{
				return null;
			}
			byte? experimentLockedOnVariationValue = experiment.GetLockedOnVariationValue();
			if (experimentLockedOnVariationValue.HasValue)
			{
				throw new PlatformExperimentLockedOnException(experimentLockedOnVariationValue.Value);
			}
			if (experiment.Version == 0)
			{
				return null;
			}
			IVersion mostRecentVersion = _VersionFactory.GetByExperimentIdAndVersionNumber(experiment.Id, experiment.Version);
			if (mostRecentVersion == null || !mostRecentVersion.IsRunning(GetCurrentTime()))
			{
				return null;
			}
			return _EnrollmentFactory.GetByVersionIdSubjectTypeIdAndSubjectTargetId(mostRecentVersion.Id, GetSubjectTypeId(), TargetId);
		}
		finally
		{
			EnrollmentEvents.InvokeEnrollmentChecked();
		}
	}

	/// <summary>
	/// Gets the active, enrolling version of the given <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" />.
	/// </summary>
	/// <param name="experiment">The <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to get the active, enrolling version of.</param>
	/// <param name="currentTime">The current time.</param>
	/// <returns>The active, enrolling version of the given <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" />, or null if there isn't one.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experiment" /> is null.</exception>
	private IVersion GetEnrollingVersion(IExperiment experiment, DateTime currentTime)
	{
		if (experiment == null)
		{
			throw new PlatformArgumentNullException("experiment");
		}
		if (experiment.Version == 0)
		{
			return null;
		}
		IVersion mostRecentVersion = _VersionFactory.GetByExperimentIdAndVersionNumber(experiment.Id, experiment.Version);
		if (mostRecentVersion == null || !mostRecentVersion.IsEnrolling(currentTime))
		{
			return null;
		}
		return mostRecentVersion;
	}

	/// <summary>
	/// Determines whether or not the given <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> is enrolled in the given <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />.
	/// </summary>
	/// <param name="version">The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />.</param>
	/// <param name="subjectTargetId">The <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" />'s target ID.</param>
	/// <param name="subjectTypeId">The <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" />'s type ID.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> with the given target and type IDs is already enrolled in <paramref name="version" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="version" /> is null.</exception>
	private bool IsAlreadyEnrolled(IVersion version, long subjectTargetId, int subjectTypeId)
	{
		if (version == null)
		{
			throw new PlatformArgumentNullException("version");
		}
		return _EnrollmentFactory.GetByVersionIdSubjectTypeIdAndSubjectTargetId(version.Id, subjectTypeId, subjectTargetId) != null;
	}

	/// <summary>
	/// Determines whether or not the given <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> has already been declined enrollment in the given <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />.
	/// </summary>
	/// <param name="version">The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> to check declination for.</param>
	/// <param name="subjectTargetId">The target ID of the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> to check declination for.</param>
	/// <param name="subjectTypeId">The type ID of the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> to check declination for.</param>
	/// <param name="declination">If the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> was previously declined then <paramref name="declination" /> will be assigned the previous declination. Otherwise it will be assigned null.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> has already been declined enrollment into <paramref name="version" />.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="version" /> is null.</exception>
	private bool IsAlreadyDeclined(IVersion version, long subjectTargetId, int subjectTypeId, out IEnrollmentDeclination declination)
	{
		if (version == null)
		{
			throw new PlatformArgumentNullException("version");
		}
		declination = _EnrollmentDeclinationFactory.GetByVersionIdSubjectTypeIdAndSubjectTargetId(version.Id, subjectTypeId, subjectTargetId);
		return declination != null;
	}

	/// <summary>
	/// Determines whether or not enrolling a subject with the given target ID and type ID into the given <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> would violate any exclusivity rules.
	/// </summary>
	/// <param name="experiment">The <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to check the enrollment for.</param>
	/// <param name="subjectTargetId">The target ID of the subject.</param>
	/// <param name="subjectTypeId">The type ID of the subject.</param>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not enrolling the subject in <paramref name="experiment" /> would violate exclusivity rules.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experiment" /> is null.</exception>
	private bool DoesEnrollViolateExclusivity(IExperiment experiment, long subjectTargetId, int subjectTypeId, DateTime currentTime)
	{
		if (experiment == null)
		{
			throw new PlatformAlreadyEnrolledException("experiment");
		}
		foreach (IVersion activeVersion in _VersionFactory.GetAllActiveVersions())
		{
			if (activeVersion.IsRunning(currentTime))
			{
				IExperiment activeExperiment = _ExperimentFactory.GetById(activeVersion.ExperimentId);
				if (activeExperiment == null)
				{
					throw new PlatformDataIntegrityException($"Experiment version '{activeVersion.Id}' associated with non-existent experiment '{activeVersion.ExperimentId}'");
				}
				if (_EnrollmentFactory.GetByVersionIdSubjectTypeIdAndSubjectTargetId(activeVersion.Id, subjectTypeId, subjectTargetId) != null && (activeExperiment.IsEnrollmentExclusive || experiment.IsEnrollmentExclusive))
				{
					return true;
				}
			}
		}
		return false;
	}

	/// <summary>
	/// Determines whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> should be left out of the given version.
	/// </summary>
	/// <param name="version">The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> should be left out of the given version.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="version" /> is null.</exception>
	private bool ShouldLeaveOutOfVersion(IVersion version)
	{
		if (version == null)
		{
			throw new PlatformArgumentNullException("version");
		}
		return GetRandomPercentage() >= version.PercentOfSubjectsToEnroll;
	}

	/// <summary>
	/// Enrolls the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> in an experiment.
	/// </summary>
	/// <param name="experimentName">The name of the experiment to enroll in.</param>
	/// <param name="variationSelector">The <see cref="T:Roblox.Platform.AbTesting.Core.IVariationSelector" /> used to determine which variation the subject should be enrolled in. This parameter is optional and if it's left null then a new <see cref="T:Roblox.Platform.AbTesting.Core.PercentageVariationSelector" /> will be used.</param>
	/// <param name="forceEnroll">Whether or not to forcibly enroll the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" />. If true, then <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityChecker" />s will be ignored and the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> cannot be left out.</param>
	/// <remarks>
	/// The <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> will be enrolled in the active, enrolling version of the experiment.
	/// </remarks>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> that the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> was enrolled in.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="experimentName" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if the desired variation to enroll in did not exist.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformAlreadyEnrolledException">Thrown if the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" /> is already enrolled in the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEnrollmentDeclinationException">Thrown if the enrollment was declined.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformInactiveVersionEnrollmentException">Thrown if there is no active, enrolling version of the experiment.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentDoesNotExistException">Thrown if <paramref name="experimentName" /> refers to an experiment that hasn't been created.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformEligibilityCheckNotSupportedException">Thrown if <paramref name="forceEnroll" /> is false and the experiment cannot check eligibility because the check is unsupported.</exception>
	/// <exception cref="T:Roblox.Platform.AbTesting.Core.PlatformExperimentLockedOnException">Thrown if the experiment has been locked on.</exception>
	private IEnrollment Enroll(string experimentName, IVariationSelector variationSelector, bool forceEnroll)
	{
		if (experimentName == null)
		{
			throw new PlatformArgumentNullException("experimentName");
		}
		if (variationSelector == null)
		{
			throw new PlatformArgumentNullException("variationSelector");
		}
		EnrollmentEvents.InvokeEnrollmentAttempting();
		IExperiment experiment = _ExperimentFactory.GetByName(experimentName);
		if (experiment == null)
		{
			throw new PlatformExperimentDoesNotExistException($"Cannot enroll in experiment name '{experimentName}' because it does not exist");
		}
		byte? experimentLockedOnVariationValue = experiment.GetLockedOnVariationValue();
		if (experimentLockedOnVariationValue.HasValue)
		{
			throw new PlatformExperimentLockedOnException(experimentLockedOnVariationValue.Value);
		}
		DateTime currentTime = GetCurrentTime();
		IVersion mostRecentVersion = GetEnrollingVersion(experiment, currentTime);
		if (mostRecentVersion == null)
		{
			throw new PlatformInactiveVersionEnrollmentException($"Experiment '{experiment.Name}'");
		}
		int subjectTypeId = GetSubjectTypeId();
		if (IsAlreadyEnrolled(mostRecentVersion, TargetId, subjectTypeId) && !forceEnroll)
		{
			throw new PlatformAlreadyEnrolledException();
		}
		if (IsAlreadyDeclined(mostRecentVersion, TargetId, subjectTypeId, out var declination))
		{
			if (!forceEnroll)
			{
				throw new PlatformEnrollmentDeclinationException($"Previously declined with reason ID '{declination.DeclinationReasonTypeId}'");
			}
			_EnrollmentDeclinationFactory.Delete(declination.Id);
			if (IsAlreadyDeclined(mostRecentVersion, TargetId, subjectTypeId, out var deletedDeclination))
			{
				throw new PlatformEnrollmentDeclinationException($"Force enroll declined with reason ID '{deletedDeclination.DeclinationReasonTypeId}'");
			}
		}
		if (DoesEnrollViolateExclusivity(experiment, TargetId, subjectTypeId, currentTime))
		{
			int exclusivityReasonTypeId = GetDeclinationReasonTypeId("Subject is enrolled in an exclusive experiment");
			_EnrollmentDeclinationFactory.GetOrCreate(mostRecentVersion.Id, subjectTypeId, TargetId, exclusivityReasonTypeId);
			EnrollmentEvents.InvokeEnrollmentDeclined();
			throw new PlatformEnrollmentDeclinationException("Subject is enrolled in an exclusive experiment");
		}
		if (!forceEnroll)
		{
			IEnumerable<IEligibilityCriterionType> eligibilityCheckerTypes = _EligibilityCriterionTypeFactory.GetByExperimentId(experiment.Id);
			List<IEligibilityChecker> list = eligibilityCheckerTypes.Select((IEligibilityCriterionType eligibilityCheckerType) => _EligibilityCheckerRegistry.Construct(eligibilityCheckerType.Value)).ToList();
			if (list.Any((IEligibilityChecker checker) => checker == null))
			{
				throw new PlatformEligibilityCheckNotSupportedException(string.Format(arg2: string.Join(",", eligibilityCheckerTypes.Select((IEligibilityCriterionType el) => el.Value)), format: "Experiment '{0}' ({1}) depends on unsupported eligibility checkers (for type {2})", arg0: experiment.Name, arg1: experiment.Id));
			}
			foreach (IEligibilityChecker eligibilityChecker in (IEnumerable<IEligibilityChecker>)list)
			{
				if (!eligibilityChecker.IsEligible())
				{
					string eligibilityCheckerReason = $"Subject failed eligibility checker of type '{eligibilityChecker.GetType().Name}'";
					int eligibilityCheckerDeclinationReasonTypeId = GetDeclinationReasonTypeId(eligibilityCheckerReason);
					_EnrollmentDeclinationFactory.GetOrCreate(mostRecentVersion.Id, subjectTypeId, TargetId, eligibilityCheckerDeclinationReasonTypeId);
					EnrollmentEvents.InvokeEnrollmentDeclined();
					throw new PlatformEnrollmentDeclinationException(eligibilityCheckerReason);
				}
			}
			if (ShouldLeaveOutOfVersion(mostRecentVersion))
			{
				int leftOutReasonId = GetDeclinationReasonTypeId("Subject was left out of version");
				_EnrollmentDeclinationFactory.GetOrCreate(mostRecentVersion.Id, subjectTypeId, TargetId, leftOutReasonId);
				EnrollmentEvents.InvokeEnrollmentDeclined();
				throw new PlatformEnrollmentDeclinationException("Subject was left out of version");
			}
		}
		IVariation selectedVariation = variationSelector.Select(mostRecentVersion);
		bool created;
		IEnrollment newEnrollment = _EnrollmentFactory.GetOrCreate(mostRecentVersion.Id, subjectTypeId, TargetId, selectedVariation.Id, out created);
		if (!created)
		{
			if (selectedVariation.Id == newEnrollment.VariationId)
			{
				throw new PlatformAlreadyEnrolledException("Already enrolled in selected variation.");
			}
			if (!forceEnroll)
			{
				throw new PlatformAlreadyEnrolledException();
			}
			_EnrollmentFactory.Delete(newEnrollment.Id);
			newEnrollment = _EnrollmentFactory.GetOrCreate(mostRecentVersion.Id, subjectTypeId, TargetId, selectedVariation.Id, out var forceCreated);
			if (!forceCreated)
			{
				throw new PlatformAlreadyEnrolledException("Could not force enroll into selected variation.");
			}
		}
		EnrollmentEvents.InvokeEnrollmentSucceeded(newEnrollment);
		return newEnrollment;
	}

	[ExcludeFromCodeCoverage]
	internal virtual DateTime GetCurrentTime()
	{
		return DateTime.Now;
	}

	[ExcludeFromCodeCoverage]
	internal virtual int GetSubjectTypeId()
	{
		if (_TypeId.HasValue)
		{
			return _TypeId.Value;
		}
		_TypeId = SubjectType.GetOrCreate(Type).ID;
		return _TypeId.Value;
	}

	[ExcludeFromCodeCoverage]
	internal virtual byte GetRandomPercentage()
	{
		return (byte)new Random(new object().GetHashCode()).Next(100);
	}

	[ExcludeFromCodeCoverage]
	internal virtual int GetDeclinationReasonTypeId(string reason)
	{
		if (reason == null)
		{
			throw new PlatformArgumentNullException("reason");
		}
		return DeclinationReasonType.GetOrCreate(reason).ID;
	}
}
