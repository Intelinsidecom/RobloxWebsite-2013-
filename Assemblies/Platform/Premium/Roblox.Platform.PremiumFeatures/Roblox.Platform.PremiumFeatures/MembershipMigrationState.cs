using System.ComponentModel;

namespace Roblox.PremiumFeatures;

/// <summary>
/// MembershipMigration states, DescriptionAttributes have to match values in RobloxPremiumFeatures table
/// </summary>
public enum MembershipMigrationState
{
	[Description("Unknown")]
	Unknown = 0,
	[Description("Calculations Completed")]
	CalculationsCompleted = 10,
	[Description("LeasedLocks Obtained")]
	LeasedLocksObtained = 20,
	[Description("Updated Account AddOn")]
	UpdatedAccountAddOn = 30,
	[Description("Updated Robux Stipend")]
	UpdatedRobuxStipend = 40,
	[Description("Updated Vendor Payment")]
	UpdatedVendorPayment = 50,
	[Description("Updated Sale")]
	UpdatedSale = 60,
	[Description("Updated Sale Product")]
	UpdatedSaleProduct = 70,
	[Description("Granted Robux")]
	GrantedRobux = 80,
	[Description("Message Sent")]
	MessageSent = 90,
	[Description("Completed")]
	Completed = 100
}
