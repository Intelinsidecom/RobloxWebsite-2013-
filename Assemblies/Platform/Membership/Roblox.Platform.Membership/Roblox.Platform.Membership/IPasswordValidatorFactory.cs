using System;

namespace Roblox.Platform.Membership;

public interface IPasswordValidatorFactory
{
	[Obsolete("Use the IUser variant instead")]
	bool CheckPasswordRulesAndPasswordIsNotCurrent(Account account, string password, out string errorMessage);

	bool CheckPasswordRulesAndPasswordIsNotCurrent(IUser user, string password, out string errorMessage);

	[Obsolete("Use ValidatePasswordRules instead")]
	bool CheckPasswordRules(string accountName, string password);

	[Obsolete("Use ValidatePasswordRules instead")]
	bool CheckPasswordRules(string accountName, string password, out string errMessage);

	bool ValidateAccountPassword(string accountName, string password);

	PasswordRule GetPasswordRuleByAccount(Account account);

	PasswordRule GetPasswordRule(string accountName = null);

	/// <summary>
	/// Validates password as per password validation rules.
	/// </summary>
	/// <param name="accountName">name of the account</param>
	/// <param name="password">password that needs to validated</param>
	/// <returns>IPasswordValidationResult</returns>
	IPasswordValidationResponse ValidatePasswordRules(string accountName, string password);
}
