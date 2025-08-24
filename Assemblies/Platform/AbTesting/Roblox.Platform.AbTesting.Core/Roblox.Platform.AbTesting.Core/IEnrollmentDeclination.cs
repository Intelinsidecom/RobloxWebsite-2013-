using System;

namespace Roblox.Platform.AbTesting.Core;

internal interface IEnrollmentDeclination
{
	long Id { get; }

	int SubjectTypeId { get; }

	long SubjectTargetId { get; }

	int VersionId { get; }

	int DeclinationReasonTypeId { get; }

	DateTime Created { get; }
}
