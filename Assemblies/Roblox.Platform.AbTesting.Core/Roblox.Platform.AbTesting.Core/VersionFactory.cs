using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.AbTesting.Core.Entities;

namespace Roblox.Platform.AbTesting.Core;

public class VersionFactory : IVersionFactory
{
	public IVersion GetById(int id)
	{
		Roblox.Platform.AbTesting.Core.Entities.Version entity = Roblox.Platform.AbTesting.Core.Entities.Version.Get(id);
		if (entity != null)
		{
			return new Version(entity);
		}
		return null;
	}

	public IVersion GetByExperimentIdAndVersionNumber(int experimentId, byte versionNumber)
	{
		Roblox.Platform.AbTesting.Core.Entities.Version entity = Roblox.Platform.AbTesting.Core.Entities.Version.GetByExperimentIDAndVersion(experimentId, versionNumber);
		if (entity != null)
		{
			return new Version(entity);
		}
		return null;
	}

	public IEnumerable<IVersion> GetByIsActive(bool isActive, int startRow, int maxRows)
	{
		List<IVersion> versions = new List<IVersion>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.Version> page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByIsActivePaged(isActive, startRowIndex, 10L).ToList();
		versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByIsActivePaged(isActive, startRowIndex, 10L).ToList();
			versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		}
		return versions;
	}

	public IEnumerable<IVersion> GetByExperimentId(int experimentId)
	{
		List<IVersion> versions = new List<IVersion>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.Version> page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByExperimentIDPaged(experimentId, startRowIndex, 10L).ToList();
		versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByExperimentIDPaged(experimentId, startRowIndex, 10L).ToList();
			versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		}
		return versions;
	}

	public IEnumerable<IVersion> GetAllActiveVersions()
	{
		List<IVersion> versions = new List<IVersion>();
		int startRowIndex = 1;
		List<Roblox.Platform.AbTesting.Core.Entities.Version> page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByIsActivePaged(isActive: true, startRowIndex, 10L).ToList();
		versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		while (page.Count == 10)
		{
			startRowIndex += 10;
			page = Roblox.Platform.AbTesting.Core.Entities.Version.GetVersionsByIsActivePaged(isActive: true, startRowIndex, 10L).ToList();
			versions.AddRange(page.Select((Roblox.Platform.AbTesting.Core.Entities.Version entity) => new Version(entity)));
		}
		return versions;
	}
}
