using System.ComponentModel;

namespace Roblox.Platform.Membership;

public enum PasswordValidationResult
{
	[Description("")]
	ValidPassword = 0,
	[Description("Password must contain at least 2 digits, 4 letters, 1 symbol, and be at least 8 characters")]
	VipPasswordError = 1,
	[Description("Must be at least 8 characters long")]
	MemberPasswordError = 2,
	[Description("Password must not be your username")]
	PasswordUserNameSameError = 3,
	[Description("This password is not allowed. Please choose a different password")]
	ForbiddenPasswordError = 4,
	[Description("Please create a more complex password")]
	DumbStringsError = 5,
	[Description("Incorrect password for account")]
	IncorrectPasswordForAccountError = 7,
	[Description("Password must not be blank")]
	NullOrEmptyPasswordForAccountError = 8,
	[Description("A valid user name must be used while validating a password")]
	InvalidAccountError = 9
}
