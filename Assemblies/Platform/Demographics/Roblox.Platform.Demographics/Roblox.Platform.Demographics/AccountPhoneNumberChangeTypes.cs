using System.ComponentModel;

namespace Roblox.Platform.Demographics;

public enum AccountPhoneNumberChangeTypes
{
	[Description("Data migration")]
	DataMigration = 1,
	[Description("entered phone number to be verified")]
	UnverifiedPhoneNumberEntered,
	[Description("verified phone number")]
	PhoneNumberVerified,
	[Description("deleted phone number")]
	PhoneNumberDeleted
}
