using System;

namespace Roblox.Platform.AbTesting.Core;

internal interface ILockedOnExperimentSetting
{
	int Id { get; }

	int ExperimentId { get; }

	byte? LockedOnVariationValue { get; set; }

	DateTime Created { get; }

	DateTime Updated { get; }

	void Save();
}
