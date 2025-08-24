using System;
using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models;

/// <summary>
/// Membership Migration Model
/// </summary>
[DataContract]
public class MembershipMigrationModel
{
	[DataMember(Name = "userId")]
	public long UserId;

	[DataMember(Name = "robuxGranted")]
	public int RobuxGranted;

	[DataMember(Name = "stipendAmount")]
	public int StipendAmount;

	[DataMember(Name = "stipendFrequency")]
	public string StipendFrequency;

	[DataMember(Name = "premiumStartDate")]
	public DateTime PremiumStartDate;

	[DataMember(Name = "premiumFeatureName")]
	public string PremiumFeatureName;
}
