using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

public class ExperimentFactory : IExperimentFactory
{
	private readonly IVersionFactory _VersionFactory;

	private readonly ILockedOnExperimentSettingFactory _LockedOnExperimentSettingFactory;

	public ExperimentFactory(IVersionFactory versionFactory)
		: this(versionFactory, new LockedOnExperimentSettingFactory())
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.ExperimentFactory" /> class.
	/// </summary>
	/// <param name="versionFactory"></param>
	/// <param name="lockedOnExperimentSettingFactory"></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="versionFactory" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="lockedOnExperimentSettingFactory" /> is null.</exception>
	internal ExperimentFactory(IVersionFactory versionFactory, ILockedOnExperimentSettingFactory lockedOnExperimentSettingFactory)
	{
		if (versionFactory == null)
		{
			throw new PlatformArgumentNullException("versionFactory");
		}
		if (lockedOnExperimentSettingFactory == null)
		{
			throw new PlatformArgumentNullException("lockedOnExperimentSettingFactory");
		}
		_LockedOnExperimentSettingFactory = lockedOnExperimentSettingFactory;
		_VersionFactory = versionFactory;
	}

	public IExperiment GetById(int id)
	{
		Roblox.Platform.AbTesting.Core.Entities.Experiment entity = Roblox.Platform.AbTesting.Core.Entities.Experiment.Get(id);
		if (entity != null)
		{
			return new Experiment(entity, _VersionFactory, _LockedOnExperimentSettingFactory);
		}
		return null;
	}

	public IExperiment GetByName(string name)
	{
		if (name == null)
		{
			throw new PlatformArgumentNullException("name");
		}
		Roblox.Platform.AbTesting.Core.Entities.Experiment entity = Roblox.Platform.AbTesting.Core.Entities.Experiment.GetByName(name);
		if (entity != null)
		{
			return new Experiment(entity, _VersionFactory, _LockedOnExperimentSettingFactory);
		}
		return null;
	}

	public IEnumerable<IExperiment> GetAllExperiments()
	{
		List<IExperiment> experiments = new List<IExperiment>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.Experiment> page = Roblox.Platform.AbTesting.Core.Entities.Experiment.GetExperimentsPaged(startRowIndex, 10L).ToList();
		experiments.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Experiment entity) => new Experiment(entity, _VersionFactory, _LockedOnExperimentSettingFactory)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.Experiment.GetExperimentsPaged(startRowIndex, 10L).ToList();
			experiments.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Experiment entity) => new Experiment(entity, _VersionFactory, _LockedOnExperimentSettingFactory)));
		}
		return experiments;
	}
}
