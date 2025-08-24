using System;
using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models;

[DataContract]
public class AttemptMembershipMigrationResponse : MembershipMigrationResponse
{
	/// <summary>
	/// Premium Feature Name
	/// </summary>
	[DataMember(Name = "premiumFeatureName")]
	public string PremiumFeatureName;

	/// <summary>
	/// UserId
	/// </summary>
	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	/// <summary>
	/// Number of robux granted due to migration
	/// </summary>
	[DataMember(Name = "robuxGranted")]
	public int RobuxGranted { get; set; }

	/// <summary>
	/// Stipend Frequency
	/// </summary>
	[DataMember(Name = "stipendFrequency")]
	public string StipendFrequency { get; set; }

	/// <summary>
	/// New Robux stipend amount
	/// </summary>
	[DataMember(Name = "newRobuxStipendAmount")]
	public int NewRobuxStipendAmount { get; set; }

	/// <summary>
	/// Premium start date
	/// </summary>
	[DataMember(Name = "premiumStartDate")]
	public DateTime PremiumStartDate { get; set; }

	public AttemptMembershipMigrationResponse(MembershipMigrationModel model)
	{
		UserId = model.UserId;
		StipendFrequency = model.StipendFrequency;
		NewRobuxStipendAmount = model.StipendAmount;
		PremiumStartDate = model.PremiumStartDate;
		RobuxGranted = model.RobuxGranted;
		PremiumFeatureName = model.PremiumFeatureName;
	}

	/// <summary>
	/// For deserialization
	/// </summary>
	public AttemptMembershipMigrationResponse()
	{
	}
}
