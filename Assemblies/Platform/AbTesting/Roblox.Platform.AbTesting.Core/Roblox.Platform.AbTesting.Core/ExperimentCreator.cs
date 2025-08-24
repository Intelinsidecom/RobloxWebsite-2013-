using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

public class ExperimentCreator : IExperimentCreator
{
	private const int _ExperimentNameMaxLength = 100;

	private readonly IExperimentFactory _ExperimentFactory;

	private readonly IVersionFactory _VersionFactory;

	private readonly ILockedOnExperimentSettingFactory _LockedOnExperimentSettingFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.ExperimentCreator" /> class.
	/// </summary>
	public ExperimentCreator(IVersionFactory versionFactory)
		: this(new ExperimentFactory(versionFactory), versionFactory, new LockedOnExperimentSettingFactory())
	{
	}

	internal ExperimentCreator(IExperimentFactory experimentFactory, IVersionFactory versionFactory, ILockedOnExperimentSettingFactory lockedOnExperimentSettingFactory)
	{
		_ExperimentFactory = experimentFactory;
		_VersionFactory = versionFactory;
		_LockedOnExperimentSettingFactory = lockedOnExperimentSettingFactory;
	}

	public IExperiment Create(string name, byte numberOfVariations, bool isExclusive, IEnumerable<IEligibilityCriterionType> eligibilityCriterionTypes)
	{
		if (eligibilityCriterionTypes == null)
		{
			throw new PlatformArgumentNullException("eligibilityCriterionTypes");
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new PlatformArgumentException("Please provide a name for your experiment. Follow ABTest Naming Convention: i.e. AllUsers.LandingPage.Animated2014 (Whether the test is for NewUsers or AllUsers; Where the test will be applied; What the AB Test affects / does)");
		}
		name = name.TrimAll();
		if (name.Length > 100)
		{
			throw new PlatformArgumentException($"Your experiment name has {name.Length} characters when the max number of characters allowed is {100}. Please choose a shorter name for your experiment and try again.");
		}
		if (name.Split('.').Length < 3)
		{
			throw new PlatformArgumentException("Please follow ABTest Naming Convention: i.e. AllUsers.LandingPage.Animated2014 (Whether the test is for NewUsers or AllUsers; Where the test will be applied; What the AB Test affects / does)");
		}
		if (numberOfVariations <= 0)
		{
			throw new PlatformArgumentException("numberOfVariations");
		}
		List<IEligibilityCriterionType> list = eligibilityCriterionTypes.ToList();
		if (list.Any((IEligibilityCriterionType t) => t == null))
		{
			throw new PlatformArgumentException("eligibilityCriterionTypes");
		}
		if (_ExperimentFactory.GetByName(name) != null)
		{
			throw new PlatformInvalidOperationException($"Experiment with name '{name}' already exists");
		}
		Experiment createdExperiment = new Experiment(_VersionFactory, _LockedOnExperimentSettingFactory)
		{
			IsEnrollmentExclusive = isExclusive,
			Name = name,
			Variations = numberOfVariations
		};
		SaveExperiment(createdExperiment);
		foreach (IEligibilityCriterionType eligibilityCriterionType in list)
		{
			EligibilityCriterion eligibilityCriteria = new EligibilityCriterion
			{
				EligibilityCriterionTypeId = eligibilityCriterionType.Id,
				ExperimentId = createdExperiment.Id
			};
			SaveEligibilityCriterion(eligibilityCriteria);
		}
		return createdExperiment;
	}

	internal virtual void SaveEligibilityCriterion(EligibilityCriterion eligibilityCriterion)
	{
		if (eligibilityCriterion == null)
		{
			throw new PlatformArgumentNullException("eligibiltyCriterion");
		}
		eligibilityCriterion.Save();
	}

	internal virtual void SaveExperiment(Experiment experiment)
	{
		if (experiment == null)
		{
			throw new PlatformArgumentNullException("experiment");
		}
		experiment.Save();
	}
}
