using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationStatusCachedMssqlEntity : IMembershipMigrationStatusEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public int OriginalPremiumFeatureId { get; set; }

	public int UpdatedPremiumFeatureId { get; set; }

	public DateTime? PremiumStartDate { get; set; }

	public int RobuxDistributionAmount { get; set; }

	public int MigrationStateID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		MembershipMigrationStatusEntity cal = MembershipMigrationStatusEntity.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.OriginalPremiumFeatureID = OriginalPremiumFeatureId;
		cal.UpdatedPremiumFeatureID = UpdatedPremiumFeatureId;
		cal.PremiumStartDate = PremiumStartDate;
		cal.RobuxDistributionAmount = RobuxDistributionAmount;
		cal.MigrationStateID = MigrationStateID;
		cal.Created = Created;
		cal.Updated = Updated;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(MembershipMigrationStatusEntity.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
