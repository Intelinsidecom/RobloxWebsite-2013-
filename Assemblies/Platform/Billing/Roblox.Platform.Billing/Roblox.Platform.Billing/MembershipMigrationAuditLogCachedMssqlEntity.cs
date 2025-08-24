using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Billing;
using Roblox.Entities;

namespace Roblox.Platform.Billing;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationAuditLogCachedMssqlEntity : IMembershipMigrationAuditLogEntity, IUpdateableEntity<long>, IEntity<long>
{
	public long Id { get; set; }

	public long AccountId { get; set; }

	public int OriginalPremiumFeatureId { get; set; }

	public int UpdatedPremiumFeatureId { get; set; }

	public int OriginalProductId { get; set; }

	public int UpdatedProductId { get; set; }

	public decimal OriginalPrice { get; set; }

	public decimal UpdatedPrice { get; set; }

	public int RobuxGrantAmount { get; set; }

	public long SaleId { get; set; }

	public byte CurrencyTypeId { get; set; }

	public DateTime? LastRobuxDistributionDate { get; set; }

	public DateTime? UpdatedMembershipStartDate { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Update()
	{
		MembershipMigrationAuditLog cal = MembershipMigrationAuditLog.Get(Id);
		if (cal == null)
		{
			throw new InvalidOperationException("Attempted update on unpersisted entity.");
		}
		cal.AccountID = AccountId;
		cal.OriginalPremiumFeatureID = OriginalPremiumFeatureId;
		cal.UpdatedPremiumFeatureID = UpdatedPremiumFeatureId;
		cal.OriginalProductID = OriginalProductId;
		cal.UpdatedProductID = UpdatedProductId;
		cal.OriginalPrice = OriginalPrice;
		cal.UpdatedPrice = UpdatedPrice;
		cal.RobuxGrantAmount = RobuxGrantAmount;
		cal.SaleID = SaleId;
		cal.CurrencyTypeID = CurrencyTypeId;
		cal.LastRobuxDistributionDate = LastRobuxDistributionDate;
		cal.UpdatedMembershipStartDate = UpdatedMembershipStartDate;
		cal.Save();
		Updated = cal.Updated;
	}

	public void Delete()
	{
		(MembershipMigrationAuditLog.Get(Id) ?? throw new InvalidOperationException("Attempted delete on unpersisted entity.")).Delete();
	}
}
