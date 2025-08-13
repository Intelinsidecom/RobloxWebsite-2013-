using Roblox.Platform.AbTesting.Core.Entities;

namespace Roblox.Platform.AbTesting.Core;

internal class EnrollmentDeclinationFactory : IEnrollmentDeclinationFactory
{
	public IEnrollmentDeclination GetByVersionIdSubjectTypeIdAndSubjectTargetId(int versionId, int subjectTypeId, long subjectTargetId)
	{
		Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination entity = Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination.GetBySubjectTypeIDSubjectTargetIDAndVersionID(subjectTypeId, subjectTargetId, versionId);
		if (entity != null)
		{
			return new EnrollmentDeclination(entity);
		}
		return null;
	}

	public IEnrollmentDeclination GetOrCreate(int versionId, int subjectTypeId, long subjectTargetId, int declinationReasonTypeId)
	{
		Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination entity = Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination.GetOrCreate(subjectTypeId, subjectTargetId, versionId, declinationReasonTypeId);
		if (entity != null)
		{
			return new EnrollmentDeclination(entity);
		}
		return null;
	}

	public void Delete(long id)
	{
		Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination.Get(id)?.Delete();
	}
}
