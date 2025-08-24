using System;
using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Core;

namespace Roblox.PremiumFeatures.Models;

/// <summary>
/// Membership Migration Audit Log Model
/// </summary>
[DataContract]
public class MembershipMigrationAuditLogModel
{
	[DataMember(Name = "id")]
	public long Id;

	[DataMember(Name = "userId")]
	public long UserId;

	[DataMember(Name = "accountId")]
	public long AccountId;

	[DataMember(Name = "originalPremiumFeatureId")]
	public int OriginalPremiumFeatureId;

	[DataMember(Name = "updatedPremiumFeatureId")]
	public int UpdatedPremiumFeatureId;

	[DataMember(Name = "originalProductId")]
	public int OriginalProductId;

	[DataMember(Name = "updatedProductId")]
	public int UpdatedProductId;

	[DataMember(Name = "currencyTypeId")]
	public int CurrencyTypeId;

	[DataMember(Name = "originalPrice")]
	public Money OriginalPrice;

	[DataMember(Name = "updatedPrice")]
	public Money UpdatedPrice;

	[DataMember(Name = "robuxGrantAmount")]
	public int RobuxGrantAmount;

	[DataMember(Name = "saleId")]
	public long SaleID;

	[DataMember(Name = "lastRobuxDistributionDate")]
	public DateTime? LastRobuxDistributionDate;

	[DataMember(Name = "updatedMembershipStartDate")]
	public DateTime? UpdatedMembershipStartDate;

	[DataMember(Name = "created")]
	public DateTime Created;

	[DataMember(Name = "updated")]
	public DateTime Updated;
}
