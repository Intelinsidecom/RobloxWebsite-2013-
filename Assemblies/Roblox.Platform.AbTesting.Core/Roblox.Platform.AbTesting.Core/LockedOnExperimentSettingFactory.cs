using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.AbTesting.Core.Implementation;

namespace Roblox.Platform.AbTesting.Core;

internal class LockedOnExperimentSettingFactory : ILockedOnExperimentSettingFactory
{
	public ILockedOnExperimentSetting GetOrCreateByExperimentId(int experimentId)
	{
		Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting entity = Roblox.Platform.AbTesting.Core.Entities.LockedOnExperimentSetting.GetOrCreate(experimentId);
		if (entity != null)
		{
			return new Roblox.Platform.AbTesting.Core.Implementation.LockedOnExperimentSetting(entity);
		}
		return null;
	}
}
