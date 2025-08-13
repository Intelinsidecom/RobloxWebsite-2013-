using System;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class Enrollment : IEnrollment
{
	public long Id { get; internal set; }

	public int SubjectTypeId { get; internal set; }

	public long SubjectTargetId { get; internal set; }

	public int VariationId { get; internal set; }

	public int VersionId { get; internal set; }

	public DateTime Created { get; internal set; }

	public DateTime Updated { get; internal set; }

	public Enrollment()
	{
	}

	internal Enrollment(Roblox.Platform.AbTesting.Core.Entities.Enrollment entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Created = entity.Created;
		Id = entity.ID;
		SubjectTargetId = entity.SubjectTargetID;
		SubjectTypeId = entity.SubjectTypeID;
		Updated = entity.Updated;
		VariationId = entity.VariationID;
		VersionId = entity.VersionID;
	}

	public virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.Enrollment entity = Roblox.Platform.AbTesting.Core.Entities.Enrollment.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.Enrollment();
		entity.SubjectTargetID = SubjectTargetId;
		entity.SubjectTypeID = SubjectTypeId;
		entity.VariationID = VariationId;
		entity.VersionID = VersionId;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}
}
