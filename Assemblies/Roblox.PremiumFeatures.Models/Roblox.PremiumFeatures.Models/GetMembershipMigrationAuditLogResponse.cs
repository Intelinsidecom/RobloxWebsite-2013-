using System;
using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Core;

namespace Roblox.PremiumFeatures.Models;

/// <summary>
/// Membership Migration Record Response
/// </summary>
[DataContract]
public class GetMembershipMigrationAuditLogResponse : MembershipMigrationResponse
{
	[DataMember(Name = "originalPremiumFeatureId")]
	public int OriginalPremiumFeatureID;

	[DataMember(Name = "updatedPremiumFeatureId")]
	public int UpdatedPremiumFeatureID;

	[DataMember(Name = "originalProductId")]
	public int OriginalProductID;

	[DataMember(Name = "updatedProductId")]
	public int UpdatedProductID;

	[DataMember(Name = "originalPrice")]
	public Money OriginalPrice;

	[DataMember(Name = "updatedPrice")]
	public Money UpdatedPrice;

	[DataMember(Name = "robuxGrantAmount")]
	public int RobuxGrantAmount;

	[DataMember(Name = "lastRobuxDistributionDate")]
	public DateTime? LastRobuxDistributionDate;

	[DataMember(Name = "updatedMembershipStartDate", EmitDefaultValue = false)]
	public DateTime? UpdatedMembershipStartDate;

	[DataMember(Name = "created")]
	public DateTime Created;

	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	public GetMembershipMigrationAuditLogResponse(MembershipMigrationAuditLogModel model)
	{
		UserId = model.UserId;
		OriginalPremiumFeatureID = model.OriginalPremiumFeatureId;
		UpdatedPremiumFeatureID = model.UpdatedPremiumFeatureId;
		OriginalProductID = model.UpdatedProductId;
		OriginalPrice = model.OriginalPrice;
		UpdatedPrice = model.UpdatedPrice;
		RobuxGrantAmount = model.RobuxGrantAmount;
		LastRobuxDistributionDate = model.LastRobuxDistributionDate;
		UpdatedMembershipStartDate = model.UpdatedMembershipStartDate;
		Created = model.Created;
	}
}
