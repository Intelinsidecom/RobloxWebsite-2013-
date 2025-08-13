using System;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class EnrollmentDeclination : IEnrollmentDeclination
{
	public long Id { get; internal set; }

	public int SubjectTypeId { get; internal set; }

	public long SubjectTargetId { get; internal set; }

	public int VersionId { get; internal set; }

	public int DeclinationReasonTypeId { get; internal set; }

	public DateTime Created { get; internal set; }

	public EnrollmentDeclination()
	{
	}

	internal EnrollmentDeclination(Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Created = entity.Created;
		Id = entity.ID;
		SubjectTargetId = entity.SubjectTargetID;
		SubjectTypeId = entity.SubjectTypeID;
		VersionId = entity.VersionID;
		DeclinationReasonTypeId = entity.DeclinationReasonTypeID;
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination entity = Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.EnrollmentDeclination();
		entity.SubjectTargetID = SubjectTargetId;
		entity.SubjectTypeID = SubjectTypeId;
		entity.VersionID = VersionId;
		entity.DeclinationReasonTypeID = DeclinationReasonTypeId;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
	}
}
