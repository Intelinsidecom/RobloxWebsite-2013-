using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStateCachedMssqlEntity : IMembershipMigrationStateEntity, IUpdateableEntity<int>, IEntity<int>
{
	public int Id { get; set; }

	public string Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		MembershipMigrationStateEntity cal = MembershipMigrationStateEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.Value = Value;
		cal.Created = Created;
		cal.Updated = Updated;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(MembershipMigrationStateEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
