using System;

namespace Roblox.Platform.AbTesting.Core;

public interface IVariation
{
	int Id { get; }

	int ExperimentId { get; }

	int Value { get; }

	int PercentEnrollments { get; }

	byte VersionNumber { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
