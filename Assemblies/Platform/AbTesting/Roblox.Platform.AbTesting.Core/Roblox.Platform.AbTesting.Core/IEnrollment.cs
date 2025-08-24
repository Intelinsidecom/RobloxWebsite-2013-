using System;

namespace Roblox.Platform.AbTesting.Core;

public interface IEnrollment
{
	long Id { get; }

	int SubjectTypeId { get; }

	long SubjectTargetId { get; }

	int VariationId { get; }

	int VersionId { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
