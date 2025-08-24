using System;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class Experiment : IExperiment
{
	private readonly IVersionFactory _VersionFactory;

	private readonly ILockedOnExperimentSettingFactory _LockedOnExperimentSettingFactory;

	public int Id { get; internal set; }

	public string Name { get; internal set; }

	public int Variations { get; internal set; }

	public byte Version { get; internal set; }

	public bool IsEnrollmentExclusive { get; internal set; }

	public DateTime Created { get; internal set; }

	public DateTime Updated { get; internal set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.Experiment" /> class with the given <see cref="T:Roblox.Platform.AbTesting.Core.IVersionFactory" />.
	/// </summary>
	/// <param name="versionFactory"></param>
	/// <param name="lockedOnExperimentSettingFactory"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="versionFactory" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="lockedOnExperimentSettingFactory" /> is null.</exception>
	public Experiment(IVersionFactory versionFactory, ILockedOnExperimentSettingFactory lockedOnExperimentSettingFactory)
	{
		if (versionFactory == null)
		{
			throw new PlatformArgumentNullException("versionFactory");
		}
		if (lockedOnExperimentSettingFactory == null)
		{
			throw new PlatformArgumentNullException("lockedOnExperimentSettingFactory");
		}
		_VersionFactory = versionFactory;
		_LockedOnExperimentSettingFactory = lockedOnExperimentSettingFactory;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.Experiment" /> class with the given <see cref="T:Roblox.Platform.AbTesting.Core.Entities.Experiment" />.
	/// </summary>
	/// <param name="entity">The <see cref="T:Roblox.Platform.AbTesting.Core.Entities.Experiment" /> to construct the <see cref="T:Roblox.Platform.AbTesting.Core.Experiment" /> from.</param>
	/// <param name="versionFactory">The <see cref="T:Roblox.Platform.AbTesting.Core.IVersionFactory" /> to use in creating new versions.</param>
	/// <param name="lockedOnExperimentSettingFactory"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="entity" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="versionFactory" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="lockedOnExperimentSettingFactory" /> is null.</exception>
	internal Experiment(Roblox.Platform.AbTesting.Core.Entities.Experiment entity, IVersionFactory versionFactory, ILockedOnExperimentSettingFactory lockedOnExperimentSettingFactory)
		: this(versionFactory, lockedOnExperimentSettingFactory)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		Name = entity.Name;
		Variations = entity.Variations;
		Version = entity.Version;
		IsEnrollmentExclusive = entity.IsEnrollmentExclusive;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public IVersion CreateNewVersion(TimeSpan enrollmentPeriod, TimeSpan runPeriod, int[] variationPercentages, byte percentOfSubjects)
	{
		if (enrollmentPeriod <= TimeSpan.Zero)
		{
			throw new PlatformArgumentException("'enrollmentPeriod' must be greater than zero");
		}
		if (runPeriod <= TimeSpan.Zero)
		{
			throw new PlatformArgumentException("'runPeriod' must be greater than zero");
		}
		if (enrollmentPeriod > runPeriod)
		{
			throw new PlatformArgumentException("'enrollmentPeriod' must be at least as long as 'runPeriod'");
		}
		if (variationPercentages == null)
		{
			throw new PlatformArgumentNullException("percentages");
		}
		if (variationPercentages.Any((int percentage) => percentage < 0))
		{
			throw new PlatformArgumentException("'percentages' cannot contain a percentage less than 0");
		}
		if (variationPercentages.Sum() != 100)
		{
			throw new PlatformArgumentException("Given percentages do not add up to 100%");
		}
		if (Variations != variationPercentages.Length)
		{
			throw new PlatformArgumentException("Number of percentages given does not match the number of variations in the experiment");
		}
		if (percentOfSubjects <= 0 || percentOfSubjects > 100)
		{
			throw new PlatformArgumentException("'percentOfSubjects' must be between between 0 (exclusive) and 100 (inclusive)");
		}
		ILockedOnExperimentSetting lockedOnSetting = _LockedOnExperimentSettingFactory.GetOrCreateByExperimentId(Id);
		if (lockedOnSetting.LockedOnVariationValue.HasValue)
		{
			throw new PlatformExperimentLockedOnException(lockedOnSetting.LockedOnVariationValue.Value);
		}
		DateTime currentTime = GetCurrentTime();
		IVersion mostRecentVersion = ((Version != 0) ? _VersionFactory.GetByExperimentIdAndVersionNumber(Id, Version) : null);
		if (mostRecentVersion != null && mostRecentVersion.IsRunning(currentTime))
		{
			throw new PlatformInvalidOperationException("Experiment already has an active version running");
		}
		Version++;
		Version newVersion = new Version
		{
			EnrollmentPeriod = enrollmentPeriod,
			EndDate = currentTime + runPeriod,
			ExperimentId = Id,
			Started = currentTime,
			IsActive = true,
			VersionNumber = Version,
			PercentOfSubjectsToEnroll = percentOfSubjects
		};
		Variation[] newVariations = new Variation[Variations];
		for (int i = 0; i < variationPercentages.Length; i++)
		{
			int percentage2 = variationPercentages[i];
			newVariations[i] = new Variation
			{
				ExperimentId = Id,
				VersionNumber = Version,
				PercentEnrollments = percentage2,
				Value = i
			};
		}
		SaveVersion(newVersion);
		Variation[] array = newVariations;
		foreach (Variation variation in array)
		{
			SaveVariation(variation);
		}
		Save();
		return newVersion;
	}

	public byte? GetLockedOnVariationValue()
	{
		if (Id == 0)
		{
			throw new PlatformException("The experiment must be persisted before GetLockedOnVariationValue can be called");
		}
		return _LockedOnExperimentSettingFactory.GetOrCreateByExperimentId(Id).LockedOnVariationValue;
	}

	public void LockToVariationValue(byte variationValue)
	{
		if (variationValue >= Variations)
		{
			throw new PlatformArgumentException("'variationValue' must be less than the number of variations in the experiment");
		}
		if (Id == 0)
		{
			throw new PlatformException("The experiment must be persisted before it can be locked");
		}
		DateTime currentTime = GetCurrentTime();
		IVersion mostRecentVersion = ((Version != 0) ? _VersionFactory.GetByExperimentIdAndVersionNumber(Id, Version) : null);
		if (mostRecentVersion != null && mostRecentVersion.IsRunning(currentTime))
		{
			throw new PlatformInvalidOperationException("Cannot lock on experiment that's active");
		}
		ILockedOnExperimentSetting lockedOnSetting = _LockedOnExperimentSettingFactory.GetOrCreateByExperimentId(Id);
		if (lockedOnSetting.LockedOnVariationValue != variationValue)
		{
			lockedOnSetting.LockedOnVariationValue = variationValue;
			lockedOnSetting.Save();
		}
	}

	public void Unlock()
	{
		if (Id == 0)
		{
			throw new PlatformException("The experiment must be persisted before it can be unlocked");
		}
		ILockedOnExperimentSetting lockedOnSetting = _LockedOnExperimentSettingFactory.GetOrCreateByExperimentId(Id);
		if (lockedOnSetting.LockedOnVariationValue.HasValue)
		{
			lockedOnSetting.LockedOnVariationValue = null;
			lockedOnSetting.Save();
		}
	}

	protected virtual void SaveVariation(Variation variation)
	{
		if (variation == null)
		{
			throw new PlatformArgumentNullException("variation");
		}
		variation.Save();
	}

	protected virtual void SaveVersion(Version version)
	{
		if (version == null)
		{
			throw new PlatformArgumentNullException("version");
		}
		version.Save();
	}

	/// <summary>
	/// Gets the current time.
	/// </summary>
	/// <returns>The current time.</returns>
	protected virtual DateTime GetCurrentTime()
	{
		return DateTime.Now;
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.Experiment entity = Roblox.Platform.AbTesting.Core.Entities.Experiment.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.Experiment();
		entity.Version = Version;
		entity.Created = Created;
		entity.IsEnrollmentExclusive = IsEnrollmentExclusive;
		entity.Variations = Variations;
		entity.Name = Name;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
