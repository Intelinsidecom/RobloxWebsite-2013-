using System.ComponentModel;

namespace Roblox.Platform.Demographics;

public enum DisconnectAccountPhoneNumbersReasons
{
	[Description("Account phone number deleted because of COPPA.")]
	DeletedBecauseOfCOPPA = 1,
	[Description("Account phone number delete because PII removal request.")]
	DeletedBecauseOfPII,
	[Description("Account phone number deleted because of other reasons.")]
	DeletedOtherReason
}
