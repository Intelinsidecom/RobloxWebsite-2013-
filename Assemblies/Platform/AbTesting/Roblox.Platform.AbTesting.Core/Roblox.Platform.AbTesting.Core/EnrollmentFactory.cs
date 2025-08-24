using Roblox.Platform.AbTesting.Core.Entities;

namespace Roblox.Platform.AbTesting.Core;

internal class EnrollmentFactory : IEnrollmentFactory
{
	/// <inheritdoc />
	public IEnrollment GetByVersionIdSubjectTypeIdAndSubjectTargetId(int versionId, int subjectTypeId, long subjectTargetId)
	{
		Roblox.Platform.AbTesting.Core.Entities.Enrollment entity = Roblox.Platform.AbTesting.Core.Entities.Enrollment.GetBySubjectTypeIDSubjectTargetIDAndVersionID(subjectTypeId, subjectTargetId, versionId);
		if (entity != null)
		{
			return new Enrollment(entity);
		}
		return null;
	}

	/// <inheritdoc />
	public IEnrollment GetOrCreate(int versionId, int subjectTypeId, long subjectTargetId, int variationId, out bool created)
	{
		Roblox.Platform.AbTesting.Core.Entities.Enrollment entity = Roblox.Platform.AbTesting.Core.Entities.Enrollment.GetOrCreate(subjectTypeId, subjectTargetId, versionId, variationId, out created);
		if (entity != null)
		{
			return new Enrollment(entity);
		}
		return null;
	}

	/// <inheritdoc />
	public void Delete(long id)
	{
		Roblox.Platform.AbTesting.Core.Entities.Enrollment.Get(id)?.Delete();
	}
}
